// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlock2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RichTextBlock))]
  [Guid(1059098643, 999, 17672, 150, 74, 145, 174, 218, 179, 209, 30)]
  internal interface IRichTextBlock2
  {
    int MaxLines { get; set; }

    TextLineBounds TextLineBounds { get; set; }

    SolidColorBrush SelectionHighlightColor { get; set; }

    OpticalMarginAlignment OpticalMarginAlignment { get; set; }

    bool IsColorFontEnabled { get; set; }

    TextReadingOrder TextReadingOrder { get; set; }
  }
}
