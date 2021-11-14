// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFolderQueryOperations
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Guid(3410218185, 17515, 19023, 190, 151, 117, 119, 113, 190, 82, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageFolderQueryOperations
  {
    [RemoteAsync]
    IAsyncOperation<IndexedState> GetIndexedStateAsync();

    [Overload("CreateFileQueryOverloadDefault")]
    StorageFileQueryResult CreateFileQuery();

    [Overload("CreateFileQuery")]
    StorageFileQueryResult CreateFileQuery(CommonFileQuery query);

    StorageFileQueryResult CreateFileQueryWithOptions(
      QueryOptions queryOptions);

    [Overload("CreateFolderQueryOverloadDefault")]
    StorageFolderQueryResult CreateFolderQuery();

    [Overload("CreateFolderQuery")]
    StorageFolderQueryResult CreateFolderQuery(CommonFolderQuery query);

    StorageFolderQueryResult CreateFolderQueryWithOptions(
      QueryOptions queryOptions);

    StorageItemQueryResult CreateItemQuery();

    StorageItemQueryResult CreateItemQueryWithOptions(
      QueryOptions queryOptions);

    [RemoteAsync]
    [Overload("GetFilesAsync")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query);

    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query);

    [Overload("GetItemsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    bool AreQueryOptionsSupported(QueryOptions queryOptions);

    bool IsCommonFolderQuerySupported(CommonFolderQuery query);

    bool IsCommonFileQuerySupported(CommonFileQuery query);
  }
}
