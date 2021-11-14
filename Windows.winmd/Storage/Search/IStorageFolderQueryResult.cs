// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFolderQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageFolderQueryResult))]
  [Guid(1716832529, 32102, 18170, 174, 207, 228, 164, 186, 169, 58, 184)]
  internal interface IStorageFolderQueryResult : IStorageQueryResultBase
  {
    [Overload("GetFoldersAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [RemoteAsync]
    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
  }
}
