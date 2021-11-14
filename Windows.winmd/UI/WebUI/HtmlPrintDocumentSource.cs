// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.HtmlPrintDocumentSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HtmlPrintDocumentSource : 
    IHtmlPrintDocumentSource,
    IPrintDocumentSource,
    IClosable
  {
    public extern PrintContent Content { [MethodImpl] get; [MethodImpl] set; }

    public extern float LeftMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern float TopMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern float RightMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern float BottomMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern bool EnableHeaderFooter { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShrinkToFit { [MethodImpl] get; [MethodImpl] set; }

    public extern float PercentScale { [MethodImpl] get; [MethodImpl] set; }

    public extern string PageRange { [MethodImpl] get; }

    [MethodImpl]
    public extern bool TrySetPageRange(string strPageRange);

    [MethodImpl]
    public extern void Close();
  }
}
