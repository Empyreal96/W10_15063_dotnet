// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalog2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageCatalog))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2527464502, 36855, 17220, 182, 191, 238, 100, 194, 32, 126, 210)]
  internal interface IPackageCatalog2
  {
    event TypedEventHandler<PackageCatalog, PackageContentGroupStagingEventArgs> PackageContentGroupStaging;

    [RemoteAsync]
    IAsyncOperation<PackageCatalogAddOptionalPackageResult> AddOptionalPackageAsync(
      string optionalPackageFamilyName);
  }
}
