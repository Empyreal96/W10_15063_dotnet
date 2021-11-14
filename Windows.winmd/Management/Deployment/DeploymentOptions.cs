// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.DeploymentOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DeploymentOptions : uint
  {
    None = 0,
    ForceApplicationShutdown = 1,
    DevelopmentMode = 2,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InstallAllResources = 32, // 0x00000020
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ForceTargetApplicationShutdown = 64, // 0x00000040
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] RequiredContentGroupOnly = 256, // 0x00000100
  }
}
