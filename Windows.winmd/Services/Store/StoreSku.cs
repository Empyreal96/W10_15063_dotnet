// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreSku
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StoreSku : IStoreSku
  {
    public extern string StoreId { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern bool IsTrial { [MethodImpl] get; }

    public extern string CustomDeveloperData { [MethodImpl] get; }

    public extern IVectorView<StoreImage> Images { [MethodImpl] get; }

    public extern IVectorView<StoreVideo> Videos { [MethodImpl] get; }

    public extern IVectorView<StoreAvailability> Availabilities { [MethodImpl] get; }

    public extern StorePrice Price { [MethodImpl] get; }

    public extern string ExtendedJsonData { [MethodImpl] get; }

    public extern bool IsInUserCollection { [MethodImpl] get; }

    public extern IVectorView<string> BundledSkus { [MethodImpl] get; }

    public extern StoreCollectionData CollectionData { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsInstalledAsync();

    [Overload("RequestPurchaseAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync();

    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      StorePurchaseProperties storePurchaseProperties);

    public extern bool IsSubscription { [MethodImpl] get; }

    public extern StoreSubscriptionInfo SubscriptionInfo { [MethodImpl] get; }
  }
}
