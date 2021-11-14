// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.Gamer
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices.Stub;
using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  public abstract class Gamer
  {
    private string gamertag;
    private string displayName;
    private uint kernelHandle;
    private int internalIndex;
    private object tag;
    private bool isDisposed;
    private static SignedInGamerCollection signedInGamers = new SignedInGamerCollection();
    private LeaderboardWriter leaderboardWriter;

    public string Gamertag
    {
      get => this.gamertag;
      internal set => this.gamertag = value;
    }

    public string DisplayName
    {
      get => this.displayName;
      internal set => this.displayName = value;
    }

    internal uint KernelHandle
    {
      get => this.kernelHandle;
      set => this.kernelHandle = value;
    }

    internal int InternalIndex
    {
      get => this.internalIndex;
      set => this.internalIndex = value;
    }

    public object Tag
    {
      get => this.tag;
      set => this.tag = value;
    }

    public bool IsDisposed => this.isDisposed;

    public static SignedInGamerCollection SignedInGamers => Gamer.signedInGamers;

    internal Gamer(uint kernelHandle) => this.kernelHandle = kernelHandle;

    internal void Dispose()
    {
      GamerServicesDispatcher.Gsp.DisposeGamer((int) this.kernelHandle);
      this.isDisposed = true;
      this.internalIndex = -1;
      this.kernelHandle = 0U;
    }

    public override string ToString() => this.gamertag;

    private static bool IsAlphabetic(char c)
    {
      if ('A' <= c && c <= 'Z')
        return true;
      return 'a' <= c && c <= 'z';
    }

    private static bool IsAlphaNumericOrSpace(char c) => Gamer.IsAlphabetic(c) || '0' <= c && c <= '9' || ' ' == c;

    private static bool ValidateGamertagString(string gamertag)
    {
      if (string.IsNullOrEmpty(gamertag) || gamertag.Length >= 16)
        return false;
      char ch = char.MinValue;
      foreach (char c in gamertag)
      {
        if (!Gamer.IsAlphaNumericOrSpace(c) || (int) ch == (int) c && c == ' ')
          return false;
        ch = c;
      }
      if (gamertag[0] != ' ')
      {
        string str = gamertag;
        if (str[str.Length - 1] != ' ' && Gamer.IsAlphabetic(gamertag[0]))
          return true;
      }
      return false;
    }

    public static IAsyncResult BeginGetFromGamertag(
      string gamertag,
      AsyncCallback callback,
      object asyncState)
    {
      if (gamertag == null)
        throw new ArgumentNullException(nameof (gamertag));
      if (!Gamer.ValidateGamertagString(gamertag))
        throw new ArgumentException(nameof (gamertag));
      SignedInGamer signedInGamer = Gamer.SignedInGamers[PlayerIndex.One];
      if (signedInGamer == null || !signedInGamer.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (signedInGamer.Privileges.AllowProfileViewing == GamerPrivilegeSetting.Blocked || signedInGamer.Privileges.AllowUserCreatedContent == GamerPrivilegeSetting.Blocked)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
      Logger.BeginLogEvent(LoggingEvent.GetFromGamertag, "XNA: Begin GetFromGamertag");
      return GamerServicesDispatcher.Gsp.BeginGetGamerFromGamertag(gamertag, callback, asyncState);
    }

    public static Gamer EndGetFromGamertag(IAsyncResult result)
    {
      if (result == null)
        throw new ArgumentNullException(nameof (result));
      SocialGamer socialGamer = new SocialGamer(0U);
      GamerServicesDispatcher.Gsp.EndGetGamerFromGamertag(result, (IPropertyFiller) new GamerFiller()
      {
        Target = (Gamer) socialGamer
      });
      Logger.EndLogEvent(LoggingEvent.GetFromGamertag, "XNA: End GetFromGamertag");
      return (Gamer) socialGamer;
    }

    public static Gamer GetFromGamertag(string gamertag)
    {
      if (string.IsNullOrEmpty(gamertag))
        throw new ArgumentException(nameof (gamertag));
      SignedInGamer signedInGamer = Gamer.SignedInGamers[PlayerIndex.One];
      if (signedInGamer == null || !signedInGamer.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (signedInGamer.Privileges.AllowProfileViewing == GamerPrivilegeSetting.Blocked || signedInGamer.Privileges.AllowUserCreatedContent == GamerPrivilegeSetting.Blocked)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
      return Gamer.EndGetFromGamertag(Gamer.BeginGetFromGamertag(gamertag, (AsyncCallback) null, (object) null));
    }

    public static IAsyncResult BeginGetPartnerToken(
      string audienceUri,
      AsyncCallback callback,
      object asyncState)
    {
      if (audienceUri == null)
        throw new ArgumentNullException(nameof (audienceUri));
      if (string.IsNullOrEmpty(audienceUri))
        throw new ArgumentException(nameof (audienceUri));
      Logger.BeginLogEvent(LoggingEvent.GetPartnerToken, "XNA: Begin GetPartnerToken");
      return GamerServicesDispatcher.Gsp.BeginGetPartnerToken(audienceUri, callback, asyncState);
    }

    public static string EndGetPartnerToken(IAsyncResult result)
    {
      if (result == null)
        throw new ArgumentNullException(nameof (result));
      Logger.EndLogEvent(LoggingEvent.GetPartnerToken, "XNA: End GetPartnerToken");
      return GamerServicesDispatcher.Gsp.EndGetPartnerToken(result);
    }

    public static string GetPartnerToken(string audienceUri)
    {
      if (audienceUri == null)
        throw new ArgumentNullException(nameof (audienceUri));
      return !string.IsNullOrEmpty(audienceUri) ? Gamer.EndGetPartnerToken(Gamer.BeginGetPartnerToken(audienceUri, (AsyncCallback) null, (object) null)) : throw new ArgumentException(nameof (audienceUri));
    }

    public GamerProfile GetProfile()
    {
      SignedInGamer signedInGamer = Gamer.SignedInGamers[PlayerIndex.One];
      if (signedInGamer == null || !signedInGamer.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (this != signedInGamer && (signedInGamer.Privileges.AllowProfileViewing == GamerPrivilegeSetting.Blocked || signedInGamer.Privileges.AllowUserCreatedContent == GamerPrivilegeSetting.Blocked))
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
      return this.EndGetProfile(this.BeginGetProfile((AsyncCallback) null, (object) null));
    }

    public IAsyncResult BeginGetProfile(AsyncCallback callback, object asyncState)
    {
      SignedInGamer signedInGamer = Gamer.SignedInGamers[PlayerIndex.One];
      if (signedInGamer == null || !signedInGamer.IsSignedInToLive)
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotSignedIn);
      if (this != signedInGamer && (signedInGamer.Privileges.AllowProfileViewing == GamerPrivilegeSetting.Blocked || signedInGamer.Privileges.AllowUserCreatedContent == GamerPrivilegeSetting.Blocked))
        throw new GamerPrivilegeException(FrameworkResources.ProfileNotPrivileged);
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      Logger.BeginLogEvent(LoggingEvent.GetProfile, "XNA: Begin GetProfile");
      return GamerServicesDispatcher.Gsp.BeginFillProfile((int) this.kernelHandle, callback, asyncState);
    }

    public GamerProfile EndGetProfile(IAsyncResult result)
    {
      GamerProfile gamerProfile = new GamerProfile();
      GamerServicesDispatcher.Gsp.EndFillProfile(result, (IPropertyFiller) new GamerProfileFiller()
      {
        Target = gamerProfile
      });
      Logger.EndLogEvent(LoggingEvent.GetProfile, "XNA: End GetProfile");
      return gamerProfile;
    }

    public LeaderboardWriter LeaderboardWriter
    {
      get
      {
        if (this.leaderboardWriter == null)
          this.leaderboardWriter = new LeaderboardWriter(this);
        return this.leaderboardWriter;
      }
    }

    internal void WriteLeaderboard()
    {
      if (this.leaderboardWriter == null || !this.leaderboardWriter.IsChanged)
        return;
      this.leaderboardWriter.WriteChanges();
      this.ResetLeaderboardWriter();
    }

    internal void ResetLeaderboardWriter()
    {
      if (this.leaderboardWriter == null)
        return;
      this.leaderboardWriter.Reset();
    }
  }
}
