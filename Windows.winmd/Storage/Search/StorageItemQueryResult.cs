// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.StorageItemQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemQueryResult : IStorageItemQueryResult, IStorageQueryResultBase
  {
    [RemoteAsync]
    [Overload("GetItemsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [RemoteAsync]
    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetItemCountAsync();

    public extern StorageFolder Folder { [MethodImpl] get; }

    public extern event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

    public extern event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> FindStartIndexAsync([Variant] object value);

    [MethodImpl]
    public extern QueryOptions GetCurrentQueryOptions();

    [MethodImpl]
    public extern void ApplyNewQueryOptions(QueryOptions newQueryOptions);
  }
}
