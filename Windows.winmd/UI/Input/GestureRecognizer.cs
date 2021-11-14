// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.GestureRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GestureRecognizer : IGestureRecognizer
  {
    [MethodImpl]
    public extern GestureRecognizer();

    public extern GestureSettings GestureSettings { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsInertial { [MethodImpl] get; }

    public extern bool IsActive { [MethodImpl] get; }

    public extern bool ShowGestureFeedback { [MethodImpl] get; [MethodImpl] set; }

    public extern Point PivotCenter { [MethodImpl] get; [MethodImpl] set; }

    public extern float PivotRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern float InertiaTranslationDeceleration { [MethodImpl] get; [MethodImpl] set; }

    public extern float InertiaRotationDeceleration { [MethodImpl] get; [MethodImpl] set; }

    public extern float InertiaExpansionDeceleration { [MethodImpl] get; [MethodImpl] set; }

    public extern float InertiaTranslationDisplacement { [MethodImpl] get; [MethodImpl] set; }

    public extern float InertiaRotationAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern float InertiaExpansion { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ManipulationExact { [MethodImpl] get; [MethodImpl] set; }

    public extern CrossSlideThresholds CrossSlideThresholds { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CrossSlideHorizontally { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CrossSlideExact { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutoProcessInertia { [MethodImpl] get; [MethodImpl] set; }

    public extern MouseWheelParameters MouseWheelParameters { [MethodImpl] get; }

    [MethodImpl]
    public extern bool CanBeDoubleTap(PointerPoint value);

    [MethodImpl]
    public extern void ProcessDownEvent(PointerPoint value);

    [MethodImpl]
    public extern void ProcessMoveEvents(IVector<PointerPoint> value);

    [MethodImpl]
    public extern void ProcessUpEvent(PointerPoint value);

    [MethodImpl]
    public extern void ProcessMouseWheelEvent(
      PointerPoint value,
      bool isShiftKeyDown,
      bool isControlKeyDown);

    [MethodImpl]
    public extern void ProcessInertia();

    [MethodImpl]
    public extern void CompleteGesture();

    public extern event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped;

    public extern event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped;

    public extern event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding;

    public extern event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging;

    public extern event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted;

    public extern event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated;

    public extern event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;

    public extern event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted;

    public extern event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding;
  }
}
