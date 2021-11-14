// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioPinValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [Guid(825731809, 28733, 16473, 189, 36, 181, 178, 93, 255, 184, 78)]
  [ExclusiveTo(typeof (GpioPinValueChangedEventArgs))]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface IGpioPinValueChangedEventArgs
  {
    GpioPinEdge Edge { get; }
  }
}
