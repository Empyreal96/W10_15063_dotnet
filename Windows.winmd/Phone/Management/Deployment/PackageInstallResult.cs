// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.PackageInstallResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;

namespace Windows.Phone.Management.Deployment
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [WebHostHidden]
  public sealed class PackageInstallResult : IPackageInstallResult, IPackageInstallResult2
  {
    public extern string ProductId { [MethodImpl] get; }

    public extern PackageInstallState InstallState { [MethodImpl] get; }

    public extern string ErrorText { [MethodImpl] get; }
  }
}
