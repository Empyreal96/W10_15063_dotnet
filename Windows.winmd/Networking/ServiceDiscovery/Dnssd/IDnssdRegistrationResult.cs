// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdRegistrationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1031301842, 58886, 21328, 115, 234, 126, 151, 240, 102, 22, 47)]
  [ExclusiveTo(typeof (DnssdRegistrationResult))]
  internal interface IDnssdRegistrationResult
  {
    DnssdRegistrationStatus Status { get; }

    HostName IPAddress { get; }

    bool HasInstanceNameChanged { get; }
  }
}
