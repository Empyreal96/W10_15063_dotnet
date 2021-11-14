// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnRouteAssignment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnRouteAssignment))]
  [Guid(3680820770, 52793, 19062, 149, 80, 246, 16, 57, 248, 14, 72)]
  internal interface IVpnRouteAssignment
  {
    IVector<VpnRoute> Ipv4InclusionRoutes { set; get; }

    IVector<VpnRoute> Ipv6InclusionRoutes { set; get; }

    IVector<VpnRoute> Ipv4ExclusionRoutes { set; get; }

    IVector<VpnRoute> Ipv6ExclusionRoutes { set; get; }

    bool ExcludeLocalSubnets { set; get; }
  }
}
