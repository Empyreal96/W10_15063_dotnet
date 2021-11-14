// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.Provider.SocialDashboardItemUpdater
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo.Provider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("SocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  public sealed class SocialDashboardItemUpdater : ISocialDashboardItemUpdater
  {
    public extern string OwnerRemoteId { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern SocialFeedContent Content { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern DateTime Timestamp { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }

    public extern SocialItemThumbnail Thumbnail { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CommitAsync();

    public extern Uri TargetUri { [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialDashboardItemUpdater is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }
  }
}
