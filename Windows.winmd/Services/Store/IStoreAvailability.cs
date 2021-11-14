// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreAvailability
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StoreAvailability))]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Guid(4194698021, 4093, 17555, 173, 67, 241, 249, 145, 143, 105, 250)]
  internal interface IStoreAvailability
  {
    string StoreId { get; }

    DateTime EndDate { get; }

    StorePrice Price { get; }

    string ExtendedJsonData { get; }

    [RemoteAsync]
    [Overload("RequestPurchaseAsync")]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync();

    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [RemoteAsync]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      StorePurchaseProperties storePurchaseProperties);
  }
}
