// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(869345693, 36206, 17040, 191, 34, 144, 92, 204, 208, 77, 49)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScrollViewerStatics
  {
    DependencyProperty HorizontalSnapPointsAlignmentProperty { get; }

    DependencyProperty VerticalSnapPointsAlignmentProperty { get; }

    DependencyProperty HorizontalSnapPointsTypeProperty { get; }

    DependencyProperty VerticalSnapPointsTypeProperty { get; }

    DependencyProperty ZoomSnapPointsTypeProperty { get; }

    DependencyProperty HorizontalOffsetProperty { get; }

    DependencyProperty ViewportWidthProperty { get; }

    DependencyProperty ScrollableWidthProperty { get; }

    DependencyProperty ComputedHorizontalScrollBarVisibilityProperty { get; }

    DependencyProperty ExtentWidthProperty { get; }

    DependencyProperty VerticalOffsetProperty { get; }

    DependencyProperty ViewportHeightProperty { get; }

    DependencyProperty ScrollableHeightProperty { get; }

    DependencyProperty ComputedVerticalScrollBarVisibilityProperty { get; }

    DependencyProperty ExtentHeightProperty { get; }

    DependencyProperty MinZoomFactorProperty { get; }

    DependencyProperty MaxZoomFactorProperty { get; }

    DependencyProperty ZoomFactorProperty { get; }

    DependencyProperty ZoomSnapPointsProperty { get; }

    DependencyProperty HorizontalScrollBarVisibilityProperty { get; }

    ScrollBarVisibility GetHorizontalScrollBarVisibility(DependencyObject element);

    void SetHorizontalScrollBarVisibility(
      DependencyObject element,
      ScrollBarVisibility horizontalScrollBarVisibility);

    DependencyProperty VerticalScrollBarVisibilityProperty { get; }

    ScrollBarVisibility GetVerticalScrollBarVisibility(DependencyObject element);

    void SetVerticalScrollBarVisibility(
      DependencyObject element,
      ScrollBarVisibility verticalScrollBarVisibility);

    DependencyProperty IsHorizontalRailEnabledProperty { get; }

    bool GetIsHorizontalRailEnabled(DependencyObject element);

    void SetIsHorizontalRailEnabled(DependencyObject element, bool isHorizontalRailEnabled);

    DependencyProperty IsVerticalRailEnabledProperty { get; }

    bool GetIsVerticalRailEnabled(DependencyObject element);

    void SetIsVerticalRailEnabled(DependencyObject element, bool isVerticalRailEnabled);

    DependencyProperty IsHorizontalScrollChainingEnabledProperty { get; }

    bool GetIsHorizontalScrollChainingEnabled(DependencyObject element);

    void SetIsHorizontalScrollChainingEnabled(
      DependencyObject element,
      bool isHorizontalScrollChainingEnabled);

    DependencyProperty IsVerticalScrollChainingEnabledProperty { get; }

    bool GetIsVerticalScrollChainingEnabled(DependencyObject element);

    void SetIsVerticalScrollChainingEnabled(
      DependencyObject element,
      bool isVerticalScrollChainingEnabled);

    DependencyProperty IsZoomChainingEnabledProperty { get; }

    bool GetIsZoomChainingEnabled(DependencyObject element);

    void SetIsZoomChainingEnabled(DependencyObject element, bool isZoomChainingEnabled);

    DependencyProperty IsScrollInertiaEnabledProperty { get; }

    bool GetIsScrollInertiaEnabled(DependencyObject element);

    void SetIsScrollInertiaEnabled(DependencyObject element, bool isScrollInertiaEnabled);

    DependencyProperty IsZoomInertiaEnabledProperty { get; }

    bool GetIsZoomInertiaEnabled(DependencyObject element);

    void SetIsZoomInertiaEnabled(DependencyObject element, bool isZoomInertiaEnabled);

    DependencyProperty HorizontalScrollModeProperty { get; }

    ScrollMode GetHorizontalScrollMode(DependencyObject element);

    void SetHorizontalScrollMode(DependencyObject element, ScrollMode horizontalScrollMode);

    DependencyProperty VerticalScrollModeProperty { get; }

    ScrollMode GetVerticalScrollMode(DependencyObject element);

    void SetVerticalScrollMode(DependencyObject element, ScrollMode verticalScrollMode);

    DependencyProperty ZoomModeProperty { get; }

    ZoomMode GetZoomMode(DependencyObject element);

    void SetZoomMode(DependencyObject element, ZoomMode zoomMode);

    DependencyProperty IsDeferredScrollingEnabledProperty { get; }

    bool GetIsDeferredScrollingEnabled(DependencyObject element);

    void SetIsDeferredScrollingEnabled(DependencyObject element, bool isDeferredScrollingEnabled);

    DependencyProperty BringIntoViewOnFocusChangeProperty { get; }

    bool GetBringIntoViewOnFocusChange(DependencyObject element);

    void SetBringIntoViewOnFocusChange(DependencyObject element, bool bringIntoViewOnFocusChange);
  }
}
