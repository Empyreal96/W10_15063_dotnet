// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlock
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RichTextBlock))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3858758114, 47464, 18919, 151, 212, 140, 202, 42, 195, 174, 124)]
  internal interface IRichTextBlock
  {
    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    Brush Foreground { get; set; }

    TextWrapping TextWrapping { get; set; }

    TextTrimming TextTrimming { get; set; }

    TextAlignment TextAlignment { get; set; }

    BlockCollection Blocks { get; }

    Thickness Padding { get; set; }

    double LineHeight { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    int CharacterSpacing { get; set; }

    RichTextBlockOverflow OverflowContentTarget { get; set; }

    bool IsTextSelectionEnabled { get; set; }

    bool HasOverflowContent { get; }

    string SelectedText { get; }

    TextPointer ContentStart { get; }

    TextPointer ContentEnd { get; }

    TextPointer SelectionStart { get; }

    TextPointer SelectionEnd { get; }

    double BaselineOffset { get; }

    event RoutedEventHandler SelectionChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;

    void SelectAll();

    void Select(TextPointer start, TextPointer end);

    TextPointer GetPositionFromPoint(Point point);

    bool Focus(FocusState value);

    double TextIndent { get; set; }
  }
}
