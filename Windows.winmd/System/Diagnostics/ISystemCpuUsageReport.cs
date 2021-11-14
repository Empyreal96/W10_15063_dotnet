// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ISystemCpuUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (SystemCpuUsageReport))]
  [Guid(740741298, 38019, 20322, 171, 87, 130, 178, 157, 151, 25, 184)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemCpuUsageReport
  {
    TimeSpan KernelTime { get; }

    TimeSpan UserTime { get; }

    TimeSpan IdleTime { get; }
  }
}
