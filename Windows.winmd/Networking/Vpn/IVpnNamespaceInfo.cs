// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNamespaceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(820902723, 17487, 17605, 129, 103, 163, 90, 145, 241, 175, 148)]
  [ExclusiveTo(typeof (VpnNamespaceInfo))]
  internal interface IVpnNamespaceInfo
  {
    string Namespace { set; get; }

    IVector<HostName> DnsServers { set; get; }

    IVector<HostName> WebProxyServers { set; get; }
  }
}
