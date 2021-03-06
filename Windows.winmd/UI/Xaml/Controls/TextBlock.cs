// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextBlock
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ITextBlockStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITextBlockStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Inlines")]
  [WebHostHidden]
  public sealed class TextBlock : 
    FrameworkElement,
    ITextBlock,
    ITextBlock2,
    ITextBlock3,
    ITextBlock4,
    ITextBlock5
  {
    [MethodImpl]
    public extern TextBlock();

    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    public extern TextTrimming TextTrimming { [MethodImpl] get; [MethodImpl] set; }

    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern InlineCollection Inlines { [MethodImpl] get; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextSelectionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern string SelectedText { [MethodImpl] get; }

    public extern TextPointer ContentStart { [MethodImpl] get; }

    public extern TextPointer ContentEnd { [MethodImpl] get; }

    public extern TextPointer SelectionStart { [MethodImpl] get; }

    public extern TextPointer SelectionEnd { [MethodImpl] get; }

    public extern double BaselineOffset { [MethodImpl] get; }

    public extern event RoutedEventHandler SelectionChanged;

    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    [MethodImpl]
    public extern void SelectAll();

    [MethodImpl]
    public extern void Select(TextPointer start, TextPointer end);

    [MethodImpl]
    public extern bool Focus(FocusState value);

    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    public extern TextLineBounds TextLineBounds { [MethodImpl] get; [MethodImpl] set; }

    public extern OpticalMarginAlignment OpticalMarginAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern CompositionBrush GetAlphaMask();

    public extern TextDecorations TextDecorations { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TextDecorationsProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextLineBoundsProperty { [MethodImpl] get; }

    public static extern DependencyProperty OpticalMarginAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextTrimmingProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextSelectionEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedTextProperty { [MethodImpl] get; }
  }
}
