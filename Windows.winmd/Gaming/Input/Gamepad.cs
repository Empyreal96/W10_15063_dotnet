// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Gamepad
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Gaming.Input
{
  [Static(typeof (IGamepadStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGamepadStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class Gamepad : IGamepad, IGameController, IGamepad2, IGameControllerBatteryInfo
  {
    public extern GamepadVibration Vibration { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern GamepadReading GetCurrentReading();

    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    public extern Headset Headset { [MethodImpl] get; }

    public extern bool IsWireless { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      GamepadButtons button);

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    [MethodImpl]
    public static extern Gamepad FromGameController(IGameController gameController);

    public static extern event EventHandler<Gamepad> GamepadAdded;

    public static extern event EventHandler<Gamepad> GamepadRemoved;

    public static extern IVectorView<Gamepad> Gamepads { [MethodImpl] get; }
  }
}
