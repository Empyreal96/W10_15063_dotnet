// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3251082035, 26185, 19229, 168, 38, 164, 179, 221, 35, 77, 11)]
  internal interface IBackgroundDownloader : IBackgroundTransferBase
  {
    [Overload("CreateDownload")]
    DownloadOperation CreateDownload(Uri uri, IStorageFile resultFile);

    [Overload("CreateDownloadFromFile")]
    DownloadOperation CreateDownload(
      Uri uri,
      IStorageFile resultFile,
      IStorageFile requestBodyFile);

    [RemoteAsync]
    IAsyncOperation<DownloadOperation> CreateDownloadAsync(
      Uri uri,
      IStorageFile resultFile,
      IInputStream requestBodyStream);
  }
}
