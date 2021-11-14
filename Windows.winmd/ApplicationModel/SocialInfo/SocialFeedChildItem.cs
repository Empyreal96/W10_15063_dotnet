// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.SocialFeedChildItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Threading(ThreadingModel.Both)]
  [Deprecated("SocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  public sealed class SocialFeedChildItem : ISocialFeedChildItem
  {
    [MethodImpl]
    public extern SocialFeedChildItem();

    public extern SocialUserInfo Author { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern SocialFeedContent PrimaryContent { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern SocialFeedContent SecondaryContent { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern DateTime Timestamp { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }

    public extern Uri TargetUri { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }

    public extern IVector<SocialItemThumbnail> Thumbnails { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; }

    public extern SocialFeedSharedItem SharedItem { [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] get; [Deprecated("ISocialFeedChildItem is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract"), MethodImpl] set; }
  }
}
