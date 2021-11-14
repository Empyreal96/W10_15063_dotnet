// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.SocialInfo.SocialFeedUpdateMode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.SocialInfo
{
  [Deprecated("SocialFeedUpdateMode is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.ApplicationModel.SocialInfo.SocialInfoContract")]
  [ContractVersion(typeof (SocialInfoContract), 65536)]
  public enum SocialFeedUpdateMode
  {
    Append,
    Replace,
  }
}
