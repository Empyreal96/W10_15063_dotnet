// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioPin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(299479175, 44974, 18320, 158, 233, 224, 234, 201, 66, 210, 1)]
  [ExclusiveTo(typeof (GpioPin))]
  internal interface IGpioPin : IClosable
  {
    event TypedEventHandler<GpioPin, GpioPinValueChangedEventArgs> ValueChanged;

    TimeSpan DebounceTimeout { get; set; }

    int PinNumber { get; }

    GpioSharingMode SharingMode { get; }

    bool IsDriveModeSupported(GpioPinDriveMode driveMode);

    GpioPinDriveMode GetDriveMode();

    void SetDriveMode(GpioPinDriveMode value);

    void Write(GpioPinValue value);

    GpioPinValue Read();
  }
}
