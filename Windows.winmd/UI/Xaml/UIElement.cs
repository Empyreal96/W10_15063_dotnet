// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.UIElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml
{
  [Composable(typeof (IUIElementFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IUIElementStatics6), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUIElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class UIElement : 
    DependencyObject,
    IUIElement,
    IUIElementOverrides,
    IUIElement2,
    IUIElement3,
    IUIElement4,
    IUIElement5
  {
    public extern Size DesiredSize { [MethodImpl] get; }

    public extern bool AllowDrop { [MethodImpl] get; [MethodImpl] set; }

    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    public extern RectangleGeometry Clip { [MethodImpl] get; [MethodImpl] set; }

    public extern Transform RenderTransform { [MethodImpl] get; [MethodImpl] set; }

    public extern Projection Projection { [MethodImpl] get; [MethodImpl] set; }

    public extern Point RenderTransformOrigin { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHitTestVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern Visibility Visibility { [MethodImpl] get; [MethodImpl] set; }

    public extern Size RenderSize { [MethodImpl] get; }

    public extern bool UseLayoutRounding { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection Transitions { [MethodImpl] get; [MethodImpl] set; }

    public extern CacheMode CacheMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTapEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDoubleTapEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsRightTapEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHoldingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ManipulationModes ManipulationMode { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<Pointer> PointerCaptures { [MethodImpl] get; }

    public extern event KeyEventHandler KeyUp;

    public extern event KeyEventHandler KeyDown;

    public extern event RoutedEventHandler GotFocus;

    public extern event RoutedEventHandler LostFocus;

    public extern event DragEventHandler DragEnter;

    public extern event DragEventHandler DragLeave;

    public extern event DragEventHandler DragOver;

    public extern event DragEventHandler Drop;

    public extern event PointerEventHandler PointerPressed;

    public extern event PointerEventHandler PointerMoved;

    public extern event PointerEventHandler PointerReleased;

    public extern event PointerEventHandler PointerEntered;

    public extern event PointerEventHandler PointerExited;

    public extern event PointerEventHandler PointerCaptureLost;

    public extern event PointerEventHandler PointerCanceled;

    public extern event PointerEventHandler PointerWheelChanged;

    public extern event TappedEventHandler Tapped;

    public extern event DoubleTappedEventHandler DoubleTapped;

    public extern event HoldingEventHandler Holding;

    public extern event RightTappedEventHandler RightTapped;

    public extern event ManipulationStartingEventHandler ManipulationStarting;

    public extern event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting;

    public extern event ManipulationStartedEventHandler ManipulationStarted;

    public extern event ManipulationDeltaEventHandler ManipulationDelta;

    public extern event ManipulationCompletedEventHandler ManipulationCompleted;

    [MethodImpl]
    public extern void Measure(Size availableSize);

    [MethodImpl]
    public extern void Arrange(Rect finalRect);

    [MethodImpl]
    public extern bool CapturePointer(Pointer value);

    [MethodImpl]
    public extern void ReleasePointerCapture(Pointer value);

    [MethodImpl]
    public extern void ReleasePointerCaptures();

    [MethodImpl]
    public extern void AddHandler(RoutedEvent routedEvent, object handler, bool handledEventsToo);

    [MethodImpl]
    public extern void RemoveHandler(RoutedEvent routedEvent, object handler);

    [MethodImpl]
    public extern GeneralTransform TransformToVisual(UIElement visual);

    [MethodImpl]
    public extern void InvalidateMeasure();

    [MethodImpl]
    public extern void InvalidateArrange();

    [MethodImpl]
    public extern void UpdateLayout();

    [MethodImpl]
    extern AutomationPeer IUIElementOverrides.OnCreateAutomationPeer();

    [MethodImpl]
    extern void IUIElementOverrides.OnDisconnectVisualChildren();

    [MethodImpl]
    extern IIterable<IIterable<Point>> IUIElementOverrides.FindSubElementsForTouchTargeting(
      Point point,
      Rect boundingRect);

    public extern ElementCompositeMode CompositeMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern bool CancelDirectManipulations();

    public extern Transform3D Transform3D { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanDrag { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<UIElement, DragStartingEventArgs> DragStarting;

    public extern event TypedEventHandler<UIElement, DropCompletedEventArgs> DropCompleted;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DataPackageOperation> StartDragAsync(
      PointerPoint pointerPoint);

    public extern FlyoutBase ContextFlyout { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ExitDisplayModeOnAccessKeyInvoked { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAccessKeyScope { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject AccessKeyScopeOwner { [MethodImpl] get; [MethodImpl] set; }

    public extern string AccessKey { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<UIElement, ContextRequestedEventArgs> ContextRequested;

    public extern event TypedEventHandler<UIElement, RoutedEventArgs> ContextCanceled;

    public extern event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    public extern event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    public extern event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;

    public extern IVector<XamlLight> Lights { [MethodImpl] get; }

    public extern KeyTipPlacementMode KeyTipPlacementMode { [MethodImpl] get; [MethodImpl] set; }

    public extern double KeyTipHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double KeyTipVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusUpNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusDownNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern XYFocusNavigationStrategy XYFocusRightNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern ElementHighContrastAdjustment HighContrastAdjustment { [MethodImpl] get; [MethodImpl] set; }

    public extern KeyboardNavigationMode TabFocusNavigation { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<UIElement, GettingFocusEventArgs> GettingFocus;

    public extern event TypedEventHandler<UIElement, LosingFocusEventArgs> LosingFocus;

    public extern event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> NoFocusCandidateFound;

    [Overload("StartBringIntoView")]
    [MethodImpl]
    public extern void StartBringIntoView();

    [Overload("StartBringIntoViewWithOptions")]
    [MethodImpl]
    public extern void StartBringIntoView(BringIntoViewOptions options);

    public static extern RoutedEvent GettingFocusEvent { [MethodImpl] get; }

    public static extern RoutedEvent LosingFocusEvent { [MethodImpl] get; }

    public static extern RoutedEvent NoFocusCandidateFoundEvent { [MethodImpl] get; }

    public static extern DependencyProperty LightsProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTipPlacementModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTipHorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty KeyTipVerticalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusKeyboardNavigationProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusUpNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusDownNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusLeftNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusRightNavigationStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty HighContrastAdjustmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TabFocusNavigationProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContextFlyoutProperty { [MethodImpl] get; }

    public static extern DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsAccessKeyScopeProperty { [MethodImpl] get; }

    public static extern DependencyProperty AccessKeyScopeOwnerProperty { [MethodImpl] get; }

    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    public static extern DependencyProperty Transform3DProperty { [IndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CanDragProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool TryStartDirectManipulation(Pointer value);

    public static extern DependencyProperty CompositeModeProperty { [MethodImpl] get; }

    public static extern RoutedEvent KeyDownEvent { [MethodImpl] get; }

    public static extern RoutedEvent KeyUpEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerEnteredEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerPressedEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerMovedEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerReleasedEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerExitedEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerCaptureLostEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerCanceledEvent { [MethodImpl] get; }

    public static extern RoutedEvent PointerWheelChangedEvent { [MethodImpl] get; }

    public static extern RoutedEvent TappedEvent { [MethodImpl] get; }

    public static extern RoutedEvent DoubleTappedEvent { [MethodImpl] get; }

    public static extern RoutedEvent HoldingEvent { [MethodImpl] get; }

    public static extern RoutedEvent RightTappedEvent { [MethodImpl] get; }

    public static extern RoutedEvent ManipulationStartingEvent { [MethodImpl] get; }

    public static extern RoutedEvent ManipulationInertiaStartingEvent { [MethodImpl] get; }

    public static extern RoutedEvent ManipulationStartedEvent { [MethodImpl] get; }

    public static extern RoutedEvent ManipulationDeltaEvent { [MethodImpl] get; }

    public static extern RoutedEvent ManipulationCompletedEvent { [MethodImpl] get; }

    public static extern RoutedEvent DragEnterEvent { [MethodImpl] get; }

    public static extern RoutedEvent DragLeaveEvent { [MethodImpl] get; }

    public static extern RoutedEvent DragOverEvent { [MethodImpl] get; }

    public static extern RoutedEvent DropEvent { [MethodImpl] get; }

    public static extern DependencyProperty AllowDropProperty { [MethodImpl] get; }

    public static extern DependencyProperty OpacityProperty { [IndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ClipProperty { [IndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RenderTransformProperty { [IndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ProjectionProperty { [IndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RenderTransformOriginProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsHitTestVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty VisibilityProperty { [MethodImpl] get; }

    public static extern DependencyProperty UseLayoutRoundingProperty { [MethodImpl] get; }

    public static extern DependencyProperty TransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty CacheModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTapEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsDoubleTapEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsRightTapEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsHoldingEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty ManipulationModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty PointerCapturesProperty { [MethodImpl] get; }
  }
}
