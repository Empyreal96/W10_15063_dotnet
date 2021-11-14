// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.IPackageInstallResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [WebHostHidden]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(1900665097, 16377, 16877, 167, 23, 43, 198, 95, 252, 97, 210)]
  [ExclusiveTo(typeof (PackageInstallResult))]
  internal interface IPackageInstallResult2
  {
    string ErrorText { get; }
  }
}
