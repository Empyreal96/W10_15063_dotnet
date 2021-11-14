// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.GameServices.Core.IGameService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.System.UserProfile.GameServices.Core
{
  [ExclusiveTo(typeof (GameService))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(774721688, 18601, 20220, 175, 214, 142, 109, 160, 144, 3, 251)]
  internal interface IGameService
  {
    Uri ServiceUri { get; }

    IAsyncOperation<GameServicePropertyCollection> GetGamerProfileAsync();

    IAsyncOperation<GameServicePropertyCollection> GetInstalledGameItemsAsync();

    IAsyncOperation<string> GetPartnerTokenAsync(Uri audienceUri);

    IAsyncOperation<string> GetPrivilegesAsync();

    void GrantAchievement(uint achievementId);

    void GrantAvatarAward(uint avatarAwardId);

    void PostResult(
      uint gameVariant,
      GameServiceScoreKind scoreKind,
      long scoreValue,
      GameServiceGameOutcome gameOutcome,
      IBuffer buffer);
  }
}
