// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PackageStatus))]
  [Guid(1608994673, 41829, 19465, 160, 45, 4, 109, 82, 94, 161, 218)]
  internal interface IPackageStatus
  {
    bool VerifyIsOK();

    bool NotAvailable { get; }

    bool PackageOffline { get; }

    bool DataOffline { get; }

    bool Disabled { get; }

    bool NeedsRemediation { get; }

    bool LicenseIssue { get; }

    bool Modified { get; }

    bool Tampered { get; }

    bool DependencyIssue { get; }

    bool Servicing { get; }

    bool DeploymentInProgress { get; }
  }
}
