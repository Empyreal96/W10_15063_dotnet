// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.FileInformationFactory
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IFileInformationFactoryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileInformationFactory : IFileInformationFactory
  {
    [MethodImpl]
    public extern FileInformationFactory(IStorageQueryResultBase queryResult, ThumbnailMode mode);

    [MethodImpl]
    public extern FileInformationFactory(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize);

    [MethodImpl]
    public extern FileInformationFactory(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions);

    [MethodImpl]
    public extern FileInformationFactory(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions,
      bool delayLoad);

    [RemoteAsync]
    [Overload("GetItemsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();

    [RemoteAsync]
    [Overload("GetFilesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFilesAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();

    [Overload("GetFoldersAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();

    [MethodImpl]
    public extern object GetVirtualizedItemsVector();

    [MethodImpl]
    public extern object GetVirtualizedFilesVector();

    [MethodImpl]
    public extern object GetVirtualizedFoldersVector();
  }
}
