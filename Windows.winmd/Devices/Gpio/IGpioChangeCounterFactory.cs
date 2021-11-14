// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioChangeCounterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [Guid(343774390, 2718, 16652, 180, 250, 248, 159, 64, 82, 8, 77)]
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  [ExclusiveTo(typeof (GpioChangeCounter))]
  internal interface IGpioChangeCounterFactory
  {
    GpioChangeCounter Create(GpioPin pin);
  }
}
