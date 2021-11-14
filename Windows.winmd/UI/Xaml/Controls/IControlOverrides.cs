// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2694222303, 38948, 16894, 181, 48, 176, 216, 153, 14, 100, 193)]
  [ExclusiveTo(typeof (Control))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IControlOverrides
  {
    void OnPointerEntered(PointerRoutedEventArgs e);

    void OnPointerPressed(PointerRoutedEventArgs e);

    void OnPointerMoved(PointerRoutedEventArgs e);

    void OnPointerReleased(PointerRoutedEventArgs e);

    void OnPointerExited(PointerRoutedEventArgs e);

    void OnPointerCaptureLost(PointerRoutedEventArgs e);

    void OnPointerCanceled(PointerRoutedEventArgs e);

    void OnPointerWheelChanged(PointerRoutedEventArgs e);

    void OnTapped(TappedRoutedEventArgs e);

    void OnDoubleTapped(DoubleTappedRoutedEventArgs e);

    void OnHolding(HoldingRoutedEventArgs e);

    void OnRightTapped(RightTappedRoutedEventArgs e);

    void OnManipulationStarting(ManipulationStartingRoutedEventArgs e);

    void OnManipulationInertiaStarting(ManipulationInertiaStartingRoutedEventArgs e);

    void OnManipulationStarted(ManipulationStartedRoutedEventArgs e);

    void OnManipulationDelta(ManipulationDeltaRoutedEventArgs e);

    void OnManipulationCompleted(ManipulationCompletedRoutedEventArgs e);

    void OnKeyUp(KeyRoutedEventArgs e);

    void OnKeyDown(KeyRoutedEventArgs e);

    void OnGotFocus(RoutedEventArgs e);

    void OnLostFocus(RoutedEventArgs e);

    void OnDragEnter(DragEventArgs e);

    void OnDragLeave(DragEventArgs e);

    void OnDragOver(DragEventArgs e);

    void OnDrop(DragEventArgs e);
  }
}
