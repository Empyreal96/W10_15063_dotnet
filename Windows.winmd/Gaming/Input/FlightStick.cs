// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.FlightStick
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
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IFlightStickStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class FlightStick : IFlightStick, IGameController, IGameControllerBatteryInfo
  {
    public extern GameControllerSwitchKind HatSwitchKind { [MethodImpl] get; }

    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      FlightStickButtons button);

    [MethodImpl]
    public extern FlightStickReading GetCurrentReading();

    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    public extern Headset Headset { [MethodImpl] get; }

    public extern bool IsWireless { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    public static extern event EventHandler<FlightStick> FlightStickAdded;

    public static extern event EventHandler<FlightStick> FlightStickRemoved;

    public static extern IVectorView<FlightStick> FlightSticks { [MethodImpl] get; }

    [MethodImpl]
    public static extern FlightStick FromGameController(IGameController gameController);
  }
}
