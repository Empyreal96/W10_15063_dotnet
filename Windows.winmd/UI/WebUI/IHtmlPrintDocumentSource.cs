// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IHtmlPrintDocumentSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (HtmlPrintDocumentSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3467003546, 3589, 18042, 171, 201, 54, 236, 29, 76, 220, 182)]
  internal interface IHtmlPrintDocumentSource : IPrintDocumentSource
  {
    PrintContent Content { get; set; }

    float LeftMargin { get; set; }

    float TopMargin { get; set; }

    float RightMargin { get; set; }

    float BottomMargin { get; set; }

    bool EnableHeaderFooter { get; set; }

    bool ShrinkToFit { get; set; }

    float PercentScale { get; set; }

    string PageRange { get; }

    bool TrySetPageRange(string strPageRange);
  }
}
