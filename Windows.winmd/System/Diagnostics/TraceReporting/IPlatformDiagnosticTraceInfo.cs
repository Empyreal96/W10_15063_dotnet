// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.IPlatformDiagnosticTraceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4168150423, 54679, 19447, 136, 220, 207, 92, 125, 194, 161, 210)]
  [ExclusiveTo(typeof (PlatformDiagnosticTraceInfo))]
  internal interface IPlatformDiagnosticTraceInfo
  {
    Guid ScenarioId { get; }

    ulong ProfileHash { get; }

    bool IsExclusive { get; }

    bool IsAutoLogger { get; }

    long MaxTraceDurationFileTime { get; }

    PlatformDiagnosticTracePriority Priority { get; }
  }
}
