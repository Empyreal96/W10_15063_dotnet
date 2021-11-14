// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdServiceWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DnssdServiceWatcher))]
  [Guid(3426015681, 56189, 19305, 152, 61, 198, 248, 63, 32, 86, 130)]
  internal interface IDnssdServiceWatcher
  {
    event TypedEventHandler<DnssdServiceWatcher, DnssdServiceInstance> Added;

    event TypedEventHandler<DnssdServiceWatcher, object> EnumerationCompleted;

    event TypedEventHandler<DnssdServiceWatcher, object> Stopped;

    DnssdServiceWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
