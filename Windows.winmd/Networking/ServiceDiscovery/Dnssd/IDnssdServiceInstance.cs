// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdServiceInstance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Networking.Sockets;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [Guid(3796294526, 39077, 19617, 185, 228, 194, 83, 211, 60, 53, 255)]
  [ExclusiveTo(typeof (DnssdServiceInstance))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDnssdServiceInstance
  {
    string DnssdServiceInstanceName { get; set; }

    HostName HostName { get; set; }

    ushort Port { get; set; }

    ushort Priority { get; set; }

    ushort Weight { get; set; }

    IMap<string, string> TextAttributes { get; }

    [RemoteAsync]
    [Overload("RegisterStreamSocketListenerAsync1")]
    IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket);

    [Overload("RegisterStreamSocketListenerAsync2")]
    [RemoteAsync]
    IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket,
      NetworkAdapter adapter);

    [RemoteAsync]
    [Overload("RegisterDatagramSocketAsync1")]
    IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket);

    [Overload("RegisterDatagramSocketAsync2")]
    [RemoteAsync]
    IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket,
      NetworkAdapter adapter);
  }
}
