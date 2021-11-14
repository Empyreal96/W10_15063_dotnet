// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(378763345, 60727, 18445, 131, 20, 82, 226, 124, 3, 240, 74)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (AppInstallManager))]
  internal interface IAppInstallManager2
  {
    [Overload("StartAppInstallWithTelemetryAsync")]
    [RemoteAsync]
    IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string catalogId,
      string bundleId,
      string correlationVector);

    [RemoteAsync]
    [Overload("UpdateAppByPackageFamilyNameWithTelemetryAsync")]
    IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName,
      string correlationVector);

    [RemoteAsync]
    [Overload("SearchForUpdatesWithTelemetryAsync")]
    IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [Overload("SearchForAllUpdatesWithTelemetryAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync(
      string correlationVector);

    [RemoteAsync]
    [Overload("GetIsAppAllowedToInstallWithTelemetryAsync")]
    IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [Overload("CancelWithTelemetry")]
    void Cancel(string productId, string correlationVector);

    [Overload("PauseWithTelemetry")]
    void Pause(string productId, string correlationVector);

    [Overload("RestartWithTelemetry")]
    void Restart(string productId, string correlationVector);
  }
}
