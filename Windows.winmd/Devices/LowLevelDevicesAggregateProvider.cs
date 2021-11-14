// Decompiled with JetBrains decompiler
// Type: Windows.Devices.LowLevelDevicesAggregateProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Adc.Provider;
using Windows.Devices.Gpio.Provider;
using Windows.Devices.I2c.Provider;
using Windows.Devices.Pwm.Provider;
using Windows.Devices.Spi.Provider;
using Windows.Foundation.Metadata;

namespace Windows.Devices
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Activatable(typeof (ILowLevelDevicesAggregateProviderFactory), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class LowLevelDevicesAggregateProvider : ILowLevelDevicesAggregateProvider
  {
    [MethodImpl]
    public extern LowLevelDevicesAggregateProvider(
      IAdcControllerProvider adc,
      IPwmControllerProvider pwm,
      IGpioControllerProvider gpio,
      II2cControllerProvider i2c,
      ISpiControllerProvider spi);

    public extern IAdcControllerProvider AdcControllerProvider { [MethodImpl] get; }

    public extern IPwmControllerProvider PwmControllerProvider { [MethodImpl] get; }

    public extern IGpioControllerProvider GpioControllerProvider { [MethodImpl] get; }

    public extern II2cControllerProvider I2cControllerProvider { [MethodImpl] get; }

    public extern ISpiControllerProvider SpiControllerProvider { [MethodImpl] get; }
  }
}
