// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageVolume
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PackageVolume : IPackageVolume, IPackageVolume2
  {
    public extern bool IsOffline { [MethodImpl] get; }

    public extern bool IsSystemVolume { [MethodImpl] get; }

    public extern string MountPoint { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern string PackageStorePath { [MethodImpl] get; }

    public extern bool SupportsHardLinks { [MethodImpl] get; }

    [Overload("FindPackages")]
    [MethodImpl]
    public extern IVector<Package> FindPackages();

    [Overload("FindPackagesByNamePublisher")]
    [MethodImpl]
    public extern IVector<Package> FindPackages(
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByPackageFamilyName")]
    [MethodImpl]
    public extern IVector<Package> FindPackages(string packageFamilyName);

    [Overload("FindPackagesWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes);

    [Overload("FindPackagesByNamePublisherWithPackagesTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes,
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes,
      string packageFamilyName);

    [Overload("FindPackageByPackageFullName")]
    [MethodImpl]
    public extern IVector<Package> FindPackage(string packageFullName);

    [Overload("FindPackagesByUserSecurityId")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUser(string userSecurityId);

    [Overload("FindPackagesByUserSecurityIdNamePublisher")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUser(
      string userSecurityId,
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUser(
      string userSecurityId,
      string packageFamilyName);

    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes,
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackagesTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes,
      string packageFamilyName);

    [Overload("FindPackageByUserSecurityIdPackageFullName")]
    [MethodImpl]
    public extern IVector<Package> FindPackageForUser(
      string userSecurityId,
      string packageFullName);

    public extern bool IsFullTrustPackageSupported { [MethodImpl] get; }

    public extern bool IsAppxInstallSupported { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ulong> GetAvailableSpaceAsync();
  }
}
