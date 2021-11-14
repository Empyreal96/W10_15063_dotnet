// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.GpioController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Gpio.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio
{
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IGpioControllerStatics2), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGpioControllerStatics), 65536, "Windows.Devices.DevicesLowLevelContract")]
  public sealed class GpioController : IGpioController
  {
    public extern int PinCount { [MethodImpl] get; }

    [Overload("OpenPin")]
    [MethodImpl]
    public extern GpioPin OpenPin(int pinNumber);

    [Overload("OpenPinWithSharingMode")]
    [MethodImpl]
    public extern GpioPin OpenPin(int pinNumber, GpioSharingMode sharingMode);

    [MethodImpl]
    public extern bool TryOpenPin(
      int pinNumber,
      GpioSharingMode sharingMode,
      out GpioPin pin,
      out GpioOpenStatus openStatus);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<GpioController>> GetControllersAsync(
      IGpioProvider provider);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GpioController> GetDefaultAsync();

    [MethodImpl]
    public static extern GpioController GetDefault();
  }
}
