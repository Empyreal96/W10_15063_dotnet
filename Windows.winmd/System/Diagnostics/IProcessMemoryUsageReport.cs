// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessMemoryUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [Guid(3267853498, 6481, 18053, 133, 50, 126, 116, 158, 207, 142, 235)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessMemoryUsageReport))]
  internal interface IProcessMemoryUsageReport
  {
    ulong NonPagedPoolSizeInBytes { get; }

    uint PageFaultCount { get; }

    ulong PageFileSizeInBytes { get; }

    ulong PagedPoolSizeInBytes { get; }

    ulong PeakNonPagedPoolSizeInBytes { get; }

    ulong PeakPageFileSizeInBytes { get; }

    ulong PeakPagedPoolSizeInBytes { get; }

    ulong PeakVirtualMemorySizeInBytes { get; }

    ulong PeakWorkingSetSizeInBytes { get; }

    ulong PrivatePageCount { get; }

    ulong VirtualMemorySizeInBytes { get; }

    ulong WorkingSetSizeInBytes { get; }
  }
}
