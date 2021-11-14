// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.GpioChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [Activatable(typeof (IGpioChangeReaderFactory), 196608, "Windows.Devices.DevicesLowLevelContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  public sealed class GpioChangeReader : IGpioChangeReader, IClosable
  {
    [MethodImpl]
    public extern GpioChangeReader(GpioPin pin);

    [MethodImpl]
    public extern GpioChangeReader(GpioPin pin, int minCapacity);

    public extern int Capacity { [MethodImpl] get; }

    public extern int Length { [MethodImpl] get; }

    public extern bool IsEmpty { [MethodImpl] get; }

    public extern bool IsOverflowed { [MethodImpl] get; }

    public extern GpioChangePolarity Polarity { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsStarted { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern GpioChangeRecord GetNextItem();

    [MethodImpl]
    public extern GpioChangeRecord PeekNextItem();

    [MethodImpl]
    public extern IVector<GpioChangeRecord> GetAllItems();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction WaitForItemsAsync(int count);

    [MethodImpl]
    public extern void Close();
  }
}
