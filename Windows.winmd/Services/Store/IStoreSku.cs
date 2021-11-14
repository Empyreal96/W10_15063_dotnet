// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreSku
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Guid(964587349, 17472, 20227, 134, 60, 145, 243, 254, 200, 61, 121)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [ExclusiveTo(typeof (StoreSku))]
  internal interface IStoreSku
  {
    string StoreId { get; }

    string Language { get; }

    string Title { get; }

    string Description { get; }

    bool IsTrial { get; }

    string CustomDeveloperData { get; }

    IVectorView<StoreImage> Images { get; }

    IVectorView<StoreVideo> Videos { get; }

    IVectorView<StoreAvailability> Availabilities { get; }

    StorePrice Price { get; }

    string ExtendedJsonData { get; }

    bool IsInUserCollection { get; }

    IVectorView<string> BundledSkus { get; }

    StoreCollectionData CollectionData { get; }

    [RemoteAsync]
    IAsyncOperation<bool> GetIsInstalledAsync();

    [Overload("RequestPurchaseAsync")]
    [RemoteAsync]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync();

    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [RemoteAsync]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      StorePurchaseProperties storePurchaseProperties);

    bool IsSubscription { get; }

    StoreSubscriptionInfo SubscriptionInfo { get; }
  }
}
