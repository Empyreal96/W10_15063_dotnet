// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PackageManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4155166861, 2112, 18162, 181, 216, 202, 212, 118, 147, 160, 149)]
  internal interface IPackageManager2
  {
    [Overload("RemovePackageWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName,
      RemovalOptions removalOptions);

    [RemoteAsync]
    [Overload("StagePackageWithOptionsAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFullNameAsync(
      string mainPackageFullName,
      IIterable<string> dependencyPackageFullNames,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackagesWithPackageTypes")]
    IIterable<Package> FindPackagesWithPackageTypes(PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    [Overload("FindPackagesByNamePublisherWithPackageTypes")]
    IIterable<Package> FindPackagesWithPackageTypes(
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    IIterable<Package> FindPackagesWithPackageTypes(
      string packageFamilyName,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackageTypes")]
    IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageFamilyName,
      PackageTypes packageTypes);

    [RemoteAsync]
    [Overload("StageUserDataAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName);
  }
}
