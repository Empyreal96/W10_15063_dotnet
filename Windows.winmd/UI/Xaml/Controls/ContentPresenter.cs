// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentPresenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (IContentPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IContentPresenterStatics4), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPresenterStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContentPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPresenterStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ContentPresenter : 
    FrameworkElement,
    IContentPresenter,
    IContentPresenterOverrides,
    IContentPresenter2,
    IContentPresenter3,
    IContentPresenter4
  {
    [MethodImpl]
    public extern ContentPresenter();

    public extern object Content { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate ContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplateSelector ContentTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection ContentTransitions { [MethodImpl] get; [MethodImpl] set; }

    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IContentPresenterOverrides.OnContentTemplateChanged(
      DataTemplate oldContentTemplate,
      DataTemplate newContentTemplate);

    [MethodImpl]
    extern void IContentPresenterOverrides.OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);

    public extern OpticalMarginAlignment OpticalMarginAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern TextLineBounds TextLineBounds { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalContentAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalContentAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty OpticalMarginAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextLineBoundsProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTemplateSelectorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }
  }
}
