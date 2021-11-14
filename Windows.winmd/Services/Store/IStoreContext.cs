// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StoreContext))]
  [Guid(2895689406, 62717, 18706, 186, 189, 80, 53, 229, 232, 188, 171)]
  [ContractVersion(typeof (StoreContract), 65536)]
  internal interface IStoreContext
  {
    User User { get; }

    event TypedEventHandler<StoreContext, object> OfflineLicensesChanged;

    [RemoteAsync]
    IAsyncOperation<string> GetCustomerPurchaseIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    IAsyncOperation<string> GetCustomerCollectionsIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    IAsyncOperation<StoreAppLicense> GetAppLicenseAsync();

    [RemoteAsync]
    IAsyncOperation<StoreProductResult> GetStoreProductForCurrentAppAsync();

    [RemoteAsync]
    IAsyncOperation<StoreProductQueryResult> GetStoreProductsAsync(
      IIterable<string> productKinds,
      IIterable<string> storeIds);

    [RemoteAsync]
    IAsyncOperation<StoreProductQueryResult> GetAssociatedStoreProductsAsync(
      IIterable<string> productKinds);

    [RemoteAsync]
    IAsyncOperation<StoreProductPagedQueryResult> GetAssociatedStoreProductsWithPagingAsync(
      IIterable<string> productKinds,
      uint maxItemsToRetrievePerPage);

    [RemoteAsync]
    IAsyncOperation<StoreProductQueryResult> GetUserCollectionAsync(
      IIterable<string> productKinds);

    [RemoteAsync]
    IAsyncOperation<StoreProductPagedQueryResult> GetUserCollectionWithPagingAsync(
      IIterable<string> productKinds,
      uint maxItemsToRetrievePerPage);

    [RemoteAsync]
    IAsyncOperation<StoreConsumableResult> ReportConsumableFulfillmentAsync(
      string productStoreId,
      uint quantity,
      Guid trackingId);

    [RemoteAsync]
    IAsyncOperation<StoreConsumableResult> GetConsumableBalanceRemainingAsync(
      string productStoreId);

    [RemoteAsync]
    IAsyncOperation<StoreAcquireLicenseResult> AcquireStoreLicenseForOptionalPackageAsync(
      Package optionalPackage);

    [Overload("RequestPurchaseAsync")]
    [RemoteAsync]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      string storeId);

    [RemoteAsync]
    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      string storeId,
      StorePurchaseProperties storePurchaseProperties);

    [RemoteAsync]
    IAsyncOperation<IVectorView<StorePackageUpdate>> GetAppAndOptionalStorePackageUpdatesAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> RequestDownloadStorePackageUpdatesAsync(
      IIterable<StorePackageUpdate> storePackageUpdates);

    [RemoteAsync]
    IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> RequestDownloadAndInstallStorePackageUpdatesAsync(
      IIterable<StorePackageUpdate> storePackageUpdates);

    [RemoteAsync]
    IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> RequestDownloadAndInstallStorePackagesAsync(
      IIterable<string> storeIds);
  }
}
