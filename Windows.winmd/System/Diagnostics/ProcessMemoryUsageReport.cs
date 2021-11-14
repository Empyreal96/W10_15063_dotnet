// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessMemoryUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProcessMemoryUsageReport : IProcessMemoryUsageReport
  {
    public extern ulong NonPagedPoolSizeInBytes { [MethodImpl] get; }

    public extern uint PageFaultCount { [MethodImpl] get; }

    public extern ulong PageFileSizeInBytes { [MethodImpl] get; }

    public extern ulong PagedPoolSizeInBytes { [MethodImpl] get; }

    public extern ulong PeakNonPagedPoolSizeInBytes { [MethodImpl] get; }

    public extern ulong PeakPageFileSizeInBytes { [MethodImpl] get; }

    public extern ulong PeakPagedPoolSizeInBytes { [MethodImpl] get; }

    public extern ulong PeakVirtualMemorySizeInBytes { [MethodImpl] get; }

    public extern ulong PeakWorkingSetSizeInBytes { [MethodImpl] get; }

    public extern ulong PrivatePageCount { [MethodImpl] get; }

    public extern ulong VirtualMemorySizeInBytes { [MethodImpl] get; }

    public extern ulong WorkingSetSizeInBytes { [MethodImpl] get; }
  }
}
