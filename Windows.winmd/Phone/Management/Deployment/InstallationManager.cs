// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.InstallationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;

namespace Windows.Phone.Management.Deployment
{
  [Static(typeof (IInstallationManagerStatics), 65536, "Windows.Phone.PhoneContract")]
  [WebHostHidden]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Static(typeof (IInstallationManagerStatics2), 65536, "Windows.Phone.PhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class InstallationManager
  {
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<PackageInstallResult, uint> RemovePackageAsync(
      string packageFullName,
      RemovalOptions removalOptions);

    [MethodImpl]
    public static extern IAsyncOperationWithProgress<PackageInstallResult, uint> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackagesByNamePublisher")]
    [MethodImpl]
    public static extern IIterable<Package> FindPackages(
      string packageName,
      string packagePublisher);

    [Overload("AddPackageAsync")]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<PackageInstallResult, uint> AddPackageAsync(
      string title,
      Uri sourceLocation);

    [Overload("AddPackagePreloadedAsync")]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<PackageInstallResult, uint> AddPackageAsync(
      string title,
      Uri sourceLocation,
      string instanceId,
      string offerId,
      Uri license);

    [MethodImpl]
    public static extern IIterable<IAsyncOperationWithProgress<PackageInstallResult, uint>> GetPendingPackageInstalls();

    [MethodImpl]
    public static extern IIterable<Package> FindPackagesForCurrentPublisher();

    [Overload("FindPackages")]
    [MethodImpl]
    public static extern IIterable<Package> FindPackages();
  }
}
