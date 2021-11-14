// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DnssdServiceWatcher : IDnssdServiceWatcher
  {
    public extern event TypedEventHandler<DnssdServiceWatcher, DnssdServiceInstance> Added;

    public extern event TypedEventHandler<DnssdServiceWatcher, object> EnumerationCompleted;

    public extern event TypedEventHandler<DnssdServiceWatcher, object> Stopped;

    public extern DnssdServiceWatcherStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();
  }
}
