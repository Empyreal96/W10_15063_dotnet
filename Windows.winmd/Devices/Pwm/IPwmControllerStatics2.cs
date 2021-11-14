// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.IPwmControllerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [ExclusiveTo(typeof (PwmController))]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(1157389087, 61721, 19421, 151, 173, 247, 110, 249, 134, 115, 109)]
  internal interface IPwmControllerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<PwmController> GetDefaultAsync();
  }
}
