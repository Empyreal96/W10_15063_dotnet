// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexerQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentIndexerQuery))]
  [Guid(1893970168, 19452, 17034, 136, 137, 204, 81, 218, 154, 123, 157)]
  internal interface IContentIndexerQuery
  {
    [RemoteAsync]
    IAsyncOperation<uint> GetCountAsync();

    [Overload("GetPropertiesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync();

    [Overload("GetPropertiesRangeAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync(
      uint startIndex,
      uint maxItems);

    [Overload("GetAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IIndexableContent>> GetAsync();

    [Overload("GetRangeAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IIndexableContent>> GetAsync(
      uint startIndex,
      uint maxItems);

    StorageFolder QueryFolder { get; }
  }
}
