// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.CurrentAppSimulator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Store
{
  [Static(typeof (ICurrentAppSimulatorWithCampaignId), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppSimulatorWithConsumables), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppSimulatorStaticsWithFiltering), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICurrentAppSimulator), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class CurrentAppSimulator
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetAppPurchaseCampaignIdAsync();

    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationByProductIdsAsync(
      IIterable<string> productIds);

    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationByKeywordsAsync(
      IIterable<string> keywords);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    [RemoteAsync]
    [Overload("RequestProductPurchaseWithResultsAsync")]
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

    [Deprecated("RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("RequestProductPurchaseAsync")]
    [RemoteAsync]
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

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ReloadSimulatorAsync(
      StorageFile simulatorSettingsFile);
  }
}
