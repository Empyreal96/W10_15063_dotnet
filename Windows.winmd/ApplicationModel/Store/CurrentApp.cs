// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.CurrentApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [Static(typeof (ICurrentApp2Statics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICurrentAppWithCampaignId), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentApp), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICurrentAppStaticsWithFiltering), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppWithConsumables), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class CurrentApp
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetCustomerPurchaseIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetCustomerCollectionsIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetAppPurchaseCampaignIdAsync();

    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationByProductIdsAsync(
      IIterable<string> productIds);

    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationByKeywordsAsync(
      IIterable<string> keywords);

    [MethodImpl]
    public static extern void ReportProductFulfillment(string productId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    [Overload("RequestProductPurchaseWithResultsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId);

    [Overload("RequestProductPurchaseWithDisplayPropertiesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId,
      string offerId,
      ProductPurchaseDisplayProperties displayProperties);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync();

    public static extern LicenseInformation LicenseInformation { [MethodImpl] get; }

    public static extern global::Windows.Foundation.Uri LinkUri { [MethodImpl] get; }

    public static extern Guid AppId { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> RequestAppPurchaseAsync(
      bool includeReceipt);

    [RemoteAsync]
    [Overload("RequestProductPurchaseAsync")]
    [Deprecated("RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<string> RequestProductPurchaseAsync(
      string productId,
      bool includeReceipt);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetAppReceiptAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetProductReceiptAsync(
      string productId);
  }
}
