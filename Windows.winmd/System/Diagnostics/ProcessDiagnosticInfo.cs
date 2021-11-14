// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessDiagnosticInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IProcessDiagnosticInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ProcessDiagnosticInfo : IProcessDiagnosticInfo
  {
    public extern uint ProcessId { [MethodImpl] get; }

    public extern string ExecutableFileName { [MethodImpl] get; }

    public extern ProcessDiagnosticInfo Parent { [MethodImpl] get; }

    public extern DateTime ProcessStartTime { [MethodImpl] get; }

    public extern ProcessDiskUsage DiskUsage { [MethodImpl] get; }

    public extern ProcessMemoryUsage MemoryUsage { [MethodImpl] get; }

    public extern ProcessCpuUsage CpuUsage { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVectorView<ProcessDiagnosticInfo> GetForProcesses();

    [MethodImpl]
    public static extern ProcessDiagnosticInfo GetForCurrentProcess();
  }
}
