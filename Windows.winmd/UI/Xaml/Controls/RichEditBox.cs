// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichEditBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IRichEditBoxStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IRichEditBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics4), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IRichEditBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IRichEditBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class RichEditBox : 
    Control,
    IRichEditBox,
    IRichEditBox2,
    IRichEditBox3,
    IRichEditBox4,
    IRichEditBox5
  {
    [MethodImpl]
    public extern RichEditBox();

    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AcceptsReturn { [MethodImpl] get; [MethodImpl] set; }

    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSpellCheckEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextPredictionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ITextDocument Document { [MethodImpl] get; }

    public extern InputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler TextChanged;

    public extern event RoutedEventHandler SelectionChanged;

    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    public extern bool PreventKeyboardDisplayOnProgrammaticFocus { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TextControlPasteEventHandler Paste;

    public extern event TypedEventHandler<RichEditBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    public extern event TypedEventHandler<RichEditBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    public extern event TypedEventHandler<RichEditBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern CandidateWindowAlignment DesiredCandidateWindowAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<RichEditBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    public extern event TypedEventHandler<RichEditBox, RichEditBoxTextChangingEventArgs> TextChanging;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();

    public extern RichEditClipboardFormat ClipboardCopyFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern SolidColorBrush SelectionHighlightColorWhenNotFocused { [MethodImpl] get; [MethodImpl] set; }

    public extern int MaxLength { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxLengthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ClipboardCopyFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty DesiredCandidateWindowAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    public static extern DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsReadOnlyProperty { [MethodImpl] get; }

    public static extern DependencyProperty AcceptsReturnProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSpellCheckEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextPredictionEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty InputScopeProperty { [MethodImpl] get; }
  }
}
