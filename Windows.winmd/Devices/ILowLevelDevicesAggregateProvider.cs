// Decompiled with JetBrains decompiler
// Type: Windows.Devices.ILowLevelDevicesAggregateProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Adc.Provider;
using Windows.Devices.Gpio.Provider;
using Windows.Devices.I2c.Provider;
using Windows.Devices.Pwm.Provider;
using Windows.Devices.Spi.Provider;
using Windows.Foundation.Metadata;

namespace Windows.Devices
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(2805880348, 43713, 20167, 168, 82, 71, 159, 112, 96, 208, 31)]
  public interface ILowLevelDevicesAggregateProvider
  {
    IAdcControllerProvider AdcControllerProvider { get; }

    IPwmControllerProvider PwmControllerProvider { get; }

    IGpioControllerProvider GpioControllerProvider { get; }

    II2cControllerProvider I2cControllerProvider { get; }

    ISpiControllerProvider SpiControllerProvider { get; }
  }
}
