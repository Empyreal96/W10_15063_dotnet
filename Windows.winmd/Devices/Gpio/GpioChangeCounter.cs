// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.GpioChangeCounter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  [Activatable(typeof (IGpioChangeCounterFactory), 196608, "Windows.Devices.DevicesLowLevelContract")]
  public sealed class GpioChangeCounter : IGpioChangeCounter, IClosable
  {
    [MethodImpl]
    public extern GpioChangeCounter(GpioPin pin);

    public extern GpioChangePolarity Polarity { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsStarted { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern GpioChangeCount Read();

    [MethodImpl]
    public extern GpioChangeCount Reset();

    [MethodImpl]
    public extern void Close();
  }
}
