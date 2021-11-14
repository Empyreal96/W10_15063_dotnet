// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFileStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageFile))]
  [Guid(1501873936, 56050, 17352, 139, 180, 164, 211, 234, 207, 208, 63)]
  internal interface IStorageFileStatics
  {
    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileFromPathAsync(string path);

    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync(Uri uri);

    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateStreamedFileAsync(
      string displayNameWithExtension,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync(
      IStorageFile fileToReplace,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync(
      string displayNameWithExtension,
      Uri uri,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync(
      IStorageFile fileToReplace,
      Uri uri,
      IRandomAccessStreamReference thumbnail);
  }
}
