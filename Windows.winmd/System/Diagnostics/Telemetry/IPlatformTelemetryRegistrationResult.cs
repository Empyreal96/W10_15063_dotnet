// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.IPlatformTelemetryRegistrationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [Guid(1300568235, 8850, 18877, 161, 90, 61, 113, 210, 20, 81, 18)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlatformTelemetryRegistrationResult))]
  internal interface IPlatformTelemetryRegistrationResult
  {
    PlatformTelemetryRegistrationStatus Status { get; }
  }
}
