// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2922222193, 15178, 17916, 132, 104, 247, 148, 149, 72, 244, 213)]
  [ExclusiveTo(typeof (TextBlock))]
  [WebHostHidden]
  internal interface ITextBlock
  {
    double FontSize { get; set; }

    FontFamily FontFamily { get; set; }

    FontWeight FontWeight { get; set; }

    FontStyle FontStyle { get; set; }

    FontStretch FontStretch { get; set; }

    int CharacterSpacing { get; set; }

    Brush Foreground { get; set; }

    TextWrapping TextWrapping { get; set; }

    TextTrimming TextTrimming { get; set; }

    TextAlignment TextAlignment { get; set; }

    string Text { get; set; }

    InlineCollection Inlines { get; }

    Thickness Padding { get; set; }

    double LineHeight { get; set; }

    LineStackingStrategy LineStackingStrategy { get; set; }

    bool IsTextSelectionEnabled { get; set; }

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

    bool Focus(FocusState value);
  }
}
