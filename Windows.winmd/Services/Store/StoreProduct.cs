// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreProduct
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (StoreContract), 65536)]
  public sealed class StoreProduct : IStoreProduct
  {
    public extern string StoreId { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string ProductKind { [MethodImpl] get; }

    public extern bool HasDigitalDownload { [MethodImpl] get; }

    public extern IVectorView<string> Keywords { [MethodImpl] get; }

    public extern IVectorView<StoreImage> Images { [MethodImpl] get; }

    public extern IVectorView<StoreVideo> Videos { [MethodImpl] get; }

    public extern IVectorView<StoreSku> Skus { [MethodImpl] get; }

    public extern bool IsInUserCollection { [MethodImpl] get; }

    public extern StorePrice Price { [MethodImpl] get; }

    public extern string ExtendedJsonData { [MethodImpl] get; }

    public extern Uri LinkUri { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAnySkuInstalledAsync();

    [RemoteAsync]
    [Overload("RequestPurchaseAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync();

    [RemoteAsync]
    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      StorePurchaseProperties storePurchaseProperties);

    public extern string InAppOfferToken { [MethodImpl] get; }
  }
}
