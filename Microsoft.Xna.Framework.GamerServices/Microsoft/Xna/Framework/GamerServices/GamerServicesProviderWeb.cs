// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerServicesProviderWeb
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using GamerServices.Platforms.Web;
using Microsoft.Xna.Framework.GamerServices.LIVEn;
using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class GamerServicesProviderWeb : IGamerServicesProvider, IDisposable
  {
    private bool isDisposed;
    private HandleManager handleManager;
    private IAsyncResult signedInAr;
    private LIVEnGamer signedInGamer;
    private int signedInGamerHandle;
    internal ILIVEnService webService;
    internal static ILIVEnService hookedService;
    private IAsyncResult leaderboardWriteAr;
    private bool firstUpdate;
    private static bool leaderboardWriteRequested;
    private static GamerServicesProviderWeb threadLock;

    internal GamerServicesProviderWeb()
    {
      this.firstUpdate = true;
      this.handleManager = new HandleManager();
      GamerServicesProviderAccesor.Provider = this;
      GamerServicesProviderWeb.threadLock = this;
    }

    public event EventHandler<GSSignedInStatusChangedEventArgs> SignedInStatusChanged;

    public event EventHandler<GSWriteLeaderboardEventArgs> WriteLeaderboard;

    public void Initialize()
    {
      if (GamerServicesProviderWeb.hookedService != null)
      {
        GamerServicesProviderAccesor.orgWebService = (ILIVEnService) new LIVEnService();
        this.webService = GamerServicesProviderWeb.hookedService;
      }
      else
        this.webService = (ILIVEnService) new LIVEnService();
      this.webService.Initialize();
    }

    public void Update()
    {
      if (this.firstUpdate)
      {
        this.firstUpdate = false;
        XlastConfiguration instance = XlastConfiguration.Instance;
        this.signedInGamer = new LIVEnGamer();
        this.signedInGamerHandle = this.handleManager.AddEntry(HandleType.Gamer, (object) this.signedInGamer);
        this.signedInGamer.Handle = this.signedInGamerHandle;
        this.signedInAr = this.QueueAsyncTask((LIVEnTask) new LIVEnProfileReader(this.signedInGamer, (string) null, true), (AsyncCallback) null, (object) null);
      }
      if (this.signedInAr != null && this.signedInAr.IsCompleted)
      {
        LIVEnProfileReader signedInAr = this.signedInAr as LIVEnProfileReader;
        this.signedInAr = (IAsyncResult) null;
        signedInAr.EndProcess();
        this.signedInGamer.UpdatePrivileges(this.webService);
        if (this.SignedInStatusChanged != null)
          this.SignedInStatusChanged((object) this, new GSSignedInStatusChangedEventArgs(this.signedInGamerHandle, 0, this.signedInGamer.SignInState));
        if (this.signedInGamer.SignInState != PlayerSignInState.SignedInToLive)
          this.InvokeDownloadPrivilegeOptions();
      }
      if (this.signedInAr == null && this.signedInGamer.UpdatePrivileges(this.webService) && this.SignedInStatusChanged != null)
        this.SignedInStatusChanged((object) this, new GSSignedInStatusChangedEventArgs(this.signedInGamerHandle, 0, this.signedInGamer.SignInState));
      if (!GamerServicesProviderWeb.leaderboardWriteRequested || this.IsWritingToLeaderboard())
        return;
      this.FlushLeaderboardWrite();
    }

    ~GamerServicesProviderWeb() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private void Shutdown()
    {
      if (this.signedInGamer != null)
      {
        this.handleManager.RemoveEntry(this.signedInGamer.GamerPicture);
        this.handleManager.RemoveEntry(this.signedInGamer.Handle);
        this.signedInGamer = (LIVEnGamer) null;
        this.signedInGamerHandle = -1;
      }
      SafeMobileNativeMethods.GameFoundation_Shutdown();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.isDisposed)
        return;
      this.isDisposed = true;
      this.Shutdown();
    }

    public void FillGamer(int gamerHandle, IPropertyFiller filler)
    {
      if (!(this.handleManager.GetValue(gamerHandle) is LIVEnGamer livEnGamer))
        return;
      filler.BeginFillData();
      filler.SetNamedValue(GSPropertyName.Gamertag, livEnGamer.Gamertag);
      filler.SetNamedValue(GSPropertyName.DisplayName, livEnGamer.DisplayName);
      filler.SetNamedValue(GSPropertyName.SignInState, (int) livEnGamer.SignInState);
      filler.SetNamedValue(GSPropertyName.PrivilegeOptions, (int) livEnGamer.Privileges);
      filler.EndFillData();
    }

    public IAsyncResult BeginGetGamerFromGamertag(
      string gamertag,
      AsyncCallback callback,
      object asyncState)
    {
      LIVEnGamer gamer = new LIVEnGamer();
      gamer.Handle = this.handleManager.AddEntry(HandleType.Gamer, (object) gamer);
      return this.QueueAsyncTask((LIVEnTask) new LIVEnProfileReader(gamer, gamertag, false), callback, asyncState);
    }

    public void EndGetGamerFromGamertag(IAsyncResult result, IPropertyFiller filler) => this.EndFillProfile(result, filler);

    public IAsyncResult BeginGetPartnerToken(
      string audienceUri,
      AsyncCallback callback,
      object asyncState)
    {
      return this.QueueAsyncTask((LIVEnTask) new LIVEnPartnerTokenReader(audienceUri), callback, asyncState);
    }

    public string EndGetPartnerToken(IAsyncResult result)
    {
      if (!(result is LIVEnPartnerTokenReader partnerTokenReader))
        throw new InvalidOperationException();
      partnerTokenReader.EndProcess();
      return partnerTokenReader.Token;
    }

    public void InvokeDownloadPrivilegeOptions() => this.QueueAsyncTask((LIVEnTask) new LIVEnPrivilegesReader(), (AsyncCallback) (ar => (ar as LIVEnPrivilegesReader).EndProcess()), (object) null);

    public IAsyncResult BeginFillProfile(
      int gamerHandle,
      AsyncCallback callback,
      object asyncState)
    {
      if (!(this.handleManager.GetValue(gamerHandle) is LIVEnGamer gamer))
        throw new InvalidOperationException();
      string gamertag = this.signedInGamerHandle == gamerHandle ? (string) null : gamer.Gamertag;
      IAsyncResult ar;
      if (gamer.IsDirty)
      {
        ar = this.QueueAsyncTask((LIVEnTask) new LIVEnProfileReader(gamer, gamertag, this.signedInGamerHandle == gamerHandle), callback, asyncState);
      }
      else
      {
        ar = (IAsyncResult) new GamerServicesProviderWeb.ImmidiateAsyncResult(gamer, asyncState);
        if (callback != null)
          callback(ar);
      }
      return ar;
    }

    public void EndFillProfile(IAsyncResult result, IPropertyFiller filler)
    {
      LIVEnGamer gamer;
      if (result is LIVEnProfileReader)
      {
        LIVEnProfileReader livEnProfileReader = result as LIVEnProfileReader;
        livEnProfileReader.EndProcess();
        gamer = livEnProfileReader.Gamer;
      }
      else
        gamer = ((GamerServicesProviderWeb.ImmidiateAsyncResult) result).Gamer;
      gamer.FillGamerProfile(filler);
    }

    public int FillFriendCollection(int gamer, IPropertyCollectionFiller fillers) => throw new NotImplementedException();

    public void DisposeGamer(int gamerHandle)
    {
      if (gamerHandle == this.signedInGamerHandle || !(this.handleManager.GetValue(gamerHandle) is LIVEnGamer livEnGamer))
        return;
      this.handleManager.RemoveEntry(livEnGamer.GamerPicture);
      this.handleManager.RemoveEntry(gamerHandle);
    }

    public void DisposeFriendCollection(int friendsHandle) => throw new NotImplementedException();

    public bool IsFriend(int gamer1, int gamer2) => false;

    public Stream GetStream(int handle) => this.handleManager.GetValue(handle) as Stream;

    public int CreateStream(byte[] buffer, int size)
    {
      GamerServicesProviderWeb.LIVEnStream livEnStream = buffer == null ? new GamerServicesProviderWeb.LIVEnStream(this.handleManager, size) : new GamerServicesProviderWeb.LIVEnStream(this.handleManager, buffer);
      livEnStream.Handle = this.handleManager.AddEntry(HandleType.Stream, (object) livEnStream);
      return livEnStream.Handle;
    }

    public void WritePresence(int gamer, string presence) => throw new NotImplementedException();

    public void WritePresence(int gamer, int presenceMode, int presenceValue) => throw new NotImplementedException();

    public IAsyncResult BeginGetAchievements(
      int gamer,
      AsyncCallback callback,
      object asyncState)
    {
      return this.QueueAsyncTask((LIVEnTask) new LIVEnAchievementsReader(), callback, asyncState);
    }

    public void EndGetAchievements(IAsyncResult result, IPropertyCollectionFiller fillers)
    {
      LIVEnAchievementsReader achievementsReader = result as LIVEnAchievementsReader;
      achievementsReader.EndProcess();
      List<LIVEnAchievement> achievements = achievementsReader.Achievements;
      fillers.Reserve(achievements.Count);
      IEnumerator<IPropertyFiller> enumerator = fillers.GetEnumerator();
      for (int index = 0; index < achievements.Count; ++index)
      {
        LIVEnAchievement livEnAchievement = achievements[index];
        enumerator.MoveNext();
        IPropertyFiller current = enumerator.Current;
        current.BeginFillData();
        current.SetNamedValue(GSPropertyName.AchievementDescription, livEnAchievement.Description);
        current.SetNamedValue(GSPropertyName.AchievementDisplayBeforeEarned, livEnAchievement.DisplayBeforeEarned ? 1 : 0);
        current.SetNamedValue(GSPropertyName.AchievementEarnedDateTime, livEnAchievement.EarnedDateTime);
        current.SetNamedValue(GSPropertyName.AchievementEarnedOnline, livEnAchievement.EarnedOnline ? 1 : 0);
        current.SetNamedValue(GSPropertyName.AchievementGamerScore, livEnAchievement.GameScore);
        current.SetNamedValue(GSPropertyName.AchievementHowToEarn, livEnAchievement.HowToEarn);
        current.SetNamedValue(GSPropertyName.AchievementIsEarned, livEnAchievement.IsEarned ? 1 : 0);
        current.SetNamedValue(GSPropertyName.AchievementKey, livEnAchievement.Key);
        current.SetNamedValue(GSPropertyName.AchievementName, livEnAchievement.Name);
        current.SetNamedValue(GSPropertyName.AchievementPicture, livEnAchievement.Picture);
        current.EndFillData();
      }
    }

    public IAsyncResult BeginAwardAchievement(
      int gamerHandle,
      string awardKey,
      AsyncCallback callback,
      object asyncState)
    {
      if (!(this.handleManager.GetValue(gamerHandle) is LIVEnGamer livEnGamer))
        throw new InvalidOperationException();
      livEnGamer.Touch();
      return this.QueueAsyncTask((LIVEnTask) new LIVEnAchievementGranter(awardKey), callback, asyncState);
    }

    public void EndAward(IAsyncResult result) => (result as LIVEnAchievementGranter).EndProcess();

    public IAsyncResult BeginReadLeaderboard(
      LeaderboardIdentity leaderboardId,
      IEnumerable<int> gamerHandles,
      int pivotGamer,
      int pageStart,
      int pageSize,
      AsyncCallback callback,
      object asyncState)
    {
      this.FlushLeaderboardWrite();
      int? pageStart1 = new int?();
      if (pivotGamer != this.signedInGamerHandle)
        pageStart1 = new int?(pageStart + 1);
      string leaderboardName;
      string dataGroup;
      if (!GamerServicesProviderWeb.DecodeLeaderboardId(leaderboardId.Key, out leaderboardName, out dataGroup))
        throw new ArgumentException(nameof (leaderboardId));
      return this.QueueAsyncTask((LIVEnTask) new LIVEnLeaderboardReader(this.leaderboardWriteAr, leaderboardId, leaderboardName, dataGroup, pageStart1, pageSize), callback, asyncState);
    }

    public GSLeaderboard EndReadLeaderboard(
      IAsyncResult result,
      IPropertyCollectionFiller fillers)
    {
      LIVEnLeaderboardReader leaderboardReader = result as LIVEnLeaderboardReader;
      leaderboardReader.EndProcess();
      List<LIVEnLeaderboardEntry> entries = leaderboardReader.Entries;
      fillers.Reserve(entries.Count);
      IEnumerator<IPropertyFiller> enumerator = fillers.GetEnumerator();
      for (int index = 0; index < entries.Count; ++index)
      {
        LIVEnLeaderboardEntry leaderboardEntry = entries[index];
        enumerator.MoveNext();
        int num = this.handleManager.AddEntry(HandleType.Gamer, (object) leaderboardEntry);
        leaderboardEntry.Handle = num;
        IPropertyFiller current = enumerator.Current;
        current.BeginFillData();
        current.SetNamedValue(GSPropertyName.LeaderboardRating, leaderboardEntry.Value);
        current.SetNamedValue(GSPropertyName.LeaderboardGamer, num);
        current.SetNamedValue(GSPropertyName.LeaderboardRank, leaderboardEntry.Rank);
        current.SetNamedValue(GSPropertyName.LeaderboardBestScore, leaderboardEntry.BestScore);
        current.SetNamedValue(GSPropertyName.LeaderboardCumulativeScore, leaderboardEntry.CumulativeScore);
        current.SetNamedValue(GSPropertyName.LeaderboardAverageScore, leaderboardEntry.AverageScore);
        current.SetNamedValue(GSPropertyName.LeaderboardBestScoreBlob, leaderboardEntry.BestScoreDatablob);
        current.SetNamedValue(GSPropertyName.LeaderboardBestTime, leaderboardEntry.BestTime);
        current.SetNamedValue(GSPropertyName.LeaderboardCumulativeTime, leaderboardEntry.CumulativeTime);
        current.SetNamedValue(GSPropertyName.LeaderboardAverageTime, leaderboardEntry.AverageTime);
        current.SetNamedValue(GSPropertyName.LeaderboardBestTimeBlob, leaderboardEntry.BestTimeDatablob);
        current.SetNamedValue(GSPropertyName.LeaderboardWins, leaderboardEntry.Wins);
        current.SetNamedValue(GSPropertyName.LeaderboardLosses, leaderboardEntry.Losses);
        current.SetNamedValue(GSPropertyName.LeaderboardGamesPlayed, leaderboardEntry.GamesPlayed);
        current.SetNamedValue(GSPropertyName.LeaderboardLastPlayedDateTime, leaderboardEntry.LastPlayedDateTime);
        current.EndFillData();
      }
      int num1 = 0;
      if (entries.Count > 0)
        num1 = entries[0].Rank - 1;
      return new GSLeaderboard()
      {
        Id = leaderboardReader.LeaderboardId,
        PageStart = num1,
        PageSize = leaderboardReader.PageSize,
        TotalEntries = leaderboardReader.TotalLeaderboardSize
      };
    }

    public void FillLeaderboardColumns(
      LeaderboardIdentity leaderboardId,
      bool reading,
      ILeaderboardColumnFiller columnFiller)
    {
      if (reading)
      {
        columnFiller.Reserve(14);
        columnFiller.BeginFillData();
        columnFiller.AddColumn("Rank", typeof (long), true);
        columnFiller.AddColumn("TimeStamp", typeof (long), true);
        columnFiller.AddColumn("BestScore", typeof (long), true);
        columnFiller.AddColumn("BestTime", typeof (long), true);
        columnFiller.AddColumn("CumulativeScore", typeof (long), true);
        columnFiller.AddColumn("CumulativeTime", typeof (long), true);
        columnFiller.AddColumn("GamesPlayed", typeof (long), true);
        columnFiller.AddColumn("AverageScore", typeof (long), true);
        columnFiller.AddColumn("AverageTime", typeof (long), true);
        columnFiller.AddColumn("Wins", typeof (long), true);
        columnFiller.AddColumn("Losses", typeof (long), true);
        columnFiller.AddColumn("BestScoreBlob", typeof (Stream), true);
        columnFiller.AddColumn("BestTimeBlob", typeof (Stream), true);
        columnFiller.AddColumn("LastPlayedDateTime", typeof (long), true);
        columnFiller.EndFillData();
      }
      else
      {
        columnFiller.Reserve(7);
        columnFiller.BeginFillData();
        columnFiller.AddColumn("Rank", typeof (long), false);
        columnFiller.AddColumn("Score", typeof (long), false);
        columnFiller.AddColumn("Time", typeof (long), false);
        columnFiller.AddColumn("Outcome", typeof (int), false);
        columnFiller.AddColumn("ScoreBlob", typeof (Stream), false);
        columnFiller.AddColumn("TimeBlob", typeof (Stream), false);
        columnFiller.AddColumn("TimeStamp", typeof (long), false);
        columnFiller.EndFillData();
      }
    }

    public void WriteToLeaderboard(
      LeaderboardIdentity leaderboardId,
      IPropertyCollectionFiller fillers)
    {
      if (this.IsWritingToLeaderboard())
        this.leaderboardWriteAr.AsyncWaitHandle.WaitOne();
      string lower = leaderboardId.Key.ToLower();
      bool isScoreEntry;
      if (!(lower == "score"))
      {
        if (!(lower == "bestscorerecent"))
        {
          if (!(lower == "bestscorelifetime"))
          {
            if (!(lower == "time"))
            {
              if (!(lower == "besttimerecent"))
              {
                if (!(lower == "besttimelifetime"))
                  throw new ArgumentException(nameof (leaderboardId));
                isScoreEntry = false;
              }
              else
                isScoreEntry = false;
            }
            else
              isScoreEntry = false;
          }
          else
            isScoreEntry = true;
        }
        else
          isScoreEntry = true;
      }
      else
        isScoreEntry = true;
      List<LIVEnLeaderboardWriteEntry> leaderboardWriteEntryList = new List<LIVEnLeaderboardWriteEntry>();
      foreach (IPropertyFiller filler in (IEnumerable<IPropertyFiller>) fillers)
      {
        LIVEnLeaderboardWriteEntry leaderboardWriteEntry = new LIVEnLeaderboardWriteEntry();
        filler.TryGetNamedValue(GSPropertyName.LeaderboardRating, out leaderboardWriteEntry.Rating);
        int num;
        filler.TryGetNamedValue(GSPropertyName.LeaderboardOutcome, out num);
        leaderboardWriteEntry.Outcome = (LeaderboardOutcome) num;
        int handle;
        filler.TryGetNamedValue(isScoreEntry ? GSPropertyName.LeaderboardScoreBlob : GSPropertyName.LeaderboardTimeBlob, out handle);
        if (handle != 0)
        {
          Stream stream = this.GetStream(handle);
          leaderboardWriteEntry.Blob = new byte[stream.Length];
          stream.Seek(0L, SeekOrigin.Begin);
          stream.Read(leaderboardWriteEntry.Blob, 0, leaderboardWriteEntry.Blob.Length);
        }
        leaderboardWriteEntryList.Add(leaderboardWriteEntry);
      }
      this.leaderboardWriteAr = this.QueueAsyncTask((LIVEnTask) new LIVEnLeaderboardWriter(leaderboardId.GameMode, isScoreEntry, (IList<LIVEnLeaderboardWriteEntry>) leaderboardWriteEntryList), (AsyncCallback) null, (object) null);
    }

    public IAsyncResult QueueAsyncTask(
      LIVEnTask task,
      AsyncCallback callback,
      object asyncState)
    {
      task.BeginProcess(this.webService, callback, asyncState);
      return (IAsyncResult) task;
    }

    private static bool DecodeLeaderboardId(
      string key,
      out string leaderboardName,
      out string dataGroup)
    {
      bool flag = true;
      string lower = key.ToLower();
      if (!(lower == "bestscorelifetime"))
      {
        if (!(lower == "bestscorerecent"))
        {
          if (!(lower == "besttimelifetime"))
          {
            if (lower == "besttimerecent")
            {
              leaderboardName = "BestTime";
              dataGroup = "W1";
            }
            else
            {
              leaderboardName = (string) null;
              dataGroup = (string) null;
              flag = false;
            }
          }
          else
          {
            leaderboardName = "BestTime";
            dataGroup = "LifeTime";
          }
        }
        else
        {
          leaderboardName = "BestScore";
          dataGroup = "W1";
        }
      }
      else
      {
        leaderboardName = "BestScore";
        dataGroup = "LifeTime";
      }
      return flag;
    }

    private bool IsWritingToLeaderboard() => this.leaderboardWriteAr != null && !this.leaderboardWriteAr.IsCompleted;

    private void FlushLeaderboardWrite()
    {
      lock (GamerServicesProviderWeb.threadLock)
      {
        if (!GamerServicesProviderWeb.leaderboardWriteRequested)
          return;
        if (this.IsWritingToLeaderboard())
          this.leaderboardWriteAr.AsyncWaitHandle.WaitOne();
        if (this.WriteLeaderboard != null)
          this.WriteLeaderboard((object) this, new GSWriteLeaderboardEventArgs(this.signedInGamerHandle));
        GamerServicesProviderWeb.leaderboardWriteRequested = false;
      }
    }

    internal static void RequestLeaderboardWrite()
    {
      lock (GamerServicesProviderWeb.threadLock)
        GamerServicesProviderWeb.leaderboardWriteRequested = true;
    }

    internal void HookTestService()
    {
      if (this.signedInGamer == null)
        return;
      this.signedInGamer.Touch();
    }

    private class ImmidiateAsyncResult : IAsyncResult
    {
      public object AsyncState { get; protected set; }

      public WaitHandle AsyncWaitHandle { get; private set; }

      public bool CompletedSynchronously => false;

      public bool IsCompleted => true;

      public ImmidiateAsyncResult(LIVEnGamer gamer, object asyncState)
      {
        this.Gamer = gamer;
        this.AsyncState = asyncState;
        this.AsyncWaitHandle = (WaitHandle) new ManualResetEvent(true);
      }

      public LIVEnGamer Gamer { get; protected set; }
    }

    private class LIVEnStream : MemoryStream, IDisposable
    {
      private HandleManager handleManager;

      public int Handle { get; internal set; }

      public LIVEnStream(HandleManager handleManager, byte[] buffer)
        : base(buffer, false)
      {
        this.handleManager = handleManager;
      }

      public LIVEnStream(HandleManager handleManager, int capacity)
        : base(capacity)
      {
        this.handleManager = handleManager;
      }

      public override void Write(byte[] buffer, int offset, int count)
      {
        if (count < 0)
          throw new ArgumentOutOfRangeException(nameof (count));
        if (this.Position + (long) count > (long) this.Capacity)
          throw new NotSupportedException(FrameworkResources.BlobStreamIsNotExpandable);
        base.Write(buffer, offset, count);
      }

      void IDisposable.Dispose()
      {
        this.handleManager.RemoveEntry(this.Handle);
        this.Dispose();
      }
    }
  }
}
