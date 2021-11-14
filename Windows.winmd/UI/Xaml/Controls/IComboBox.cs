// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3114848348, 44183, 18417, 165, 244, 63, 159, 77, 75, 17, 108)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ComboBox))]
  internal interface IComboBox
  {
    bool IsDropDownOpen { get; set; }

    bool IsEditable { get; }

    bool IsSelectionBoxHighlighted { get; }

    double MaxDropDownHeight { get; set; }

    object SelectionBoxItem { get; }

    DataTemplate SelectionBoxItemTemplate { get; }

    ComboBoxTemplateSettings TemplateSettings { get; }

    event EventHandler<object> DropDownClosed;

    event EventHandler<object> DropDownOpened;
  }
}
