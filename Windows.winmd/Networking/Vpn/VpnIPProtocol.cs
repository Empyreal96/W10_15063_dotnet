// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnIPProtocol
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnIPProtocol
  {
    None = 0,
    Icmp = 1,
    Igmp = 2,
    Tcp = 6,
    Udp = 17, // 0x00000011
    Ipv6Icmp = 58, // 0x0000003A
    Pgm = 113, // 0x00000071
  }
}
