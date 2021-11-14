// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.UINavigationController
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
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IUINavigationControllerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUINavigationControllerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  public sealed class UINavigationController : 
    IUINavigationController,
    IGameController,
    IGameControllerBatteryInfo
  {
    [MethodImpl]
    public extern UINavigationReading GetCurrentReading();

    [MethodImpl]
    public extern GameControllerButtonLabel GetOptionalButtonLabel(
      OptionalUINavigationButtons button);

    [MethodImpl]
    public extern GameControllerButtonLabel GetRequiredButtonLabel(
      RequiredUINavigationButtons button);

    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    public extern Headset Headset { [MethodImpl] get; }

    public extern bool IsWireless { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    [MethodImpl]
    public static extern UINavigationController FromGameController(
      IGameController gameController);

    public static extern event EventHandler<UINavigationController> UINavigationControllerAdded;

    public static extern event EventHandler<UINavigationController> UINavigationControllerRemoved;

    public static extern IVectorView<UINavigationController> UINavigationControllers { [MethodImpl] get; }
  }
}
