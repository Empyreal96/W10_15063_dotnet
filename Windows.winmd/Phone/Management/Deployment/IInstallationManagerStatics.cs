// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.IInstallationManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(2459608888, 36169, 17068, 128, 201, 180, 173, 121, 60, 67, 242)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InstallationManager))]
  internal interface IInstallationManagerStatics
  {
    [Overload("AddPackageAsync")]
    IAsyncOperationWithProgress<PackageInstallResult, uint> AddPackageAsync(
      string title,
      Uri sourceLocation);

    [Overload("AddPackagePreloadedAsync")]
    IAsyncOperationWithProgress<PackageInstallResult, uint> AddPackageAsync(
      string title,
      Uri sourceLocation,
      string instanceId,
      string offerId,
      Uri license);

    IIterable<IAsyncOperationWithProgress<PackageInstallResult, uint>> GetPendingPackageInstalls();

    IIterable<Package> FindPackagesForCurrentPublisher();

    [Overload("FindPackages")]
    IIterable<Package> FindPackages();
  }
}
