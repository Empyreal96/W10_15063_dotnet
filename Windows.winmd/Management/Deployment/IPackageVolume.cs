// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageVolume
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PackageVolume))]
  [Guid(3475403459, 6720, 17488, 151, 57, 42, 206, 46, 137, 136, 83)]
  internal interface IPackageVolume
  {
    bool IsOffline { get; }

    bool IsSystemVolume { get; }

    string MountPoint { get; }

    string Name { get; }

    string PackageStorePath { get; }

    bool SupportsHardLinks { get; }

    [Overload("FindPackages")]
    IVector<Package> FindPackages();

    [Overload("FindPackagesByNamePublisher")]
    IVector<Package> FindPackages(string packageName, string packagePublisher);

    [Overload("FindPackagesByPackageFamilyName")]
    IVector<Package> FindPackages(string packageFamilyName);

    [Overload("FindPackagesWithPackageTypes")]
    IVector<Package> FindPackagesWithPackageTypes(PackageTypes packageTypes);

    [Overload("FindPackagesByNamePublisherWithPackagesTypes")]
    IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes,
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes,
      string packageFamilyName);

    [Overload("FindPackageByPackageFullName")]
    IVector<Package> FindPackage(string packageFullName);

    [Overload("FindPackagesByUserSecurityId")]
    IVector<Package> FindPackagesForUser(string userSecurityId);

    [Overload("FindPackagesByUserSecurityIdNamePublisher")]
    IVector<Package> FindPackagesForUser(
      string userSecurityId,
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
    IVector<Package> FindPackagesForUser(
      string userSecurityId,
      string packageFamilyName);

    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes,
      string packageName,
      string packagePublisher);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackagesTypes")]
    IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes,
      string packageFamilyName);

    [Overload("FindPackageByUserSecurityIdPackageFullName")]
    IVector<Package> FindPackageForUser(string userSecurityId, string packageFullName);
  }
}
