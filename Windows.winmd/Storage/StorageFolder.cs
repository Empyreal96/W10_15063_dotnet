// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageFolder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStorageFolderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class StorageFolder : 
    IStorageFolder,
    IStorageItem,
    IStorageFolderQueryOperations,
    IStorageItemProperties,
    IStorageItemProperties2,
    IStorageItem2,
    IStorageFolder2,
    IStorageItemPropertiesWithProvider
  {
    [Overload("CreateFileAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName);

    [RemoteAsync]
    [Overload("CreateFileAsync")]
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

    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [Overload("DeleteAsync")]
    [RemoteAsync]
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

    [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
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

    [Overload("GetItemsAsync")]
    [RemoteAsync]
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

    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
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

    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode);

    [RemoteAsync]
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    [RemoteAsync]
    [Overload("GetScaledImageAsThumbnailAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

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

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> GetFolderFromPathAsync(
      string path);
  }
}
