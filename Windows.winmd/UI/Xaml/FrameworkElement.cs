// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IFrameworkElementFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFrameworkElementStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFrameworkElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFrameworkElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IFrameworkElementStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  public class FrameworkElement : 
    UIElement,
    IFrameworkElement,
    IFrameworkElementOverrides,
    IFrameworkElement2,
    IFrameworkElementOverrides2,
    IFrameworkElement3,
    IFrameworkElement4
  {
    [MethodImpl]
    protected extern FrameworkElement();

    public extern TriggerCollection Triggers { [MethodImpl] get; }

    public extern ResourceDictionary Resources { [MethodImpl] get; [MethodImpl] set; }

    public extern object Tag { [MethodImpl] get; [MethodImpl] set; }

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern double ActualWidth { [MethodImpl] get; }

    public extern double ActualHeight { [MethodImpl] get; }

    public extern double Width { [MethodImpl] get; [MethodImpl] set; }

    public extern double Height { [MethodImpl] get; [MethodImpl] set; }

    public extern double MinWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double MinHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Margin { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri BaseUri { [MethodImpl] get; }

    public extern object DataContext { [MethodImpl] get; [MethodImpl] set; }

    public extern Style Style { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject Parent { [MethodImpl] get; }

    public extern FlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler Loaded;

    public extern event RoutedEventHandler Unloaded;

    public extern event SizeChangedEventHandler SizeChanged;

    public extern event EventHandler<object> LayoutUpdated;

    [MethodImpl]
    public extern object FindName(string name);

    [MethodImpl]
    public extern void SetBinding(DependencyProperty dp, BindingBase binding);

    [MethodImpl]
    extern Size IFrameworkElementOverrides.MeasureOverride(
      Size availableSize);

    [MethodImpl]
    extern Size IFrameworkElementOverrides.ArrangeOverride(
      Size finalSize);

    [MethodImpl]
    extern void IFrameworkElementOverrides.OnApplyTemplate();

    public extern ElementTheme RequestedTheme { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> DataContextChanged;

    [MethodImpl]
    public extern BindingExpression GetBindingExpression(DependencyProperty dp);

    [MethodImpl]
    extern bool IFrameworkElementOverrides2.GoToElementStateCore(
      string stateName,
      bool useTransitions);

    public extern event TypedEventHandler<FrameworkElement, object> Loading;

    public extern bool AllowFocusOnInteraction { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness FocusVisualMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness FocusVisualSecondaryThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness FocusVisualPrimaryThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush FocusVisualSecondaryBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush FocusVisualPrimaryBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowFocusWhenDisabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern void DeferTree(DependencyObject element);

    public static extern DependencyProperty AllowFocusOnInteractionProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusVisualMarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusVisualSecondaryThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusVisualPrimaryThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusVisualSecondaryBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusVisualPrimaryBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty AllowFocusWhenDisabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty RequestedThemeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TagProperty { [MethodImpl] get; }

    public static extern DependencyProperty LanguageProperty { [MethodImpl] get; }

    public static extern DependencyProperty ActualWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ActualHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty WidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty MarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty NameProperty { [MethodImpl] get; }

    public static extern DependencyProperty DataContextProperty { [MethodImpl] get; }

    public static extern DependencyProperty StyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FlowDirectionProperty { [MethodImpl] get; }
  }
}
