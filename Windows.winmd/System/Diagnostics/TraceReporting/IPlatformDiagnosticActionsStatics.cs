// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.IPlatformDiagnosticActionsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlatformDiagnosticActions))]
  [Guid(3239337210, 37522, 16999, 137, 10, 158, 163, 237, 7, 35, 18)]
  internal interface IPlatformDiagnosticActionsStatics
  {
    bool IsScenarioEnabled(Guid scenarioId);

    bool TryEscalateScenario(
      Guid scenarioId,
      PlatformDiagnosticEscalationType escalationType,
      string outputDirectory,
      bool timestampOutputDirectory,
      bool forceEscalationUpload,
      IMapView<string, string> triggers);

    PlatformDiagnosticActionState DownloadLatestSettingsForNamespace(
      string partner,
      string feature,
      bool isScenarioNamespace,
      bool downloadOverCostedNetwork,
      bool downloadOverBattery);

    IVectorView<Guid> GetActiveScenarioList();

    PlatformDiagnosticActionState ForceUpload(
      PlatformDiagnosticEventBufferLatencies latency,
      bool uploadOverCostedNetwork,
      bool uploadOverBattery);

    PlatformDiagnosticTraceSlotState IsTraceRunning(
      PlatformDiagnosticTraceSlotType slotType,
      Guid scenarioId,
      ulong traceProfileHash);

    PlatformDiagnosticTraceRuntimeInfo GetActiveTraceRuntime(
      PlatformDiagnosticTraceSlotType slotType);

    IVectorView<PlatformDiagnosticTraceInfo> GetKnownTraceList(
      PlatformDiagnosticTraceSlotType slotType);
  }
}
