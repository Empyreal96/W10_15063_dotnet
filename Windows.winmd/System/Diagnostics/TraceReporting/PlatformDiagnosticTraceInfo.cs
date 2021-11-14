// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PlatformDiagnosticTraceInfo : IPlatformDiagnosticTraceInfo
  {
    public extern Guid ScenarioId { [MethodImpl] get; }

    public extern ulong ProfileHash { [MethodImpl] get; }

    public extern bool IsExclusive { [MethodImpl] get; }

    public extern bool IsAutoLogger { [MethodImpl] get; }

    public extern long MaxTraceDurationFileTime { [MethodImpl] get; }

    public extern PlatformDiagnosticTracePriority Priority { [MethodImpl] get; }
  }
}
