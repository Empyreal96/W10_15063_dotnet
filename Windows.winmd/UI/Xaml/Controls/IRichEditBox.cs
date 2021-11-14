// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2426763840, 32950, 20430, 177, 236, 227, 198, 22, 40, 75, 106)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBox
  {
    bool IsReadOnly { get; set; }

    bool AcceptsReturn { get; set; }

    TextAlignment TextAlignment { get; set; }

    TextWrapping TextWrapping { get; set; }

    bool IsSpellCheckEnabled { get; set; }

    bool IsTextPredictionEnabled { get; set; }

    ITextDocument Document { get; }

    InputScope InputScope { get; set; }

    event RoutedEventHandler TextChanged;

    event RoutedEventHandler SelectionChanged;

    event ContextMenuOpeningEventHandler ContextMenuOpening;
  }
}
