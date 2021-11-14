// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnTrafficFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Activatable(typeof (IVpnTrafficFilterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnTrafficFilter : IVpnTrafficFilter
  {
    [MethodImpl]
    public extern VpnTrafficFilter(VpnAppId appId);

    public extern VpnAppId AppId { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> AppClaims { [MethodImpl] get; }

    public extern VpnIPProtocol Protocol { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> LocalPortRanges { [MethodImpl] get; }

    public extern IVector<string> RemotePortRanges { [MethodImpl] get; }

    public extern IVector<string> LocalAddressRanges { [MethodImpl] get; }

    public extern IVector<string> RemoteAddressRanges { [MethodImpl] get; }

    public extern VpnRoutingPolicyType RoutingPolicyType { [MethodImpl] get; [MethodImpl] set; }
  }
}
