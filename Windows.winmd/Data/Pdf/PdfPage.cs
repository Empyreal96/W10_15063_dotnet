// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PdfPage : IPdfPage, IClosable
  {
    [RemoteAsync]
    [Overload("RenderToStreamAsync")]
    [MethodImpl]
    public extern IAsyncAction RenderToStreamAsync(IRandomAccessStream outputStream);

    [Overload("RenderWithOptionsToStreamAsync")]
    [MethodImpl]
    public extern IAsyncAction RenderToStreamAsync(
      IRandomAccessStream outputStream,
      PdfPageRenderOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PreparePageAsync();

    public extern uint Index { [MethodImpl] get; }

    public extern Size Size { [MethodImpl] get; }

    public extern PdfPageDimensions Dimensions { [MethodImpl] get; }

    public extern PdfPageRotation Rotation { [MethodImpl] get; }

    public extern float PreferredZoom { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
