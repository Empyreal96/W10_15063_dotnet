// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioChangeReaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [Guid(2841218803, 14606, 17434, 157, 28, 232, 222, 11, 45, 240, 223)]
  [ExclusiveTo(typeof (GpioChangeReader))]
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  internal interface IGpioChangeReaderFactory
  {
    GpioChangeReader Create(GpioPin pin);

    GpioChangeReader CreateWithCapacity(GpioPin pin, int minCapacity);
  }
}
