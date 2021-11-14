// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LeaderboardReader
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class LeaderboardReader : IDisposable
  {
    private LeaderboardIdentity leaderboardId;
    private int totalLeaderboardSize;
    private int pageStart;
    private int pageSize;
    private IAsyncResult currentPageOperation;
    private bool currentPageUp;
    private ReadOnlyCollection<LeaderboardEntry> entries;
    private List<LeaderboardEntry> allEntries;
    private uint kernelHandle;

    public LeaderboardIdentity LeaderboardIdentity => this.leaderboardId;

    public int TotalLeaderboardSize => this.totalLeaderboardSize;

    public int PageStart => this.pageStart;

    public ReadOnlyCollection<LeaderboardEntry> Entries => this.entries;

    private LeaderboardReader()
    {
    }

    public static LeaderboardReader Read(
      LeaderboardIdentity leaderboardId,
      IEnumerable<Gamer> gamers,
      Gamer pivotGamer,
      int pageSize)
    {
      return LeaderboardReader.EndRead(LeaderboardReader.BeginRead(leaderboardId, gamers, pivotGamer, pageSize, (AsyncCallback) null, (object) null));
    }

    public static LeaderboardReader Read(
      LeaderboardIdentity leaderboardId,
      Gamer pivotGamer,
      int pageSize)
    {
      return LeaderboardReader.EndRead(LeaderboardReader.BeginRead(leaderboardId, pivotGamer, pageSize, (AsyncCallback) null, (object) null));
    }

    public static LeaderboardReader Read(
      LeaderboardIdentity leaderboardId,
      int pageStart,
      int pageSize)
    {
      return LeaderboardReader.EndRead(LeaderboardReader.BeginRead(leaderboardId, pageStart, pageSize, (AsyncCallback) null, (object) null));
    }

    public static IAsyncResult BeginRead(
      LeaderboardIdentity leaderboardId,
      IEnumerable<Gamer> gamers,
      Gamer pivotGamer,
      int pageSize,
      AsyncCallback callback,
      object asyncState)
    {
      return LeaderboardReader.BeginReadInternal(leaderboardId, gamers, pivotGamer, 0, pageSize, callback, asyncState);
    }

    public static IAsyncResult BeginRead(
      LeaderboardIdentity leaderboardId,
      Gamer pivotGamer,
      int pageSize,
      AsyncCallback callback,
      object asyncState)
    {
      return LeaderboardReader.BeginReadInternal(leaderboardId, (IEnumerable<Gamer>) null, pivotGamer, 0, pageSize, callback, asyncState);
    }

    public static IAsyncResult BeginRead(
      LeaderboardIdentity leaderboardId,
      int pageStart,
      int pageSize,
      AsyncCallback callback,
      object asyncState)
    {
      return LeaderboardReader.BeginReadInternal(leaderboardId, (IEnumerable<Gamer>) null, (Gamer) null, pageStart, pageSize, callback, asyncState);
    }

    private static IAsyncResult BeginReadInternal(
      LeaderboardIdentity leaderboardId,
      IEnumerable<Gamer> gamers,
      Gamer pivotGamer,
      int pageStart,
      int pageSize,
      AsyncCallback callback,
      object asyncState)
    {
      Logger.BeginLogEvent(LoggingEvent.LeaderboardRead, "XNA: Begin Leaderboard Read");
      List<int> intList = (List<int>) null;
      int pivotGamer1 = 0;
      if (gamers != null)
      {
        intList = new List<int>(101);
        foreach (Gamer gamer in gamers)
          intList.Add((int) gamer.KernelHandle);
      }
      if (pivotGamer != null)
        pivotGamer1 = (int) pivotGamer.KernelHandle;
      LeaderboardReader.AsyncResult asyncResult1 = new LeaderboardReader.AsyncResult();
      IAsyncResult asyncResult2 = GamerServicesDispatcher.Gsp.BeginReadLeaderboard(leaderboardId, (IEnumerable<int>) intList, pivotGamer1, pageStart, pageSize, new AsyncCallback(asyncResult1.Completed), asyncState);
      asyncResult1.Id = leaderboardId;
      asyncResult1.ActualAr = asyncResult2;
      asyncResult1.Callback = callback;
      return (IAsyncResult) asyncResult1;
    }

    public static LeaderboardReader EndRead(IAsyncResult result)
    {
      LeaderboardReader leaderboardReader = new LeaderboardReader();
      leaderboardReader.EndReadInternal(result);
      Logger.EndLogEvent(LoggingEvent.LeaderboardRead, "XNA: End Leaderboard Read");
      return leaderboardReader;
    }

    ~LeaderboardReader() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    private void Dispose(bool disposing)
    {
    }

    private void DisposeGamers()
    {
      if (this.allEntries == null)
        return;
      foreach (LeaderboardEntry allEntry in this.allEntries)
        allEntry.Gamer.Dispose();
    }

    public bool IsDisposed => this.kernelHandle == 0U;

    public void PageUp() => this.EndPageUp(this.BeginPageUp((AsyncCallback) null, (object) null));

    public void PageDown() => this.EndPageDown(this.BeginPageDown((AsyncCallback) null, (object) null));

    public IAsyncResult BeginPageUp(AsyncCallback callback, object asyncState) => this.BeginPage(true, callback, asyncState);

    public IAsyncResult BeginPageDown(AsyncCallback callback, object asyncState) => this.BeginPage(false, callback, asyncState);

    public void EndPageUp(IAsyncResult result) => this.EndPage(true, result);

    public void EndPageDown(IAsyncResult result) => this.EndPage(false, result);

    private IAsyncResult BeginPage(
      bool isPageUp,
      AsyncCallback callback,
      object asyncState)
    {
      int newPageStart = this.GetNewPageStart(isPageUp);
      if (newPageStart == this.pageStart)
        throw new InvalidOperationException(FrameworkResources.LeaderboardReaderCannotPage);
      Logger.BeginLogEvent(LoggingEvent.LeaderboardRead, "XNA: Begin Leaderboard Page up/down");
      this.currentPageUp = isPageUp;
      LeaderboardReader.AsyncResult asyncResult = new LeaderboardReader.AsyncResult();
      asyncResult.ActualAr = GamerServicesDispatcher.Gsp.BeginReadLeaderboard(this.leaderboardId, (IEnumerable<int>) null, 0, newPageStart, this.pageSize, new AsyncCallback(asyncResult.Completed), asyncState);
      asyncResult.Id = this.leaderboardId;
      asyncResult.Callback = callback;
      this.currentPageOperation = (IAsyncResult) asyncResult;
      return this.currentPageOperation;
    }

    private void EndPage(bool isPageUp, IAsyncResult result)
    {
      if (result != this.currentPageOperation || this.currentPageUp != isPageUp)
        throw new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
      this.EndReadInternal(result);
      this.currentPageOperation = (IAsyncResult) null;
      Logger.EndLogEvent(LoggingEvent.LeaderboardRead, "XNA: End Leaderboard Page up/down");
    }

    public bool CanPageUp => this.GetNewPageStart(true) != this.pageStart;

    public bool CanPageDown => this.GetNewPageStart(false) != this.pageStart;

    private int GetNewPageStart(bool isPageUp)
    {
      if (this.currentPageOperation != null)
        return this.pageStart;
      if (isPageUp)
        return Math.Max(this.pageStart - this.pageSize, 0);
      int val1 = this.pageStart + this.pageSize;
      int num = this.totalLeaderboardSize - this.pageSize;
      int pageStart = this.pageStart;
      int val2 = num;
      return Math.Max(Math.Min(val1, val2), pageStart);
    }

    internal void EndReadInternal(IAsyncResult result)
    {
      LeaderboardReader.AsyncResult asyncResult = result as LeaderboardReader.AsyncResult;
      LeaderboardEntryCollectionFiller collectionFiller = new LeaderboardEntryCollectionFiller(asyncResult.Id, true);
      GSLeaderboard gsLeaderboard = GamerServicesDispatcher.Gsp.EndReadLeaderboard(asyncResult.ActualAr, (IPropertyCollectionFiller) collectionFiller);
      this.entries = new ReadOnlyCollection<LeaderboardEntry>((IList<LeaderboardEntry>) collectionFiller.entries);
      this.totalLeaderboardSize = gsLeaderboard.TotalEntries;
      this.pageStart = gsLeaderboard.PageStart;
      this.pageSize = gsLeaderboard.PageSize;
      this.leaderboardId = gsLeaderboard.Id;
    }

    private class AsyncResult : IAsyncResult
    {
      internal AsyncCallback Callback;
      internal IAsyncResult ActualAr;
      internal LeaderboardIdentity Id;

      public object AsyncState => this.ActualAr.AsyncState;

      public WaitHandle AsyncWaitHandle => this.ActualAr.AsyncWaitHandle;

      public bool CompletedSynchronously => this.ActualAr.IsCompleted;

      public bool IsCompleted => this.ActualAr.IsCompleted;

      public void Completed(IAsyncResult result)
      {
        if (this.Callback == null)
          return;
        this.Callback((IAsyncResult) this);
      }
    }

    private class LeaderboardGamer : Gamer
    {
      private LeaderboardReader parent;

      internal LeaderboardGamer(LeaderboardReader parent, int internalIndex, string gamertag)
        : base(0U)
      {
        this.parent = parent;
      }
    }
  }
}
