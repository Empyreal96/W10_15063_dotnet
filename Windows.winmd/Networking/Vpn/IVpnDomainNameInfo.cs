// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnDomainNameInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2905520175, 60046, 20346, 132, 62, 26, 135, 227, 46, 27, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnDomainNameInfo))]
  internal interface IVpnDomainNameInfo
  {
    HostName DomainName { set; get; }

    VpnDomainNameType DomainNameType { set; get; }

    IVector<HostName> DnsServers { get; }

    IVector<HostName> WebProxyServers { get; }
  }
}
