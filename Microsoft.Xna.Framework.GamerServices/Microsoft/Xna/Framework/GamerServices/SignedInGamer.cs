// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.SignedInGamer
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Globalization;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class SignedInGamer : Gamer
  {
    private PlayerIndex playerIndex;
    private bool isSignedInToLive;
    private bool isGuest;
    private GameDefaults gameDefaults;
    private GamerPrivileges privileges;
    private int partySize;
    private static SignedInGamer[] cachedGamers = new SignedInGamer[4];
    private static SignedInGamerFiller filler = new SignedInGamerFiller();
    private GamerPresence presence;

    public PlayerIndex PlayerIndex
    {
      get => this.playerIndex;
      internal set => this.playerIndex = value;
    }

    public bool IsSignedInToLive
    {
      get => this.isSignedInToLive;
      internal set => this.isSignedInToLive = value;
    }

    public bool IsGuest
    {
      get => this.isGuest;
      internal set => this.isGuest = true;
    }

    public GameDefaults GameDefaults => this.gameDefaults;

    public GamerPrivileges Privileges => this.privileges;

    public int PartySize
    {
      get => this.partySize;
      internal set => this.partySize = value;
    }

    internal SignedInGamer(uint kernelHandle)
      : base(kernelHandle)
    {
      this.gameDefaults = new GameDefaults();
      this.privileges = new GamerPrivileges(GamerPrivilegeOptions.AllowNone);
    }

    public static event EventHandler<SignedInEventArgs> SignedIn
    {
      add
      {
        SignedInGamer.signedIn += value;
        foreach (SignedInGamer signedInGamer in (GamerCollection<SignedInGamer>) Gamer.SignedInGamers)
        {
          if (value != null)
            value((object) null, new SignedInEventArgs(signedInGamer));
        }
      }
      remove => SignedInGamer.signedIn -= value;
    }

    private static event EventHandler<SignedInEventArgs> signedIn;

    public static event EventHandler<SignedOutEventArgs> SignedOut;

    internal static void HandlePlayerSignInChanged(
      object sender,
      GSSignedInStatusChangedEventArgs e)
    {
      SignedInGamer gamer = (SignedInGamer) null;
      if (SignedInGamer.cachedGamers[e.PlayerIndex] != null)
      {
        gamer = Gamer.SignedInGamers.FindGamerWithInternalIndexAndRemove(e.PlayerIndex);
        gamer.Dispose();
      }
      SignedInGamer signedInGamer = (SignedInGamer) null;
      if (e.SignInState != PlayerSignInState.NotSignedIn)
      {
        signedInGamer = new SignedInGamer((uint) e.Gamer);
        SignedInGamer.filler.Target = (Gamer) signedInGamer;
        GamerServicesDispatcher.Gsp.FillGamer(e.Gamer, (IPropertyFiller) SignedInGamer.filler);
        Gamer.SignedInGamers.Insert(signedInGamer);
      }
      try
      {
        if (gamer != null)
        {
          EventHandler<SignedOutEventArgs> signedOut = SignedInGamer.SignedOut;
          if (signedOut != null)
            signedOut((object) null, new SignedOutEventArgs(gamer));
        }
        if (signedInGamer == null)
          return;
        EventHandler<SignedInEventArgs> signedIn = SignedInGamer.signedIn;
        if (signedIn == null)
          return;
        signedIn((object) null, new SignedInEventArgs(signedInGamer));
      }
      finally
      {
        SignedInGamer.cachedGamers[e.PlayerIndex] = signedInGamer;
      }
    }

    public bool IsFriend(Gamer gamer)
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (!this.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (gamer == null)
        throw new ArgumentNullException(nameof (gamer));
      if (gamer.IsDisposed)
        throw new ObjectDisposedException(nameof (gamer), FrameworkResources.ObjectDisposedException);
      return GamerServicesDispatcher.Gsp.IsFriend((int) this.KernelHandle, (int) gamer.KernelHandle);
    }

    public FriendCollection GetFriends() => new FriendCollection(0U);

    public bool IsHeadset(Microphone microphone)
    {
      if (microphone == null)
        throw new ArgumentNullException(nameof (microphone));
      return true;
    }

    public IAsyncResult BeginAwardAchievement(
      string achievementKey,
      AsyncCallback callback,
      object state)
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (string.IsNullOrEmpty(achievementKey))
        throw new ArgumentNullException(nameof (achievementKey));
      if (Guide.IsTrialMode)
        throw new GamerPrivilegeException(FrameworkResources.TrialMode);
      XlastConfiguration instance = XlastConfiguration.Instance;
      if (instance != null)
      {
        int num;
        if (!instance.Achievements.TryGetValue(achievementKey, out num))
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.XlastUnknown, (object) FrameworkResources.XlastAchievement, (object) achievementKey), nameof (achievementKey));
        achievementKey = num.ToString();
      }
      Logger.BeginLogEvent(LoggingEvent.AwardAchievement, "XNA: Begin AwardAchievement");
      return GamerServicesDispatcher.Gsp.BeginAwardAchievement((int) this.KernelHandle, achievementKey, callback, state);
    }

    public void EndAwardAchievement(IAsyncResult result)
    {
      GamerServicesDispatcher.Gsp.EndAward(result);
      Logger.EndLogEvent(LoggingEvent.AwardAchievement, "XNA: End AwardAchievement");
    }

    public void AwardAchievement(string achievementKey)
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (string.IsNullOrEmpty(achievementKey))
        throw new ArgumentNullException(nameof (achievementKey));
      if (Guide.IsTrialMode)
        throw new GamerPrivilegeException(FrameworkResources.TrialMode);
      this.EndAwardAchievement(this.BeginAwardAchievement(achievementKey, (AsyncCallback) null, (object) null));
    }

    public IAsyncResult BeginGetAchievements(AsyncCallback callback, object asyncState)
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      Logger.BeginLogEvent(LoggingEvent.GetAchievements, "XNA: Begin GetAchievements");
      return GamerServicesDispatcher.Gsp.BeginGetAchievements((int) this.KernelHandle, callback, asyncState);
    }

    public AchievementCollection EndGetAchievements(IAsyncResult result)
    {
      AchievementsCollectionFiller collectionFiller = new AchievementsCollectionFiller();
      collectionFiller.filler = new AchievementFiller();
      GamerServicesDispatcher.Gsp.EndGetAchievements(result, (IPropertyCollectionFiller) collectionFiller);
      Logger.EndLogEvent(LoggingEvent.GetAchievements, "XNA: End GetAchievements");
      return new AchievementCollection(collectionFiller.achivements);
    }

    public AchievementCollection GetAchievements() => this.EndGetAchievements(this.BeginGetAchievements((AsyncCallback) null, (object) null));

    public GamerPresence Presence
    {
      get
      {
        if (this.presence == null)
          this.presence = new GamerPresence();
        return this.presence;
      }
    }
  }
}
