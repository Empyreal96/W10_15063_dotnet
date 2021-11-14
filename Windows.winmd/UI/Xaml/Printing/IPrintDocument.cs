// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPrintDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3829606339, 43417, 18523, 177, 216, 114, 220, 81, 120, 33, 230)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PrintDocument))]
  internal interface IPrintDocument
  {
    IPrintDocumentSource DocumentSource { get; }

    event PaginateEventHandler Paginate;

    event GetPreviewPageEventHandler GetPreviewPage;

    event AddPagesEventHandler AddPages;

    void AddPage(UIElement pageVisual);

    void AddPagesComplete();

    void SetPreviewPageCount(int count, PreviewPageCountType type);

    void SetPreviewPage(int pageNumber, UIElement pageVisual);

    void InvalidatePreview();
  }
}
