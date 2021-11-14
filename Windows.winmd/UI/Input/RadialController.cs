// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRadialControllerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class RadialController : IRadialController, IRadialController2
  {
    public extern RadialControllerMenu Menu { [MethodImpl] get; }

    public extern double RotationResolutionInDegrees { [MethodImpl] get; [MethodImpl] set; }

    public extern bool UseAutomaticHapticFeedback { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<RadialController, RadialControllerScreenContactStartedEventArgs> ScreenContactStarted;

    public extern event TypedEventHandler<RadialController, object> ScreenContactEnded;

    public extern event TypedEventHandler<RadialController, RadialControllerScreenContactContinuedEventArgs> ScreenContactContinued;

    public extern event TypedEventHandler<RadialController, object> ControlLost;

    public extern event TypedEventHandler<RadialController, RadialControllerRotationChangedEventArgs> RotationChanged;

    public extern event TypedEventHandler<RadialController, RadialControllerButtonClickedEventArgs> ButtonClicked;

    public extern event TypedEventHandler<RadialController, RadialControllerControlAcquiredEventArgs> ControlAcquired;

    public extern event TypedEventHandler<RadialController, RadialControllerButtonPressedEventArgs> ButtonPressed;

    public extern event TypedEventHandler<RadialController, RadialControllerButtonHoldingEventArgs> ButtonHolding;

    public extern event TypedEventHandler<RadialController, RadialControllerButtonReleasedEventArgs> ButtonReleased;

    [MethodImpl]
    public static extern bool IsSupported();

    [MethodImpl]
    public static extern RadialController CreateForCurrentView();
  }
}
