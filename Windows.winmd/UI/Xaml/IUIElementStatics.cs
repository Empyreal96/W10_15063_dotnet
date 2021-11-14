// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [Guid(1490245435, 62764, 17854, 152, 139, 165, 134, 149, 100, 135, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  internal interface IUIElementStatics
  {
    RoutedEvent KeyDownEvent { get; }

    RoutedEvent KeyUpEvent { get; }

    RoutedEvent PointerEnteredEvent { get; }

    RoutedEvent PointerPressedEvent { get; }

    RoutedEvent PointerMovedEvent { get; }

    RoutedEvent PointerReleasedEvent { get; }

    RoutedEvent PointerExitedEvent { get; }

    RoutedEvent PointerCaptureLostEvent { get; }

    RoutedEvent PointerCanceledEvent { get; }

    RoutedEvent PointerWheelChangedEvent { get; }

    RoutedEvent TappedEvent { get; }

    RoutedEvent DoubleTappedEvent { get; }

    RoutedEvent HoldingEvent { get; }

    RoutedEvent RightTappedEvent { get; }

    RoutedEvent ManipulationStartingEvent { get; }

    RoutedEvent ManipulationInertiaStartingEvent { get; }

    RoutedEvent ManipulationStartedEvent { get; }

    RoutedEvent ManipulationDeltaEvent { get; }

    RoutedEvent ManipulationCompletedEvent { get; }

    RoutedEvent DragEnterEvent { get; }

    RoutedEvent DragLeaveEvent { get; }

    RoutedEvent DragOverEvent { get; }

    RoutedEvent DropEvent { get; }

    DependencyProperty AllowDropProperty { get; }

    DependencyProperty OpacityProperty { [IndependentlyAnimatable] get; }

    DependencyProperty ClipProperty { [IndependentlyAnimatable] get; }

    DependencyProperty RenderTransformProperty { [IndependentlyAnimatable] get; }

    DependencyProperty ProjectionProperty { [IndependentlyAnimatable] get; }

    DependencyProperty RenderTransformOriginProperty { get; }

    DependencyProperty IsHitTestVisibleProperty { get; }

    DependencyProperty VisibilityProperty { get; }

    DependencyProperty UseLayoutRoundingProperty { get; }

    DependencyProperty TransitionsProperty { get; }

    DependencyProperty CacheModeProperty { get; }

    DependencyProperty IsTapEnabledProperty { get; }

    DependencyProperty IsDoubleTapEnabledProperty { get; }

    DependencyProperty IsRightTapEnabledProperty { get; }

    DependencyProperty IsHoldingEnabledProperty { get; }

    DependencyProperty ManipulationModeProperty { get; }

    DependencyProperty PointerCapturesProperty { get; }
  }
}
