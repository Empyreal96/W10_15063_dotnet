// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3834600075, 7679, 17234, 161, 244, 229, 22, 81, 78, 200, 130)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBox))]
  [WebHostHidden]
  internal interface ITextBox
  {
    string Text { get; set; }

    string SelectedText { get; set; }

    int SelectionLength { get; set; }

    int SelectionStart { get; set; }

    int MaxLength { get; set; }

    bool IsReadOnly { get; set; }

    bool AcceptsReturn { get; set; }

    TextAlignment TextAlignment { get; set; }

    TextWrapping TextWrapping { get; set; }

    bool IsSpellCheckEnabled { get; set; }

    bool IsTextPredictionEnabled { get; set; }

    InputScope InputScope { get; set; }

    event TextChangedEventHandler TextChanged;

    event RoutedEventHandler SelectionChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;

    void Select(int start, int length);

    void SelectAll();

    Rect GetRectFromCharacterIndex(int charIndex, bool trailingEdge);
  }
}
