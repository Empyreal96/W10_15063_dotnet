// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ExclusiveTo(typeof (GpioChangeReader))]
  [Guid(180127839, 57393, 18664, 133, 144, 112, 222, 120, 54, 60, 109)]
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  internal interface IGpioChangeReader : IClosable
  {
    int Capacity { get; }

    int Length { get; }

    bool IsEmpty { get; }

    bool IsOverflowed { get; }

    GpioChangePolarity Polarity { set; get; }

    bool IsStarted { get; }

    void Start();

    void Stop();

    void Clear();

    GpioChangeRecord GetNextItem();

    GpioChangeRecord PeekNextItem();

    IVector<GpioChangeRecord> GetAllItems();

    [RemoteAsync]
    IAsyncAction WaitForItemsAsync(int count);
  }
}
