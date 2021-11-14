// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.ISocialManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation
{
  [Deprecated("ISocialManagerStatics2 : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(418720865, 42493, 19016, 188, 88, 28, 81, 226, 157, 244, 60)]
  [ExclusiveTo(typeof (SocialManager))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface ISocialManagerStatics2
  {
    [Deprecated("ISocialManagerStatics2 : IInspectable is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction DeleteAllAppUserDataAsync();
  }
}
