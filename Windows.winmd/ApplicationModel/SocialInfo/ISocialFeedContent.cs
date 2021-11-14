// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.ISocialFeedContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo
{
  [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [Guid(2721375273, 15929, 18765, 163, 124, 244, 98, 162, 73, 69, 20)]
  [ExclusiveTo(typeof (SocialFeedContent))]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  internal interface ISocialFeedContent
  {
    string Title { [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    string Message { [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    Uri TargetUri { [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialFeedContent is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }
  }
}
