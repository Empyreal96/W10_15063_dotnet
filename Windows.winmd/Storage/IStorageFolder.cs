// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFolder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(1926351736, 46063, 20341, 168, 11, 111, 217, 218, 226, 148, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageFolder : IStorageItem
  {
    [RemoteAsync]
    [Overload("CreateFileAsyncOverloadDefaultOptions")]
    IAsyncOperation<StorageFile> CreateFileAsync(string desiredName);

    [RemoteAsync]
    [Overload("CreateFileAsync")]
    IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption options);

    [RemoteAsync]
    [Overload("CreateFolderAsyncOverloadDefaultOptions")]
    IAsyncOperation<StorageFolder> CreateFolderAsync(string desiredName);

    [Overload("CreateFolderAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption options);

    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileAsync(string name);

    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderAsync(string name);

    [RemoteAsync]
    IAsyncOperation<IStorageItem> GetItemAsync(string name);

    [Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();

    [Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();

    [RemoteAsync]
    [Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
    IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
  }
}
