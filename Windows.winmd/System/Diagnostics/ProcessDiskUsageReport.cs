﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.ProcessDiskUsageReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProcessDiskUsageReport : IProcessDiskUsageReport
  {
    public extern long ReadOperationCount { [MethodImpl] get; }

    public extern long WriteOperationCount { [MethodImpl] get; }

    public extern long OtherOperationCount { [MethodImpl] get; }

    public extern long BytesReadCount { [MethodImpl] get; }

    public extern long BytesWrittenCount { [MethodImpl] get; }

    public extern long OtherBytesCount { [MethodImpl] get; }
  }
}
