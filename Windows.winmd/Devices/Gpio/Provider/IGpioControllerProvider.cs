// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.Provider.IGpioControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(2903625415, 6634, 19233, 135, 79, 185, 26, 237, 74, 37, 219)]
  public interface IGpioControllerProvider
  {
    int PinCount { get; }

    IGpioPinProvider OpenPinProvider(int pin, ProviderGpioSharingMode sharingMode);
  }
}
