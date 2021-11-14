// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNamespaceInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(3409876250, 45262, 17451, 172, 187, 95, 153, 178, 2, 195, 28)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnNamespaceInfoFactory
  {
    VpnNamespaceInfo CreateVpnNamespaceInfo(
      string name,
      IVector<HostName> dnsServerList,
      IVector<HostName> proxyServerList);
  }
}
