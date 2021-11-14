﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnDomainNameInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(621263733, 655, 18056, 141, 58, 196, 83, 29, 243, 125, 168)]
  public interface IVpnDomainNameInfoFactory
  {
    VpnDomainNameInfo CreateVpnDomainNameInfo(
      string name,
      VpnDomainNameType nameType,
      IIterable<HostName> dnsServerList,
      IIterable<HostName> proxyServerList);
  }
}
