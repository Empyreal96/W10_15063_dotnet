// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PackageManager))]
  [WebHostHidden]
  [Guid(3668810056, 14065, 16807, 145, 136, 188, 38, 62, 13, 203, 114)]
  internal interface IPackageManager3
  {
    [RemoteAsync]
    IAsyncOperation<PackageVolume> AddPackageVolumeAsync(
      string packageStorePath);

    [Overload("AddPackageToVolumeAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    void ClearPackageStatus(string packageFullName, PackageStatus status);

    [RemoteAsync]
    [Overload("RegisterPackageWithAppDataVolumeAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume);

    [Overload("FindPackageVolumeByName")]
    PackageVolume FindPackageVolume(string volumeName);

    IIterable<PackageVolume> FindPackageVolumes();

    PackageVolume GetDefaultPackageVolume();

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> MovePackageToVolumeAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageVolumeAsync(
      PackageVolume volume);

    void SetDefaultPackageVolume(PackageVolume volume);

    void SetPackageStatus(string packageFullName, PackageStatus status);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOfflineAsync(
      PackageVolume packageVolume);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOnlineAsync(
      PackageVolume packageVolume);

    [Overload("StagePackageToVolumeAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [RemoteAsync]
    [Overload("StageUserDataWithOptionsAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions);
  }
}
