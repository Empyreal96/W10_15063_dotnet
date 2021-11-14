// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IUserProfilePersonalizationSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserProfilePersonalizationSettings))]
  [Guid(2444015681, 20535, 17739, 152, 131, 187, 119, 45, 8, 221, 22)]
  internal interface IUserProfilePersonalizationSettingsStatics
  {
    UserProfilePersonalizationSettings Current { get; }

    bool IsSupported();
  }
}
