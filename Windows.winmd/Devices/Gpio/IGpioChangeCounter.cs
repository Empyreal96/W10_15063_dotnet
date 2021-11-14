// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.IGpioChangeCounter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [ContractVersion(typeof (DevicesLowLevelContract), 196608)]
  [ExclusiveTo(typeof (GpioChangeCounter))]
  [Guid(3411984606, 26625, 17407, 128, 61, 69, 118, 98, 138, 139, 38)]
  internal interface IGpioChangeCounter : IClosable
  {
    GpioChangePolarity Polarity { set; get; }

    bool IsStarted { get; }

    void Start();

    void Stop();

    GpioChangeCount Read();

    GpioChangeCount Reset();
  }
}
