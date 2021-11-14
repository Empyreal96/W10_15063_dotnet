// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1735199721, 46684, 16838, 186, 64, 88, 207, 135, 242, 1, 193)]
  internal interface IUIElement
  {
    Size DesiredSize { get; }

    bool AllowDrop { get; set; }

    double Opacity { get; set; }

    RectangleGeometry Clip { get; set; }

    Transform RenderTransform { get; set; }

    Projection Projection { get; set; }

    Point RenderTransformOrigin { get; set; }

    bool IsHitTestVisible { get; set; }

    Visibility Visibility { get; set; }

    Size RenderSize { get; }

    bool UseLayoutRounding { get; set; }

    TransitionCollection Transitions { get; set; }

    CacheMode CacheMode { get; set; }

    bool IsTapEnabled { get; set; }

    bool IsDoubleTapEnabled { get; set; }

    bool IsRightTapEnabled { get; set; }

    bool IsHoldingEnabled { get; set; }

    ManipulationModes ManipulationMode { get; set; }

    IVectorView<Pointer> PointerCaptures { get; }

    event KeyEventHandler KeyUp;

    event KeyEventHandler KeyDown;

    event RoutedEventHandler GotFocus;

    event RoutedEventHandler LostFocus;

    event DragEventHandler DragEnter;

    event DragEventHandler DragLeave;

    event DragEventHandler DragOver;

    event DragEventHandler Drop;

    event PointerEventHandler PointerPressed;

    event PointerEventHandler PointerMoved;

    event PointerEventHandler PointerReleased;

    event PointerEventHandler PointerEntered;

    event PointerEventHandler PointerExited;

    event PointerEventHandler PointerCaptureLost;

    event PointerEventHandler PointerCanceled;

    event PointerEventHandler PointerWheelChanged;

    event TappedEventHandler Tapped;

    event DoubleTappedEventHandler DoubleTapped;

    event HoldingEventHandler Holding;

    event RightTappedEventHandler RightTapped;

    event ManipulationStartingEventHandler ManipulationStarting;

    event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting;

    event ManipulationStartedEventHandler ManipulationStarted;

    event ManipulationDeltaEventHandler ManipulationDelta;

    event ManipulationCompletedEventHandler ManipulationCompleted;

    void Measure(Size availableSize);

    void Arrange(Rect finalRect);

    bool CapturePointer(Pointer value);

    void ReleasePointerCapture(Pointer value);

    void ReleasePointerCaptures();

    void AddHandler(RoutedEvent routedEvent, object handler, bool handledEventsToo);

    void RemoveHandler(RoutedEvent routedEvent, object handler);

    GeneralTransform TransformToVisual(UIElement visual);

    void InvalidateMeasure();

    void InvalidateArrange();

    void UpdateLayout();
  }
}
