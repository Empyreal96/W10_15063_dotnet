// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Static(typeof (IPlatformDiagnosticActionsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class PlatformDiagnosticActions
  {
    [MethodImpl]
    public static extern bool IsScenarioEnabled(Guid scenarioId);

    [MethodImpl]
    public static extern bool TryEscalateScenario(
      Guid scenarioId,
      PlatformDiagnosticEscalationType escalationType,
      string outputDirectory,
      bool timestampOutputDirectory,
      bool forceEscalationUpload,
      IMapView<string, string> triggers);

    [MethodImpl]
    public static extern PlatformDiagnosticActionState DownloadLatestSettingsForNamespace(
      string partner,
      string feature,
      bool isScenarioNamespace,
      bool downloadOverCostedNetwork,
      bool downloadOverBattery);

    [MethodImpl]
    public static extern IVectorView<Guid> GetActiveScenarioList();

    [MethodImpl]
    public static extern PlatformDiagnosticActionState ForceUpload(
      PlatformDiagnosticEventBufferLatencies latency,
      bool uploadOverCostedNetwork,
      bool uploadOverBattery);

    [MethodImpl]
    public static extern PlatformDiagnosticTraceSlotState IsTraceRunning(
      PlatformDiagnosticTraceSlotType slotType,
      Guid scenarioId,
      ulong traceProfileHash);

    [MethodImpl]
    public static extern PlatformDiagnosticTraceRuntimeInfo GetActiveTraceRuntime(
      PlatformDiagnosticTraceSlotType slotType);

    [MethodImpl]
    public static extern IVectorView<PlatformDiagnosticTraceInfo> GetKnownTraceList(
      PlatformDiagnosticTraceSlotType slotType);
  }
}
