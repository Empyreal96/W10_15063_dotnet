// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageCatalog))]
  [Guid(587872081, 40419, 17477, 190, 116, 145, 251, 50, 90, 190, 254)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageCatalog
  {
    event TypedEventHandler<PackageCatalog, PackageStagingEventArgs> PackageStaging;

    event TypedEventHandler<PackageCatalog, PackageInstallingEventArgs> PackageInstalling;

    event TypedEventHandler<PackageCatalog, PackageUpdatingEventArgs> PackageUpdating;

    event TypedEventHandler<PackageCatalog, PackageUninstallingEventArgs> PackageUninstalling;

    event TypedEventHandler<PackageCatalog, PackageStatusChangedEventArgs> PackageStatusChanged;
  }
}
