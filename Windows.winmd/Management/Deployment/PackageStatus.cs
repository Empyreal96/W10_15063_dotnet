// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum PackageStatus : uint
  {
    OK = 0,
    LicenseIssue = 1,
    Modified = 2,
    Tampered = 4,
    Disabled = 8,
  }
}
