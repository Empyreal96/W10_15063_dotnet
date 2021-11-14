// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionCatalog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [Guid(2542215218, 33830, 19153, 144, 132, 146, 232, 140, 45, 162, 0)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppExtensionCatalog))]
  internal interface IAppExtensionCatalog
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppExtension>> FindAllAsync();

    [RemoteAsync]
    IAsyncOperation<bool> RequestRemovePackageAsync(string packageFullName);

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageInstalledEventArgs> PackageInstalled;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatingEventArgs> PackageUpdating;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatedEventArgs> PackageUpdated;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUninstallingEventArgs> PackageUninstalling;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageStatusChangedEventArgs> PackageStatusChanged;
  }
}
