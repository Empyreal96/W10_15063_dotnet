// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.ISocialUserInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo
{
  [ExclusiveTo(typeof (SocialUserInfo))]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  [Guid(2656967633, 37072, 19997, 149, 84, 132, 77, 70, 96, 127, 97)]
  [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  internal interface ISocialUserInfo
  {
    string DisplayName { [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    string UserName { [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    string RemoteId { [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }

    Uri TargetUri { [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] get; [Deprecated("ISocialUserInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")] set; }
  }
}
