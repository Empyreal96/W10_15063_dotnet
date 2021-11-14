// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.Provider.ISocialDashboardItemUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo.Provider
{
  [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Guid(1021222345, 18432, 18125, 134, 155, 25, 115, 236, 104, 91, 222)]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [ExclusiveTo(typeof (SocialDashboardItemUpdater))]
  internal interface ISocialDashboardItemUpdater
  {
    string OwnerRemoteId { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    SocialFeedContent Content { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    DateTime Timestamp { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    SocialItemThumbnail Thumbnail { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    [RemoteAsync]
    [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    IAsyncAction CommitAsync();

    Uri TargetUri { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }
  }
}
