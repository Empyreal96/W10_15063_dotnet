// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.Provider.IGpioPinProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio.Provider
{
  [Guid(1110723767, 27324, 16639, 156, 231, 115, 184, 83, 1, 185, 0)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  public interface IGpioPinProvider
  {
    event TypedEventHandler<IGpioPinProvider, GpioPinProviderValueChangedEventArgs> ValueChanged;

    TimeSpan DebounceTimeout { get; set; }

    int PinNumber { get; }

    ProviderGpioSharingMode SharingMode { get; }

    bool IsDriveModeSupported(ProviderGpioPinDriveMode driveMode);

    ProviderGpioPinDriveMode GetDriveMode();

    void SetDriveMode(ProviderGpioPinDriveMode value);

    void Write(ProviderGpioPinValue value);

    ProviderGpioPinValue Read();
  }
}
