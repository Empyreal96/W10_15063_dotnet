// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageQueryResultBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Guid(3264730893, 29523, 18347, 186, 88, 140, 97, 66, 93, 197, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageQueryResultBase
  {
    [RemoteAsync]
    IAsyncOperation<uint> GetItemCountAsync();

    StorageFolder Folder { get; }

    event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

    event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

    [RemoteAsync]
    IAsyncOperation<uint> FindStartIndexAsync([Variant] object value);

    QueryOptions GetCurrentQueryOptions();

    void ApplyNewQueryOptions(QueryOptions newQueryOptions);
  }
}
