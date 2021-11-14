// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessCpuUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessCpuUsageReport))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2322439340, 14727, 20015, 161, 25, 107, 95, 162, 20, 241, 180)]
  internal interface IProcessCpuUsageReport
  {
    TimeSpan KernelTime { get; }

    TimeSpan UserTime { get; }
  }
}
