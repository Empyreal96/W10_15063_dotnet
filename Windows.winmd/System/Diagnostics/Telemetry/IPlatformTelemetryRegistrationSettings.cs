// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.IPlatformTelemetryRegistrationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2174387586, 51737, 16734, 187, 121, 156, 34, 75, 250, 58, 115)]
  [ExclusiveTo(typeof (PlatformTelemetryRegistrationSettings))]
  internal interface IPlatformTelemetryRegistrationSettings
  {
    uint StorageSize { get; set; }

    uint UploadQuotaSize { get; set; }
  }
}
