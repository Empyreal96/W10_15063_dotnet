// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.PlatformTelemetryRegistrationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlatformTelemetryRegistrationSettings : IPlatformTelemetryRegistrationSettings
  {
    [MethodImpl]
    public extern PlatformTelemetryRegistrationSettings();

    public extern uint StorageSize { [MethodImpl] get; [MethodImpl] set; }

    public extern uint UploadQuotaSize { [MethodImpl] get; [MethodImpl] set; }
  }
}
