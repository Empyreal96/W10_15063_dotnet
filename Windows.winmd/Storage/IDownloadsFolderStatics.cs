// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IDownloadsFolderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (DownloadsFolder))]
  [Guid(663105232, 16462, 18399, 161, 226, 227, 115, 8, 190, 123, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDownloadsFolderStatics
  {
    [RemoteAsync]
    [Overload("CreateFileAsync")]
    IAsyncOperation<StorageFile> CreateFileAsync(string desiredName);

    [Overload("CreateFolderAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderAsync(string desiredName);

    [RemoteAsync]
    [Overload("CreateFileWithCollisionOptionAsync")]
    IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption option);

    [RemoteAsync]
    [Overload("CreateFolderWithCollisionOptionAsync")]
    IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption option);
  }
}
