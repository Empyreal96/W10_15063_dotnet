// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppWithConsumables
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (CurrentApp))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2219704433, 40527, 20345, 153, 90, 95, 145, 23, 46, 108, 239)]
  internal interface ICurrentAppWithConsumables
  {
    [RemoteAsync]
    IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    [RemoteAsync]
    [Overload("RequestProductPurchaseWithResultsAsync")]
    IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId);

    [Overload("RequestProductPurchaseWithDisplayPropertiesAsync")]
    [RemoteAsync]
    IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId,
      string offerId,
      ProductPurchaseDisplayProperties displayProperties);

    [RemoteAsync]
    IAsyncOperation<IVectorView<UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync();
  }
}
