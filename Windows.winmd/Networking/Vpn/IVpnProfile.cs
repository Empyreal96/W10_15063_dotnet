// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2020980561, 45271, 17371, 138, 147, 211, 254, 36, 121, 229, 106)]
  public interface IVpnProfile
  {
    string ProfileName { get; set; }

    IVector<VpnAppId> AppTriggers { get; }

    IVector<VpnRoute> Routes { get; }

    IVector<VpnDomainNameInfo> DomainNameInfoList { get; }

    IVector<VpnTrafficFilter> TrafficFilters { get; }

    bool RememberCredentials { get; set; }

    bool AlwaysOn { get; set; }
  }
}
