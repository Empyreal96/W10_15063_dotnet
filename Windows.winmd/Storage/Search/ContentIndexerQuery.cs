// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.ContentIndexerQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContentIndexerQuery : IContentIndexerQuery
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetCountAsync();

    [Overload("GetPropertiesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync();

    [Overload("GetPropertiesRangeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync(
      uint startIndex,
      uint maxItems);

    [Overload("GetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IIndexableContent>> GetAsync();

    [RemoteAsync]
    [Overload("GetRangeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IIndexableContent>> GetAsync(
      uint startIndex,
      uint maxItems);

    public extern StorageFolder QueryFolder { [MethodImpl] get; }
  }
}
