// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfDocument
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPdfDocumentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PdfDocument : IPdfDocument
  {
    [MethodImpl]
    public extern PdfPage GetPage(uint pageIndex);

    public extern uint PageCount { [MethodImpl] get; }

    public extern bool IsPasswordProtected { [MethodImpl] get; }

    [Overload("LoadFromFileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromFileAsync(
      IStorageFile file);

    [Overload("LoadFromFileWithPasswordAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromFileAsync(
      IStorageFile file,
      string password);

    [RemoteAsync]
    [Overload("LoadFromStreamAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream);

    [Overload("LoadFromStreamWithPasswordAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream,
      string password);
  }
}
