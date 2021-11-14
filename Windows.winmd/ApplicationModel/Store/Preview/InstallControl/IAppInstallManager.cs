// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2471747952, 33857, 19269, 189, 114, 124, 47, 169, 37, 190, 238)]
  [ExclusiveTo(typeof (AppInstallManager))]
  internal interface IAppInstallManager
  {
    IVectorView<AppInstallItem> AppInstallItems { get; }

    void Cancel(string productId);

    void Pause(string productId);

    void Restart(string productId);

    event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemCompleted;

    event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemStatusChanged;

    AutoUpdateSetting AutoUpdateSetting { get; set; }

    string AcquisitionIdentity { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> GetIsApplicableAsync(string productId, string skuId);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync();

    [RemoteAsync]
    IAsyncOperation<bool> IsStoreBlockedByPolicyAsync(
      string storeClientName,
      string storeClientPublisher);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(string productId);
  }
}
