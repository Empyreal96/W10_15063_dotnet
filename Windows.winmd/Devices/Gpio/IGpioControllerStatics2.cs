// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioControllerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Gpio.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(2435546400, 27812, 16646, 163, 115, 255, 253, 52, 107, 14, 91)]
  [ExclusiveTo(typeof (GpioController))]
  internal interface IGpioControllerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<GpioController>> GetControllersAsync(
      IGpioProvider provider);

    [RemoteAsync]
    IAsyncOperation<GpioController> GetDefaultAsync();
  }
}
