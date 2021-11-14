// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [WebHostHidden]
  [Guid(1693040128, 19905, 18749, 171, 231, 203, 211, 197, 119, 73, 13)]
  internal interface IScrollViewer
  {
    ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }

    ScrollBarVisibility VerticalScrollBarVisibility { get; set; }

    bool IsHorizontalRailEnabled { get; set; }

    bool IsVerticalRailEnabled { get; set; }

    bool IsHorizontalScrollChainingEnabled { get; set; }

    bool IsVerticalScrollChainingEnabled { get; set; }

    bool IsZoomChainingEnabled { get; set; }

    bool IsScrollInertiaEnabled { get; set; }

    bool IsZoomInertiaEnabled { get; set; }

    ScrollMode HorizontalScrollMode { get; set; }

    ScrollMode VerticalScrollMode { get; set; }

    ZoomMode ZoomMode { get; set; }

    SnapPointsAlignment HorizontalSnapPointsAlignment { get; set; }

    SnapPointsAlignment VerticalSnapPointsAlignment { get; set; }

    SnapPointsType HorizontalSnapPointsType { get; set; }

    SnapPointsType VerticalSnapPointsType { get; set; }

    SnapPointsType ZoomSnapPointsType { get; set; }

    double HorizontalOffset { get; }

    double ViewportWidth { get; }

    double ScrollableWidth { get; }

    Visibility ComputedHorizontalScrollBarVisibility { get; }

    double ExtentWidth { get; }

    double VerticalOffset { get; }

    double ViewportHeight { get; }

    double ScrollableHeight { get; }

    Visibility ComputedVerticalScrollBarVisibility { get; }

    double ExtentHeight { get; }

    float MinZoomFactor { get; set; }

    float MaxZoomFactor { get; set; }

    float ZoomFactor { get; }

    IVector<float> ZoomSnapPoints { get; }

    event EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;

    [Deprecated("ScrollToHorizontalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ScrollToHorizontalOffset(double offset);

    [Deprecated("ScrollToVerticalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ScrollToVerticalOffset(double offset);

    [Deprecated("ZoomToFactor may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ZoomToFactor(float factor);

    void InvalidateScrollInfo();

    bool IsDeferredScrollingEnabled { get; set; }

    bool BringIntoViewOnFocusChange { get; set; }
  }
}
