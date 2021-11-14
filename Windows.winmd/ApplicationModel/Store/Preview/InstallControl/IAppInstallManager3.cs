// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppInstallManager))]
  [Guid(2511489815, 59754, 19726, 132, 225, 200, 203, 65, 122, 1, 120)]
  internal interface IAppInstallManager3
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallAsync(
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallForUserAsync(
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
    IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameForUserAsync(
      User user,
      string packageFamilyName,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> SearchForUpdatesForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesForUserAsync(
      User user,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsAppAllowedToInstallForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsApplicableForUserAsync(
      User user,
      string productId,
      string skuId);

    void MoveToFrontOfDownloadQueue(string productId, string correlationVector);
  }
}
