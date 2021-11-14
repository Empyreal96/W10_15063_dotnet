// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageItemQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (StorageItemQueryResult))]
  [Guid(3902046329, 40280, 18360, 178, 178, 65, 176, 127, 71, 149, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageItemQueryResult : IStorageQueryResultBase
  {
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
  }
}
