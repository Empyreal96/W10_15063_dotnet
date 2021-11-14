// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.GameServices.Core.GameService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.System.UserProfile.GameServices.Core
{
  [Static(typeof (IGameService), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGameService2), 65536, "Windows.Phone.PhoneContract")]
  public static class GameService
  {
    [MethodImpl]
    public static extern void NotifyPartnerTokenExpired(Uri audienceUri);

    [MethodImpl]
    public static extern uint GetAuthenticationStatus();

    public static extern Uri ServiceUri { [MethodImpl] get; }

    [MethodImpl]
    public static extern IAsyncOperation<GameServicePropertyCollection> GetGamerProfileAsync();

    [MethodImpl]
    public static extern IAsyncOperation<GameServicePropertyCollection> GetInstalledGameItemsAsync();

    [MethodImpl]
    public static extern IAsyncOperation<string> GetPartnerTokenAsync(Uri audienceUri);

    [MethodImpl]
    public static extern IAsyncOperation<string> GetPrivilegesAsync();

    [MethodImpl]
    public static extern void GrantAchievement(uint achievementId);

    [MethodImpl]
    public static extern void GrantAvatarAward(uint avatarAwardId);

    [MethodImpl]
    public static extern void PostResult(
      uint gameVariant,
      GameServiceScoreKind scoreKind,
      long scoreValue,
      GameServiceGameOutcome gameOutcome,
      IBuffer buffer);
  }
}
