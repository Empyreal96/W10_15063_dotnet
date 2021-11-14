// Decompiled with JetBrains decompiler
// Type: Windows.Devices.ILowLevelDevicesAggregateProviderFactory
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
  [Guid(2596580086, 13427, 18014, 150, 213, 54, 40, 26, 44, 87, 175)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [ExclusiveTo(typeof (LowLevelDevicesAggregateProvider))]
  internal interface ILowLevelDevicesAggregateProviderFactory
  {
    LowLevelDevicesAggregateProvider Create(
      IAdcControllerProvider adc,
      IPwmControllerProvider pwm,
      IGpioControllerProvider gpio,
      II2cControllerProvider i2c,
      ISpiControllerProvider spi);
  }
}
