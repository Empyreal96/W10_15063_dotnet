// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfPage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2645864648, 21280, 19708, 173, 118, 73, 63, 218, 208, 229, 148)]
  [ExclusiveTo(typeof (PdfPage))]
  internal interface IPdfPage
  {
    [RemoteAsync]
    [Overload("RenderToStreamAsync")]
    IAsyncAction RenderToStreamAsync(IRandomAccessStream outputStream);

    [Overload("RenderWithOptionsToStreamAsync")]
    IAsyncAction RenderToStreamAsync(
      IRandomAccessStream outputStream,
      PdfPageRenderOptions options);

    [RemoteAsync]
    IAsyncAction PreparePageAsync();

    uint Index { get; }

    Size Size { get; }

    PdfPageDimensions Dimensions { get; }

    PdfPageRotation Rotation { get; }

    float PreferredZoom { get; }
  }
}
