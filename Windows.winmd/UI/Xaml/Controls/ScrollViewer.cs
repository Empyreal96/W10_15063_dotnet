// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollViewer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IScrollViewerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IScrollViewerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ScrollViewer : ContentControl, IScrollViewer, IScrollViewer2, IScrollViewer3
  {
    [MethodImpl]
    public extern ScrollViewer();

    public extern ScrollBarVisibility HorizontalScrollBarVisibility { [MethodImpl] get; [MethodImpl] set; }

    public extern ScrollBarVisibility VerticalScrollBarVisibility { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHorizontalRailEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsVerticalRailEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHorizontalScrollChainingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsVerticalScrollChainingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomChainingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsScrollInertiaEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomInertiaEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ScrollMode HorizontalScrollMode { [MethodImpl] get; [MethodImpl] set; }

    public extern ScrollMode VerticalScrollMode { [MethodImpl] get; [MethodImpl] set; }

    public extern ZoomMode ZoomMode { [MethodImpl] get; [MethodImpl] set; }

    public extern SnapPointsAlignment HorizontalSnapPointsAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern SnapPointsAlignment VerticalSnapPointsAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern SnapPointsType HorizontalSnapPointsType { [MethodImpl] get; [MethodImpl] set; }

    public extern SnapPointsType VerticalSnapPointsType { [MethodImpl] get; [MethodImpl] set; }

    public extern SnapPointsType ZoomSnapPointsType { [MethodImpl] get; [MethodImpl] set; }

    public extern double HorizontalOffset { [MethodImpl] get; }

    public extern double ViewportWidth { [MethodImpl] get; }

    public extern double ScrollableWidth { [MethodImpl] get; }

    public extern Visibility ComputedHorizontalScrollBarVisibility { [MethodImpl] get; }

    public extern double ExtentWidth { [MethodImpl] get; }

    public extern double VerticalOffset { [MethodImpl] get; }

    public extern double ViewportHeight { [MethodImpl] get; }

    public extern double ScrollableHeight { [MethodImpl] get; }

    public extern Visibility ComputedVerticalScrollBarVisibility { [MethodImpl] get; }

    public extern double ExtentHeight { [MethodImpl] get; }

    public extern float MinZoomFactor { [MethodImpl] get; [MethodImpl] set; }

    public extern float MaxZoomFactor { [MethodImpl] get; [MethodImpl] set; }

    public extern float ZoomFactor { [MethodImpl] get; }

    public extern IVector<float> ZoomSnapPoints { [MethodImpl] get; }

    public extern event EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;

    [Deprecated("ScrollToHorizontalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ScrollToHorizontalOffset(double offset);

    [Deprecated("ScrollToVerticalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ScrollToVerticalOffset(double offset);

    [Deprecated("ZoomToFactor may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ZoomToFactor(float factor);

    [MethodImpl]
    public extern void InvalidateScrollInfo();

    public extern bool IsDeferredScrollingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool BringIntoViewOnFocusChange { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement TopLeftHeader { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement LeftHeader { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement TopHeader { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<ScrollViewerViewChangingEventArgs> ViewChanging;

    [Overload("ChangeView")]
    [MethodImpl]
    public extern bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor);

    [Overload("ChangeViewWithOptionalAnimation")]
    [MethodImpl]
    public extern bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor,
      bool disableAnimation);

    public extern event EventHandler<object> DirectManipulationStarted;

    public extern event EventHandler<object> DirectManipulationCompleted;

    public static extern DependencyProperty TopLeftHeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty LeftHeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty TopHeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalSnapPointsAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalSnapPointsAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalSnapPointsTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalSnapPointsTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomSnapPointsTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ViewportWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ScrollableWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ComputedHorizontalScrollBarVisibilityProperty { [MethodImpl] get; }

    public static extern DependencyProperty ExtentWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ViewportHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty ScrollableHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty ComputedVerticalScrollBarVisibilityProperty { [MethodImpl] get; }

    public static extern DependencyProperty ExtentHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinZoomFactorProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxZoomFactorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomFactorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomSnapPointsProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalScrollBarVisibilityProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern ScrollBarVisibility GetHorizontalScrollBarVisibility(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetHorizontalScrollBarVisibility(
      DependencyObject element,
      ScrollBarVisibility horizontalScrollBarVisibility);

    public static extern DependencyProperty VerticalScrollBarVisibilityProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern ScrollBarVisibility GetVerticalScrollBarVisibility(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetVerticalScrollBarVisibility(
      DependencyObject element,
      ScrollBarVisibility verticalScrollBarVisibility);

    public static extern DependencyProperty IsHorizontalRailEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsHorizontalRailEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsHorizontalRailEnabled(
      DependencyObject element,
      bool isHorizontalRailEnabled);

    public static extern DependencyProperty IsVerticalRailEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsVerticalRailEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsVerticalRailEnabled(
      DependencyObject element,
      bool isVerticalRailEnabled);

    public static extern DependencyProperty IsHorizontalScrollChainingEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsHorizontalScrollChainingEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsHorizontalScrollChainingEnabled(
      DependencyObject element,
      bool isHorizontalScrollChainingEnabled);

    public static extern DependencyProperty IsVerticalScrollChainingEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsVerticalScrollChainingEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsVerticalScrollChainingEnabled(
      DependencyObject element,
      bool isVerticalScrollChainingEnabled);

    public static extern DependencyProperty IsZoomChainingEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsZoomChainingEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsZoomChainingEnabled(
      DependencyObject element,
      bool isZoomChainingEnabled);

    public static extern DependencyProperty IsScrollInertiaEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsScrollInertiaEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsScrollInertiaEnabled(
      DependencyObject element,
      bool isScrollInertiaEnabled);

    public static extern DependencyProperty IsZoomInertiaEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsZoomInertiaEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsZoomInertiaEnabled(
      DependencyObject element,
      bool isZoomInertiaEnabled);

    public static extern DependencyProperty HorizontalScrollModeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern ScrollMode GetHorizontalScrollMode(DependencyObject element);

    [MethodImpl]
    public static extern void SetHorizontalScrollMode(
      DependencyObject element,
      ScrollMode horizontalScrollMode);

    public static extern DependencyProperty VerticalScrollModeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern ScrollMode GetVerticalScrollMode(DependencyObject element);

    [MethodImpl]
    public static extern void SetVerticalScrollMode(
      DependencyObject element,
      ScrollMode verticalScrollMode);

    public static extern DependencyProperty ZoomModeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern ZoomMode GetZoomMode(DependencyObject element);

    [MethodImpl]
    public static extern void SetZoomMode(DependencyObject element, ZoomMode zoomMode);

    public static extern DependencyProperty IsDeferredScrollingEnabledProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsDeferredScrollingEnabled(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsDeferredScrollingEnabled(
      DependencyObject element,
      bool isDeferredScrollingEnabled);

    public static extern DependencyProperty BringIntoViewOnFocusChangeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetBringIntoViewOnFocusChange(DependencyObject element);

    [MethodImpl]
    public static extern void SetBringIntoViewOnFocusChange(
      DependencyObject element,
      bool bringIntoViewOnFocusChange);
  }
}
