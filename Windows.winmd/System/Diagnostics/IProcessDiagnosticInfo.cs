// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiagnosticInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessDiagnosticInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3895504971, 12302, 20198, 160, 171, 91, 95, 82, 49, 180, 52)]
  internal interface IProcessDiagnosticInfo
  {
    uint ProcessId { get; }

    string ExecutableFileName { get; }

    ProcessDiagnosticInfo Parent { get; }

    DateTime ProcessStartTime { get; }

    ProcessDiskUsage DiskUsage { get; }

    ProcessMemoryUsage MemoryUsage { get; }

    ProcessCpuUsage CpuUsage { get; }
  }
}
