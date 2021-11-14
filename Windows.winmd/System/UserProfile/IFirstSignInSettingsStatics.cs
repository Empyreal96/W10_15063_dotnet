// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IFirstSignInSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FirstSignInSettings))]
  [Guid(484544271, 7233, 20128, 183, 162, 111, 12, 28, 126, 132, 56)]
  internal interface IFirstSignInSettingsStatics
  {
    FirstSignInSettings GetDefault();
  }
}
