// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageTypes
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
  public enum PackageTypes : uint
  {
    None = 0,
    Main = 1,
    Framework = 2,
    Resource = 4,
    Bundle = 8,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Xap = 16, // 0x00000010
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Optional = 32, // 0x00000020
  }
}
