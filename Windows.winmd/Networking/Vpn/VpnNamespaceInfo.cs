// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnNamespaceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IVpnNamespaceInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnNamespaceInfo : IVpnNamespaceInfo
  {
    [MethodImpl]
    public extern VpnNamespaceInfo(
      string name,
      IVector<HostName> dnsServerList,
      IVector<HostName> proxyServerList);

    public extern string Namespace { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<HostName> DnsServers { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<HostName> WebProxyServers { [MethodImpl] set; [MethodImpl] get; }
  }
}
