// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFileQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageFileQueryResult))]
  [Guid(1392354375, 11178, 16684, 178, 159, 212, 177, 119, 142, 250, 30)]
  internal interface IStorageFileQueryResult : IStorageQueryResultBase
  {
    [RemoteAsync]
    [Overload("GetFilesAsync")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [RemoteAsync]
    [Overload("GetFilesAsyncDefaultStartAndCount")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
  }
}
