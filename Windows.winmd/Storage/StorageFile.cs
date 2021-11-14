// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageFile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [Static(typeof (IStorageFileStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageFile : 
    IStorageFile,
    IInputStreamReference,
    IRandomAccessStreamReference,
    IStorageItem,
    IStorageItemProperties,
    IStorageItemProperties2,
    IStorageItem2,
    IStorageItemPropertiesWithProvider,
    IStorageFilePropertiesWithAvailability,
    IStorageFile2
  {
    public extern string FileType { [MethodImpl] get; }

    public extern string ContentType { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();

    [RemoteAsync]
    [Overload("CopyOverloadDefaultNameAndOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder);

    [RemoteAsync]
    [Overload("CopyOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    [RemoteAsync]
    [Overload("CopyOverload")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace);

    [Overload("MoveOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(IStorageFolder destinationFolder);

    [RemoteAsync]
    [Overload("MoveOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    [RemoteAsync]
    [Overload("MoveOverload")]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace);

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

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IInputStream> OpenSequentialReadAsync();

    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    [RemoteAsync]
    [Overload("GetThumbnailAsync")]
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

    public extern StorageProvider Provider { [MethodImpl] get; }

    public extern bool IsAvailable { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("OpenWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode,
      StorageOpenOptions options);

    [RemoteAsync]
    [Overload("OpenTransactedWriteWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      StorageOpenOptions options);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> GetFileFromPathAsync(
      string path);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateStreamedFileAsync(
      string displayNameWithExtension,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync(
      IStorageFile fileToReplace,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync(
      string displayNameWithExtension,
      Uri uri,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync(
      IStorageFile fileToReplace,
      Uri uri,
      IRandomAccessStreamReference thumbnail);
  }
}
