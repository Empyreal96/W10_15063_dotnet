// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RawGameController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;
using Windows.System;

namespace Windows.Gaming.Input
{
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRawGameControllerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class RawGameController : 
    IRawGameController,
    IGameController,
    IGameControllerBatteryInfo
  {
    public extern int AxisCount { [MethodImpl] get; }

    public extern int ButtonCount { [MethodImpl] get; }

    public extern IVectorView<ForceFeedbackMotor> ForceFeedbackMotors { [MethodImpl] get; }

    public extern ushort HardwareProductId { [MethodImpl] get; }

    public extern ushort HardwareVendorId { [MethodImpl] get; }

    public extern int SwitchCount { [MethodImpl] get; }

    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(int buttonIndex);

    [MethodImpl]
    public extern ulong GetCurrentReading(
      [Out] bool[] buttonArray,
      [Out] GameControllerSwitchPosition[] switchArray,
      [Out] double[] axisArray);

    [MethodImpl]
    public extern GameControllerSwitchKind GetSwitchKind(int switchIndex);

    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    public extern Headset Headset { [MethodImpl] get; }

    public extern bool IsWireless { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    public static extern event EventHandler<RawGameController> RawGameControllerAdded;

    public static extern event EventHandler<RawGameController> RawGameControllerRemoved;

    public static extern IVectorView<RawGameController> RawGameControllers { [MethodImpl] get; }

    [MethodImpl]
    public static extern RawGameController FromGameController(
      IGameController gameController);
  }
}
