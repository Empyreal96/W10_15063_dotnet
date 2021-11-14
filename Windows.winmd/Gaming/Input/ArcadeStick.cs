// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ArcadeStick
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
  [Static(typeof (IArcadeStickStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IArcadeStickStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class ArcadeStick : IArcadeStick, IGameController, IGameControllerBatteryInfo
  {
    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      ArcadeStickButtons button);

    [MethodImpl]
    public extern ArcadeStickReading GetCurrentReading();

    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    public extern Headset Headset { [MethodImpl] get; }

    public extern bool IsWireless { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    [MethodImpl]
    public static extern ArcadeStick FromGameController(IGameController gameController);

    public static extern event EventHandler<ArcadeStick> ArcadeStickAdded;

    public static extern event EventHandler<ArcadeStick> ArcadeStickRemoved;

    public static extern IVectorView<ArcadeStick> ArcadeSticks { [MethodImpl] get; }
  }
}
