// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PackageStatus : IPackageStatus, IPackageStatus2
  {
    [MethodImpl]
    public extern bool VerifyIsOK();

    public extern bool NotAvailable { [MethodImpl] get; }

    public extern bool PackageOffline { [MethodImpl] get; }

    public extern bool DataOffline { [MethodImpl] get; }

    public extern bool Disabled { [MethodImpl] get; }

    public extern bool NeedsRemediation { [MethodImpl] get; }

    public extern bool LicenseIssue { [MethodImpl] get; }

    public extern bool Modified { [MethodImpl] get; }

    public extern bool Tampered { [MethodImpl] get; }

    public extern bool DependencyIssue { [MethodImpl] get; }

    public extern bool Servicing { [MethodImpl] get; }

    public extern bool DeploymentInProgress { [MethodImpl] get; }

    public extern bool IsPartiallyStaged { [MethodImpl] get; }
  }
}
