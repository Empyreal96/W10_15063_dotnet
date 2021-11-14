// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Networking.Sockets;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IDnssdServiceInstanceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DnssdServiceInstance : IDnssdServiceInstance, IStringable
  {
    [MethodImpl]
    public extern DnssdServiceInstance(
      string dnssdServiceInstanceName,
      HostName hostName,
      ushort port);

    public extern string DnssdServiceInstanceName { [MethodImpl] get; [MethodImpl] set; }

    public extern HostName HostName { [MethodImpl] get; [MethodImpl] set; }

    public extern ushort Port { [MethodImpl] get; [MethodImpl] set; }

    public extern ushort Priority { [MethodImpl] get; [MethodImpl] set; }

    public extern ushort Weight { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, string> TextAttributes { [MethodImpl] get; }

    [Overload("RegisterStreamSocketListenerAsync1")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket);

    [Overload("RegisterStreamSocketListenerAsync2")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket,
      NetworkAdapter adapter);

    [RemoteAsync]
    [Overload("RegisterDatagramSocketAsync1")]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket);

    [RemoteAsync]
    [Overload("RegisterDatagramSocketAsync2")]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket,
      NetworkAdapter adapter);

    [MethodImpl]
    public new extern string ToString();
  }
}
