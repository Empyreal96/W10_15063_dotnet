// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (ITextBoxStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITextBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (ITextBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITextBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBoxStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  public class TextBox : Control, ITextBox, ITextBox2, ITextBox3, ITextBox4, ITextBox5
  {
    [MethodImpl]
    public extern TextBox();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern string SelectedText { [MethodImpl] get; [MethodImpl] set; }

    public extern int SelectionLength { [MethodImpl] get; [MethodImpl] set; }

    public extern int SelectionStart { [MethodImpl] get; [MethodImpl] set; }

    public extern int MaxLength { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AcceptsReturn { [MethodImpl] get; [MethodImpl] set; }

    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSpellCheckEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextPredictionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern InputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    public extern event TextChangedEventHandler TextChanged;

    public extern event RoutedEventHandler SelectionChanged;

    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    [MethodImpl]
    public extern void Select(int start, int length);

    [MethodImpl]
    public extern void SelectAll();

    [MethodImpl]
    public extern Rect GetRectFromCharacterIndex(int charIndex, bool trailingEdge);

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    public extern bool PreventKeyboardDisplayOnProgrammaticFocus { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TextControlPasteEventHandler Paste;

    public extern event TypedEventHandler<TextBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    public extern event TypedEventHandler<TextBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    public extern event TypedEventHandler<TextBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern CandidateWindowAlignment DesiredCandidateWindowAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<TextBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    public extern event TypedEventHandler<TextBox, TextBoxTextChangingEventArgs> TextChanging;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();

    public extern SolidColorBrush SelectionHighlightColorWhenNotFocused { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { [MethodImpl] get; }

    public static extern DependencyProperty DesiredCandidateWindowAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    public static extern DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxLengthProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsReadOnlyProperty { [MethodImpl] get; }

    public static extern DependencyProperty AcceptsReturnProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSpellCheckEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextPredictionEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty InputScopeProperty { [MethodImpl] get; }
  }
}
