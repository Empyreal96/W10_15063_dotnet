// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Control
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IControlStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IControlStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IControlStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IControlFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IControlStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Control : 
    FrameworkElement,
    IControl,
    IControlOverrides,
    IControlProtected,
    IControl2,
    IControl3,
    IControl4,
    IControl5
  {
    [MethodImpl]
    protected extern Control();

    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTabStop { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern int TabIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern KeyboardNavigationMode TabNavigation { [MethodImpl] get; [MethodImpl] set; }

    public extern ControlTemplate Template { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern FocusState FocusState { [MethodImpl] get; }

    public extern event DependencyPropertyChangedEventHandler IsEnabledChanged;

    [MethodImpl]
    public extern bool ApplyTemplate();

    [MethodImpl]
    public extern bool Focus(FocusState value);

    [MethodImpl]
    extern void IControlOverrides.OnPointerEntered(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerPressed(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerMoved(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerReleased(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerExited(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerCaptureLost(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerCanceled(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerWheelChanged(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnTapped(TappedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDoubleTapped(DoubleTappedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnHolding(HoldingRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnRightTapped(RightTappedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationStarting(
      ManipulationStartingRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationInertiaStarting(
      ManipulationInertiaStartingRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationStarted(
      ManipulationStartedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationDelta(
      ManipulationDeltaRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationCompleted(
      ManipulationCompletedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnKeyUp(KeyRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnKeyDown(KeyRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnGotFocus(RoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnLostFocus(RoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDragEnter(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDragLeave(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDragOver(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDrop(DragEventArgs e);

    extern object IControlProtected.DefaultStyleKey { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern DependencyObject IControlProtected.GetTemplateChild(
      string childName);

    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool UseSystemFocusVisuals { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFocusEngagementEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFocusEngaged { [MethodImpl] get; [MethodImpl] set; }

    public extern RequiresPointer RequiresPointer { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<Control, FocusEngagedEventArgs> FocusEngaged;

    public extern event TypedEventHandler<Control, FocusDisengagedEventArgs> FocusDisengaged;

    [MethodImpl]
    public extern void RemoveFocusEngagement();

    public extern Uri DefaultStyleResourceUri { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DefaultStyleResourceUriProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTemplateKeyTipTargetProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsTemplateKeyTipTarget(DependencyObject element);

    [MethodImpl]
    public static extern void SetIsTemplateKeyTipTarget(DependencyObject element, bool value);

    public static extern DependencyProperty IsFocusEngagementEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFocusEngagedProperty { [MethodImpl] get; }

    public static extern DependencyProperty RequiresPointerProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusLeftProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusRightProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusUpProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusDownProperty { [MethodImpl] get; }

    public static extern DependencyProperty ElementSoundModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty UseSystemFocusVisualsProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTemplateFocusTargetProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsTemplateFocusTarget(FrameworkElement element);

    [MethodImpl]
    public static extern void SetIsTemplateFocusTarget(FrameworkElement element, bool value);

    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTabStopProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty TabIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty TabNavigationProperty { [MethodImpl] get; }

    public static extern DependencyProperty TemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalContentAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalContentAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty DefaultStyleKeyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusStateProperty { [MethodImpl] get; }
  }
}
