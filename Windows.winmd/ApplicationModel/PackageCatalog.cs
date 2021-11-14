// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IPackageCatalogStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class PackageCatalog : IPackageCatalog, IPackageCatalog2
  {
    public extern event TypedEventHandler<PackageCatalog, PackageStagingEventArgs> PackageStaging;

    public extern event TypedEventHandler<PackageCatalog, PackageInstallingEventArgs> PackageInstalling;

    public extern event TypedEventHandler<PackageCatalog, PackageUpdatingEventArgs> PackageUpdating;

    public extern event TypedEventHandler<PackageCatalog, PackageUninstallingEventArgs> PackageUninstalling;

    public extern event TypedEventHandler<PackageCatalog, PackageStatusChangedEventArgs> PackageStatusChanged;

    public extern event TypedEventHandler<PackageCatalog, PackageContentGroupStagingEventArgs> PackageContentGroupStaging;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageCatalogAddOptionalPackageResult> AddOptionalPackageAsync(
      string optionalPackageFamilyName);

    [MethodImpl]
    public static extern PackageCatalog OpenForCurrentPackage();

    [MethodImpl]
    public static extern PackageCatalog OpenForCurrentUser();
  }
}
