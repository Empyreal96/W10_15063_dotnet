// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.ISocialFeedChildItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo
{
  [Guid(191535194, 54685, 16574, 152, 12, 72, 138, 42, 179, 10, 131)]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [ExclusiveTo(typeof (SocialFeedChildItem))]
  [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  internal interface ISocialFeedChildItem
  {
    SocialUserInfo Author { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    SocialFeedContent PrimaryContent { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    SocialFeedContent SecondaryContent { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    DateTime Timestamp { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    Uri TargetUri { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    IVector<SocialItemThumbnail> Thumbnails { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; }

    SocialFeedSharedItem SharedItem { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }
  }
}
