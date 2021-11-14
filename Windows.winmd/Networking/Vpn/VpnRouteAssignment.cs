// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnRouteAssignment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnRouteAssignment : IVpnRouteAssignment
  {
    [MethodImpl]
    public extern VpnRouteAssignment();

    public extern IVector<VpnRoute> Ipv4InclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<VpnRoute> Ipv6InclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<VpnRoute> Ipv4ExclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<VpnRoute> Ipv6ExclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    public extern bool ExcludeLocalSubnets { [MethodImpl] set; [MethodImpl] get; }
  }
}
