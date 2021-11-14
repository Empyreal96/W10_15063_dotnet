// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.IPackageInstallResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Management.Deployment;

namespace Windows.Phone.Management.Deployment
{
  [WebHostHidden]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (PackageInstallResult))]
  [Guid(870903509, 3966, 17523, 150, 124, 125, 110, 28, 14, 125, 225)]
  internal interface IPackageInstallResult
  {
    string ProductId { get; }

    PackageInstallState InstallState { get; }
  }
}
