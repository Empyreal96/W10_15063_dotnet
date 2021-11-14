// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.Provider.IGpioPinProviderValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio.Provider
{
  [ExclusiveTo(typeof (GpioPinProviderValueChangedEventArgs))]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(849794802, 15707, 17613, 143, 190, 19, 166, 159, 46, 219, 36)]
  internal interface IGpioPinProviderValueChangedEventArgs
  {
    ProviderGpioPinEdge Edge { get; }
  }
}
