// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageUserInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageUserInformation))]
  [Guid(4130878499, 64009, 19644, 144, 85, 21, 202, 39, 94, 46, 126)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageUserInformation
  {
    string UserSecurityId { get; }

    PackageInstallState InstallState { get; }
  }
}
