// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.IProcessDiskUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [ExclusiveTo(typeof (ProcessDiskUsageReport))]
  [Guid(1075193853, 21341, 19487, 129, 184, 218, 84, 225, 190, 99, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProcessDiskUsageReport
  {
    long ReadOperationCount { get; }

    long WriteOperationCount { get; }

    long OtherOperationCount { get; }

    long BytesReadCount { get; }

    long BytesWrittenCount { get; }

    long OtherBytesCount { get; }
  }
}
