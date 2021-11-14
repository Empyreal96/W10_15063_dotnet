// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreProductPagedQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(3374782661, 19925, 18537, 164, 98, 236, 198, 135, 46, 67, 197)]
  [ExclusiveTo(typeof (StoreProductPagedQueryResult))]
  internal interface IStoreProductPagedQueryResult
  {
    IMapView<string, StoreProduct> Products { get; }

    bool HasMoreResults { get; }

    HResult ExtendedError { get; }

    [RemoteAsync]
    IAsyncOperation<StoreProductPagedQueryResult> GetNextAsync();
  }
}
