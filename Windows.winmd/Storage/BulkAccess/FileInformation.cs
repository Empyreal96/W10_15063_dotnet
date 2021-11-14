// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.FileInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Storage.BulkAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileInformation : 
    IStorageItemInformation,
    IStorageFile,
    IInputStreamReference,
    IRandomAccessStreamReference,
    IStorageItem,
    IStorageItemProperties,
    IStorageItem2,
    IStorageItemPropertiesWithProvider,
    IStorageFilePropertiesWithAvailability,
    IStorageFile2
  {
    public extern MusicProperties MusicProperties { [MethodImpl] get; }

    public extern VideoProperties VideoProperties { [MethodImpl] get; }

    public extern ImageProperties ImageProperties { [MethodImpl] get; }

    public extern DocumentProperties DocumentProperties { [MethodImpl] get; }

    public extern BasicProperties BasicProperties { [MethodImpl] get; }

    public extern StorageItemThumbnail Thumbnail { [MethodImpl] get; }

    public extern event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

    public extern event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

    public extern string FileType { [MethodImpl] get; }

    public extern string ContentType { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();

    [Overload("CopyOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder);

    [Overload("CopyOverloadDefaultOptions")]
    [RemoteAsync]
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

    [Overload("MoveOverloadDefaultOptions")]
    [RemoteAsync]
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

    [Overload("RenameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(
      string desiredName,
      NameCollisionOption option);

    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [RemoteAsync]
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

    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
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
  }
}
