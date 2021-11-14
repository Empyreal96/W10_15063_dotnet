// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageManager : 
    IPackageManager,
    IPackageManager2,
    IPackageManager3,
    IPackageManager4,
    IPackageManager5
  {
    [MethodImpl]
    public extern PackageManager();

    [Overload("AddPackageAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName);

    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris);

    [Overload("RegisterPackageAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackages")]
    [MethodImpl]
    public extern IIterable<Package> FindPackages();

    [Overload("FindPackagesByUserSecurityId")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUser(string userSecurityId);

    [Overload("FindPackagesByNamePublisher")]
    [MethodImpl]
    public extern IIterable<Package> FindPackages(
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByUserSecurityIdNamePublisher")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUser(
      string userSecurityId,
      string packageName,
      string packagePublisher);

    [MethodImpl]
    public extern IIterable<PackageUserInformation> FindUsers(
      string packageFullName);

    [MethodImpl]
    public extern void SetPackageState(string packageFullName, PackageState packageState);

    [Overload("FindPackageByPackageFullName")]
    [MethodImpl]
    public extern Package FindPackage(string packageFullName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync(
      string packageName,
      string userSecurityId);

    [Overload("FindPackagesByPackageFamilyName")]
    [MethodImpl]
    public extern IIterable<Package> FindPackages(string packageFamilyName);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUser(
      string userSecurityId,
      string packageFamilyName);

    [Overload("FindPackageByUserSecurityIdPackageFullName")]
    [MethodImpl]
    public extern Package FindPackageForUser(string userSecurityId, string packageFullName);

    [Overload("RemovePackageWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName,
      RemovalOptions removalOptions);

    [RemoteAsync]
    [Overload("StagePackageWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFullNameAsync(
      string mainPackageFullName,
      IIterable<string> dependencyPackageFullNames,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackagesWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    [Overload("FindPackagesByNamePublisherWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesWithPackageTypes(
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesWithPackageTypes(
      string packageFamilyName,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageFamilyName,
      PackageTypes packageTypes);

    [RemoteAsync]
    [Overload("StageUserDataAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageVolume> AddPackageVolumeAsync(
      string packageStorePath);

    [RemoteAsync]
    [Overload("AddPackageToVolumeAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [MethodImpl]
    public extern void ClearPackageStatus(string packageFullName, PackageStatus status);

    [RemoteAsync]
    [Overload("RegisterPackageWithAppDataVolumeAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume);

    [Overload("FindPackageVolumeByName")]
    [MethodImpl]
    public extern PackageVolume FindPackageVolume(string volumeName);

    [MethodImpl]
    public extern IIterable<PackageVolume> FindPackageVolumes();

    [MethodImpl]
    public extern PackageVolume GetDefaultPackageVolume();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> MovePackageToVolumeAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageVolumeAsync(
      PackageVolume volume);

    [MethodImpl]
    public extern void SetDefaultPackageVolume(PackageVolume volume);

    [MethodImpl]
    public extern void SetPackageStatus(string packageFullName, PackageStatus status);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOfflineAsync(
      PackageVolume packageVolume);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOnlineAsync(
      PackageVolume packageVolume);

    [RemoteAsync]
    [Overload("StagePackageToVolumeAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [Overload("StageUserDataWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<PackageVolume>> GetPackageVolumesAsync();

    [RemoteAsync]
    [DefaultOverload]
    [Overload("AddPackageToVolumeAndOptionalPackagesAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [RemoteAsync]
    [Overload("StagePackageToVolumeAndOptionalPackagesAsync")]
    [DefaultOverload]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [Overload("RegisterPackageByFamilyNameAndOptionalPackagesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFamilyNameAsync(
      string mainPackageFamilyName,
      IIterable<string> dependencyPackageFamilyNames,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume,
      IIterable<string> optionalPackageFamilyNames);

    public extern PackageManagerDebugSettings DebugSettings { [MethodImpl] get; }
  }
}
