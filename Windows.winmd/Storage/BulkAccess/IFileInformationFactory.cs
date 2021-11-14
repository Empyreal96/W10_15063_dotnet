// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.IFileInformationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.BulkAccess
{
  [Guid(1075677374, 38415, 19821, 167, 208, 26, 56, 97, 231, 108, 131)]
  [ExclusiveTo(typeof (FileInformationFactory))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileInformationFactory
  {
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();

    [Overload("GetFilesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [Overload("GetFilesAsyncDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();

    [Overload("GetFoldersAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();

    object GetVirtualizedItemsVector();

    object GetVirtualizedFilesVector();

    object GetVirtualizedFoldersVector();
  }
}
