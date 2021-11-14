// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfDocumentStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  [ExclusiveTo(typeof (PdfDocument))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1127877471, 49159, 18312, 144, 242, 8, 20, 61, 146, 37, 153)]
  internal interface IPdfDocumentStatics
  {
    [RemoteAsync]
    [Overload("LoadFromFileAsync")]
    IAsyncOperation<PdfDocument> LoadFromFileAsync(IStorageFile file);

    [Overload("LoadFromFileWithPasswordAsync")]
    [RemoteAsync]
    IAsyncOperation<PdfDocument> LoadFromFileAsync(
      IStorageFile file,
      string password);

    [RemoteAsync]
    [Overload("LoadFromStreamAsync")]
    IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream);

    [RemoteAsync]
    [Overload("LoadFromStreamWithPasswordAsync")]
    IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream,
      string password);
  }
}
