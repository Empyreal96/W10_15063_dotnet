// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Services.Store
{
  [Static(typeof (IStoreContextStatics), 65536, "Windows.Services.Store.StoreContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class StoreContext : IStoreContext, IStoreContext2
  {
    public extern User User { [MethodImpl] get; }

    public extern event TypedEventHandler<StoreContext, object> OfflineLicensesChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetCustomerPurchaseIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetCustomerCollectionsIdAsync(
      string serviceTicket,
      string publisherUserId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreAppLicense> GetAppLicenseAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductResult> GetStoreProductForCurrentAppAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductQueryResult> GetStoreProductsAsync(
      IIterable<string> productKinds,
      IIterable<string> storeIds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductQueryResult> GetAssociatedStoreProductsAsync(
      IIterable<string> productKinds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductPagedQueryResult> GetAssociatedStoreProductsWithPagingAsync(
      IIterable<string> productKinds,
      uint maxItemsToRetrievePerPage);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductQueryResult> GetUserCollectionAsync(
      IIterable<string> productKinds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductPagedQueryResult> GetUserCollectionWithPagingAsync(
      IIterable<string> productKinds,
      uint maxItemsToRetrievePerPage);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreConsumableResult> ReportConsumableFulfillmentAsync(
      string productStoreId,
      uint quantity,
      Guid trackingId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreConsumableResult> GetConsumableBalanceRemainingAsync(
      string productStoreId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreAcquireLicenseResult> AcquireStoreLicenseForOptionalPackageAsync(
      Package optionalPackage);

    [RemoteAsync]
    [Overload("RequestPurchaseAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      string storeId);

    [Overload("RequestPurchaseWithPurchasePropertiesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorePurchaseResult> RequestPurchaseAsync(
      string storeId,
      StorePurchaseProperties storePurchaseProperties);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorePackageUpdate>> GetAppAndOptionalStorePackageUpdatesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> RequestDownloadStorePackageUpdatesAsync(
      IIterable<StorePackageUpdate> storePackageUpdates);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> RequestDownloadAndInstallStorePackageUpdatesAsync(
      IIterable<StorePackageUpdate> storePackageUpdates);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> RequestDownloadAndInstallStorePackagesAsync(
      IIterable<string> storeIds);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StoreProductResult> FindStoreProductForPackageAsync(
      IIterable<string> productKinds,
      Package package);

    [MethodImpl]
    public static extern StoreContext GetDefault();

    [MethodImpl]
    public static extern StoreContext GetForUser(User user);
  }
}
