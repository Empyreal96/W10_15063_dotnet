// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAvailableNetwork
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Devices.WiFi
{
  [ExclusiveTo(typeof (WiFiAvailableNetwork))]
  [Guid(652829254, 6206, 18180, 152, 38, 113, 180, 162, 240, 246, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiAvailableNetwork
  {
    TimeSpan Uptime { get; }

    string Ssid { get; }

    string Bssid { get; }

    int ChannelCenterFrequencyInKilohertz { get; }

    double NetworkRssiInDecibelMilliwatts { get; }

    byte SignalBars { get; }

    WiFiNetworkKind NetworkKind { get; }

    WiFiPhyKind PhyKind { get; }

    NetworkSecuritySettings SecuritySettings { get; }

    TimeSpan BeaconInterval { get; }

    bool IsWiFiDirect { get; }
  }
}
