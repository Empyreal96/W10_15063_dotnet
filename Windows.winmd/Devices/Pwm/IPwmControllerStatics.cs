// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.IPwmControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Pwm.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [ExclusiveTo(typeof (PwmController))]
  [Guid(1113832865, 35142, 17412, 189, 72, 129, 221, 18, 74, 244, 217)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface IPwmControllerStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<PwmController>> GetControllersAsync(
      IPwmProvider provider);
  }
}
