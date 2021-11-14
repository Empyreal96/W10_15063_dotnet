// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.FolderInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;

namespace Windows.Storage.BulkAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FolderInformation : 
    IStorageItemInformation,
    IStorageFolder,
    IStorageItem,
    IStorageItemProperties,
    IStorageFolderQueryOperations,
    IStorageItem2,
    IStorageFolder2,
    IStorageItemPropertiesWithProvider
  {
    public extern MusicProperties MusicProperties { [MethodImpl] get; }

    public extern VideoProperties VideoProperties { [MethodImpl] get; }

    public extern ImageProperties ImageProperties { [MethodImpl] get; }

    public extern DocumentProperties DocumentProperties { [MethodImpl] get; }

    public extern BasicProperties BasicProperties { [MethodImpl] get; }

    public extern StorageItemThumbnail Thumbnail { [MethodImpl] get; }

    public extern event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

    public extern event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

    [Overload("CreateFileAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName);

    [Overload("CreateFileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption options);

    [Overload("CreateFolderAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName);

    [Overload("CreateFolderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(string name);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string name);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(string name);

    [Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();

    [Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();

    [RemoteAsync]
    [Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();

    [Overload("RenameAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(string desiredName);

    [RemoteAsync]
    [Overload("RenameAsync")]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(
      string desiredName,
      NameCollisionOption option);

    [RemoteAsync]
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [Overload("DeleteAsync")]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(StorageDeleteOption option);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    public extern string Name { [MethodImpl] get; }

    public extern string Path { [MethodImpl] get; }

    public extern FileAttributes Attributes { [MethodImpl] get; }

    public extern DateTime DateCreated { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    [Overload("GetThumbnailAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    public extern string DisplayName { [MethodImpl] get; }

    public extern string DisplayType { [MethodImpl] get; }

    public extern string FolderRelativeId { [MethodImpl] get; }

    public extern StorageItemContentProperties Properties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IndexedState> GetIndexedStateAsync();

    [Overload("CreateFileQueryOverloadDefault")]
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQuery();

    [Overload("CreateFileQuery")]
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQuery(CommonFileQuery query);

    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQueryWithOptions(
      QueryOptions queryOptions);

    [Overload("CreateFolderQueryOverloadDefault")]
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQuery();

    [Overload("CreateFolderQuery")]
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQuery(
      CommonFolderQuery query);

    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQueryWithOptions(
      QueryOptions queryOptions);

    [MethodImpl]
    public extern StorageItemQueryResult CreateItemQuery();

    [MethodImpl]
    public extern StorageItemQueryResult CreateItemQueryWithOptions(
      QueryOptions queryOptions);

    [Overload("GetFilesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query);

    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query);

    [RemoteAsync]
    [Overload("GetItemsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [MethodImpl]
    public extern bool AreQueryOptionsSupported(QueryOptions queryOptions);

    [MethodImpl]
    public extern bool IsCommonFolderQuerySupported(CommonFolderQuery query);

    [MethodImpl]
    public extern bool IsCommonFileQuerySupported(CommonFileQuery query);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetParentAsync();

    [MethodImpl]
    public extern bool IsEqual(IStorageItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> TryGetItemAsync(
      string name);

    public extern StorageProvider Provider { [MethodImpl] get; }
  }
}
