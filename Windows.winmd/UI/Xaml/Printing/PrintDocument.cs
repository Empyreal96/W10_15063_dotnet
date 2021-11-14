// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.PrintDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [Static(typeof (IPrintDocumentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IPrintDocumentFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class PrintDocument : DependencyObject, IPrintDocument
  {
    [MethodImpl]
    public extern PrintDocument();

    public extern IPrintDocumentSource DocumentSource { [MethodImpl] get; }

    public extern event PaginateEventHandler Paginate;

    public extern event GetPreviewPageEventHandler GetPreviewPage;

    public extern event AddPagesEventHandler AddPages;

    [MethodImpl]
    public extern void AddPage(UIElement pageVisual);

    [MethodImpl]
    public extern void AddPagesComplete();

    [MethodImpl]
    public extern void SetPreviewPageCount(int count, PreviewPageCountType type);

    [MethodImpl]
    public extern void SetPreviewPage(int pageNumber, UIElement pageVisual);

    [MethodImpl]
    public extern void InvalidatePreview();

    public static extern DependencyProperty DocumentSourceProperty { [MethodImpl] get; }
  }
}
