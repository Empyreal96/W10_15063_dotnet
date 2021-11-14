// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdServiceInstanceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [Guid(1823498657, 50296, 17201, 150, 132, 74, 242, 24, 108, 10, 43)]
  [ExclusiveTo(typeof (DnssdServiceInstance))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDnssdServiceInstanceFactory
  {
    DnssdServiceInstance Create(
      string dnssdServiceInstanceName,
      HostName hostName,
      ushort port);
  }
}
