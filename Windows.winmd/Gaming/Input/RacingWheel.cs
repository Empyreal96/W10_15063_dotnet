// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RacingWheel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;
using Windows.System;

namespace Windows.Gaming.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRacingWheelStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IRacingWheelStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  public sealed class RacingWheel : IRacingWheel, IGameController, IGameControllerBatteryInfo
  {
    public extern bool HasClutch { [MethodImpl] get; }

    public extern bool HasHandbrake { [MethodImpl] get; }

    public extern bool HasPatternShifter { [MethodImpl] get; }

    public extern int MaxPatternShifterGear { [MethodImpl] get; }

    public extern double MaxWheelAngle { [MethodImpl] get; }

    public extern ForceFeedbackMotor WheelMotor { [MethodImpl] get; }

    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      RacingWheelButtons button);

    [MethodImpl]
    public extern RacingWheelReading GetCurrentReading();

    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    public extern Headset Headset { [MethodImpl] get; }

    public extern bool IsWireless { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    [MethodImpl]
    public static extern RacingWheel FromGameController(IGameController gameController);

    public static extern event EventHandler<RacingWheel> RacingWheelAdded;

    public static extern event EventHandler<RacingWheel> RacingWheelRemoved;

    public static extern IVectorView<RacingWheel> RacingWheels { [MethodImpl] get; }
  }
}
