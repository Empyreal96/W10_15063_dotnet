// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.PwmController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Pwm.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IPwmControllerStatics), 65536, "Windows.Devices.DevicesLowLevelContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPwmControllerStatics3), 196608, "Windows.Devices.DevicesLowLevelContract")]
  [Static(typeof (IPwmControllerStatics2), 131072, "Windows.Devices.DevicesLowLevelContract")]
  public sealed class PwmController : IPwmController
  {
    public extern int PinCount { [MethodImpl] get; }

    public extern double ActualFrequency { [MethodImpl] get; }

    [MethodImpl]
    public extern double SetDesiredFrequency(double desiredFrequency);

    public extern double MinFrequency { [MethodImpl] get; }

    public extern double MaxFrequency { [MethodImpl] get; }

    [MethodImpl]
    public extern PwmPin OpenPin(int pinNumber);

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromFriendlyName")]
    [MethodImpl]
    public static extern string GetDeviceSelector(string friendlyName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PwmController> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PwmController> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PwmController>> GetControllersAsync(
      IPwmProvider provider);
  }
}
