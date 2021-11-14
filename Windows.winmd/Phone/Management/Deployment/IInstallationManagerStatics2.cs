// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.IInstallationManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;

namespace Windows.Phone.Management.Deployment
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(2087464125, 64074, 19598, 171, 151, 217, 89, 69, 47, 25, 229)]
  [ExclusiveTo(typeof (InstallationManager))]
  [WebHostHidden]
  internal interface IInstallationManagerStatics2
  {
    IAsyncOperationWithProgress<PackageInstallResult, uint> RemovePackageAsync(
      string packageFullName,
      RemovalOptions removalOptions);

    IAsyncOperationWithProgress<PackageInstallResult, uint> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackagesByNamePublisher")]
    IIterable<Package> FindPackages(string packageName, string packagePublisher);
  }
}
