// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnDomainNameInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IVpnDomainNameInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnDomainNameInfo : IVpnDomainNameInfo, IVpnDomainNameInfo2
  {
    [MethodImpl]
    public extern VpnDomainNameInfo(
      string name,
      VpnDomainNameType nameType,
      IIterable<HostName> dnsServerList,
      IIterable<HostName> proxyServerList);

    public extern HostName DomainName { [MethodImpl] set; [MethodImpl] get; }

    public extern VpnDomainNameType DomainNameType { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<HostName> DnsServers { [MethodImpl] get; }

    public extern IVector<HostName> WebProxyServers { [MethodImpl] get; }

    public extern IVector<Uri> WebProxyUris { [MethodImpl] get; }
  }
}
