// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1897869591, 6909, 17171, 151, 140, 155, 182, 225, 184, 100, 167)]
  [ExclusiveTo(typeof (PackageManager))]
  internal interface IPackageManager5
  {
    [DefaultOverload]
    [Overload("AddPackageToVolumeAndOptionalPackagesAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [RemoteAsync]
    [Overload("StagePackageToVolumeAndOptionalPackagesAsync")]
    [DefaultOverload]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [RemoteAsync]
    [Overload("RegisterPackageByFamilyNameAndOptionalPackagesAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFamilyNameAsync(
      string mainPackageFamilyName,
      IIterable<string> dependencyPackageFamilyNames,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume,
      IIterable<string> optionalPackageFamilyNames);

    PackageManagerDebugSettings DebugSettings { get; }
  }
}
