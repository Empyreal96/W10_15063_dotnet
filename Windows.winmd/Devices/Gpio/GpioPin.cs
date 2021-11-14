// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.GpioPin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  public sealed class GpioPin : IGpioPin, IClosable
  {
    public extern event TypedEventHandler<GpioPin, GpioPinValueChangedEventArgs> ValueChanged;

    public extern TimeSpan DebounceTimeout { [MethodImpl] get; [MethodImpl] set; }

    public extern int PinNumber { [MethodImpl] get; }

    public extern GpioSharingMode SharingMode { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsDriveModeSupported(GpioPinDriveMode driveMode);

    [MethodImpl]
    public extern GpioPinDriveMode GetDriveMode();

    [MethodImpl]
    public extern void SetDriveMode(GpioPinDriveMode value);

    [MethodImpl]
    public extern void Write(GpioPinValue value);

    [MethodImpl]
    public extern GpioPinValue Read();

    [MethodImpl]
    public extern void Close();
  }
}
