// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [Guid(1159752268, 2638, 20415, 174, 233, 51, 93, 90, 32, 95, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ITextBlock2
  {
    SolidColorBrush SelectionHighlightColor { get; set; }

    int MaxLines { get; set; }

    TextLineBounds TextLineBounds { get; set; }

    OpticalMarginAlignment OpticalMarginAlignment { get; set; }

    bool IsColorFontEnabled { get; set; }

    TextReadingOrder TextReadingOrder { get; set; }
  }
}
