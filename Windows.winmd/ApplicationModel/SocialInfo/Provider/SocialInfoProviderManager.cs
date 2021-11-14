// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.Provider.SocialInfoProviderManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo.Provider
{
  [Deprecated("SocialInfoProviderManager is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISocialInfoProviderManagerStatics), 65536, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  public static class SocialInfoProviderManager
  {
    [RemoteAsync]
    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [MethodImpl]
    public static extern IAsyncOperation<SocialFeedUpdater> CreateSocialFeedUpdaterAsync(
      SocialFeedKind kind,
      SocialFeedUpdateMode mode,
      string ownerRemoteId);

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SocialDashboardItemUpdater> CreateDashboardItemUpdaterAsync(
      string ownerRemoteId);

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [MethodImpl]
    public static extern void UpdateBadgeCountValue(string itemRemoteId, int newCount);

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [MethodImpl]
    public static extern void ReportNewContentAvailable(string contactRemoteId, SocialFeedKind kind);

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ProvisionAsync();

    [Deprecated("ISocialInfoProviderManagerStatics is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeprovisionAsync();
  }
}
