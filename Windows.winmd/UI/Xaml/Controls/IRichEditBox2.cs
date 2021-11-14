// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichEditBox))]
  [Guid(3152703149, 59397, 18340, 187, 231, 71, 229, 155, 143, 116, 167)]
  internal interface IRichEditBox2
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string PlaceholderText { get; set; }

    SolidColorBrush SelectionHighlightColor { get; set; }

    bool PreventKeyboardDisplayOnProgrammaticFocus { get; set; }

    bool IsColorFontEnabled { get; set; }

    event TextControlPasteEventHandler Paste;
  }
}
