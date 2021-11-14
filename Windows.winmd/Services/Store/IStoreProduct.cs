// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreProduct
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(839789650, 55136, 17674, 164, 43, 103, 209, 233, 1, 172, 144)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreProduct))]
  internal interface IStoreProduct
  {
    string StoreId { get; }

    string Language { get; }

    string Title { get; }

    string Description { get; }

    string ProductKind { get; }

    bool HasDigitalDownload { get; }

    IVectorView<string> Keywords { get; }

    IVectorView<StoreImage> Images { get; }

    IVectorView<StoreVideo> Videos { get; }

    IVectorView<StoreSku> Skus { get; }

    bool IsInUserCollection { get; }

    StorePrice Price { get; }

    string ExtendedJsonData { get; }

    Uri LinkUri { get; }

    [RemoteAsync]
    IAsyncOperation<bool> GetIsAnySkuInstalledAsync();

    [Overload("RequestPurchaseAsync")]
    [RemoteAsync]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync();

    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [RemoteAsync]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      StorePurchaseProperties storePurchaseProperties);

    string InAppOfferToken { get; }
  }
}
