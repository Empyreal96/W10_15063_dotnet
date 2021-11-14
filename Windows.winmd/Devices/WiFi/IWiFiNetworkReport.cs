// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiNetworkReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2502221522, 22801, 17502, 129, 148, 190, 79, 26, 112, 72, 149)]
  [ExclusiveTo(typeof (WiFiNetworkReport))]
  internal interface IWiFiNetworkReport
  {
    DateTime Timestamp { get; }

    IVectorView<WiFiAvailableNetwork> AvailableNetworks { get; }
  }
}
