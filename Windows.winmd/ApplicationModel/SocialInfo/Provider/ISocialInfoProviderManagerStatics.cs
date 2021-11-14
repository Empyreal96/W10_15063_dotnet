// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.Provider.ISocialInfoProviderManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo.Provider
{
  [Guid(461956395, 30599, 18646, 170, 18, 216, 232, 244, 122, 184, 90)]
  [ExclusiveTo(typeof (SocialInfoProviderManager))]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  internal interface ISocialInfoProviderManagerStatics
  {
    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    IAsyncOperation<SocialFeedUpdater> CreateSocialFeedUpdaterAsync(
      SocialFeedKind kind,
      SocialFeedUpdateMode mode,
      string ownerRemoteId);

    [RemoteAsync]
    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    IAsyncOperation<SocialDashboardItemUpdater> CreateDashboardItemUpdaterAsync(
      string ownerRemoteId);

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    void UpdateBadgeCountValue(string itemRemoteId, int newCount);

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    void ReportNewContentAvailable(string contactRemoteId, SocialFeedKind kind);

    [RemoteAsync]
    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    IAsyncOperation<bool> ProvisionAsync();

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    IAsyncAction DeprovisionAsync();
  }
}
