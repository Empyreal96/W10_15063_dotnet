// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppInstallManager : 
    IAppInstallManager,
    IAppInstallManager2,
    IAppInstallManager3,
    IAppInstallManager4,
    IAppInstallManager5
  {
    [MethodImpl]
    public extern AppInstallManager();

    public extern IVectorView<AppInstallItem> AppInstallItems { [MethodImpl] get; }

    [MethodImpl]
    public extern void Cancel(string productId);

    [MethodImpl]
    public extern void Pause(string productId);

    [MethodImpl]
    public extern void Restart(string productId);

    public extern event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemCompleted;

    public extern event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemStatusChanged;

    public extern AutoUpdateSetting AutoUpdateSetting { [MethodImpl] get; [MethodImpl] set; }

    public extern string AcquisitionIdentity { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsApplicableAsync(
      string productId,
      string skuId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsStoreBlockedByPolicyAsync(
      string storeClientName,
      string storeClientPublisher);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(
      string productId);

    [Overload("StartAppInstallWithTelemetryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string catalogId,
      string bundleId,
      string correlationVector);

    [Overload("UpdateAppByPackageFamilyNameWithTelemetryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName,
      string correlationVector);

    [RemoteAsync]
    [Overload("SearchForUpdatesWithTelemetryAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [Overload("SearchForAllUpdatesWithTelemetryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync(
      string correlationVector);

    [Overload("GetIsAppAllowedToInstallWithTelemetryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [Overload("CancelWithTelemetry")]
    [MethodImpl]
    public extern void Cancel(string productId, string correlationVector);

    [Overload("PauseWithTelemetry")]
    [MethodImpl]
    public extern void Pause(string productId, string correlationVector);

    [Overload("RestartWithTelemetry")]
    [MethodImpl]
    public extern void Restart(string productId, string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallAsync(
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallForUserAsync(
      User user,
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameForUserAsync(
      User user,
      string packageFamilyName,
      string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesForUserAsync(
      User user,
      string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAppAllowedToInstallForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsApplicableForUserAsync(
      User user,
      string productId,
      string skuId);

    [MethodImpl]
    public extern void MoveToFrontOfDownloadQueue(string productId, string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementForUserAsync(
      User user,
      string storeId,
      string campaignId,
      string correlationVector);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GetEntitlementResult> GetFreeDeviceEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);

    public extern IVectorView<AppInstallItem> AppInstallItemsWithGroupSupport { [MethodImpl] get; }
  }
}
