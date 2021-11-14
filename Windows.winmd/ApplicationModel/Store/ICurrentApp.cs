// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (CurrentApp))]
  [Guid(3576545381, 55871, 18053, 153, 94, 155, 72, 46, 181, 230, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICurrentApp
  {
    LicenseInformation LicenseInformation { get; }

    global::Windows.Foundation.Uri LinkUri { get; }

    Guid AppId { get; }

    [RemoteAsync]
    IAsyncOperation<string> RequestAppPurchaseAsync(bool includeReceipt);

    [RemoteAsync]
    [Deprecated("RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("RequestProductPurchaseAsync")]
    IAsyncOperation<string> RequestProductPurchaseAsync(
      string productId,
      bool includeReceipt);

    [RemoteAsync]
    IAsyncOperation<ListingInformation> LoadListingInformationAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetAppReceiptAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetProductReceiptAsync(string productId);
  }
}
