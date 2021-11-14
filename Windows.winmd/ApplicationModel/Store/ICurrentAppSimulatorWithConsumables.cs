// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppSimulatorWithConsumables
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (CurrentAppSimulator))]
  [Guid(1313992875, 8423, 17426, 155, 133, 89, 187, 120, 56, 134, 103)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICurrentAppSimulatorWithConsumables
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
