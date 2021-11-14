// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.Provider.IGpioPinProviderValueChangedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio.Provider
{
  [ExclusiveTo(typeof (GpioPinProviderValueChangedEventArgs))]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(1053494105, 22156, 17298, 178, 74, 138, 89, 169, 2, 177, 241)]
  internal interface IGpioPinProviderValueChangedEventArgsFactory
  {
    GpioPinProviderValueChangedEventArgs Create(
      ProviderGpioPinEdge edge);
  }
}
