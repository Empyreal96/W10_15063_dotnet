// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.GpioChangeCount
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  public struct GpioChangeCount
  {
    public ulong Count;
    public TimeSpan RelativeTime;
  }
}
