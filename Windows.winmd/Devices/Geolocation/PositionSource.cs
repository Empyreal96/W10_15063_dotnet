// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.PositionSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PositionSource
  {
    Cellular,
    Satellite,
    WiFi,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] IPAddress,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Unknown,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Default,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Obfuscated,
  }
}
