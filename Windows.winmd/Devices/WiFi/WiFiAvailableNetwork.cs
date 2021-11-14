// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiAvailableNetwork
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Devices.WiFi
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiAvailableNetwork : IWiFiAvailableNetwork
  {
    public extern TimeSpan Uptime { [MethodImpl] get; }

    public extern string Ssid { [MethodImpl] get; }

    public extern string Bssid { [MethodImpl] get; }

    public extern int ChannelCenterFrequencyInKilohertz { [MethodImpl] get; }

    public extern double NetworkRssiInDecibelMilliwatts { [MethodImpl] get; }

    public extern byte SignalBars { [MethodImpl] get; }

    public extern WiFiNetworkKind NetworkKind { [MethodImpl] get; }

    public extern WiFiPhyKind PhyKind { [MethodImpl] get; }

    public extern NetworkSecuritySettings SecuritySettings { [MethodImpl] get; }

    public extern TimeSpan BeaconInterval { [MethodImpl] get; }

    public extern bool IsWiFiDirect { [MethodImpl] get; }
  }
}
