// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.IPlatformTelemetryClientStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [ExclusiveTo(typeof (PlatformTelemetryClient))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2616455773, 54723, 20202, 141, 190, 156, 141, 187, 13, 157, 143)]
  internal interface IPlatformTelemetryClientStatics
  {
    [Overload("Register")]
    PlatformTelemetryRegistrationResult Register(string id);

    [Overload("RegisterWithSettings")]
    PlatformTelemetryRegistrationResult Register(
      string id,
      PlatformTelemetryRegistrationSettings settings);
  }
}
