// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageInstallState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PackageInstallState
  {
    NotInstalled = 0,
    Staged = 1,
    Installed = 2,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] Paused = 6,
  }
}
