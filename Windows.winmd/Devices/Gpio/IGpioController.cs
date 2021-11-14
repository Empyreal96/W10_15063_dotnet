// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ExclusiveTo(typeof (GpioController))]
  [Guid(675287779, 29793, 18076, 168, 188, 97, 214, 157, 8, 165, 60)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface IGpioController
  {
    int PinCount { get; }

    [Overload("OpenPin")]
    GpioPin OpenPin(int pinNumber);

    [Overload("OpenPinWithSharingMode")]
    GpioPin OpenPin(int pinNumber, GpioSharingMode sharingMode);

    bool TryOpenPin(
      int pinNumber,
      GpioSharingMode sharingMode,
      out GpioPin pin,
      out GpioOpenStatus openStatus);
  }
}
