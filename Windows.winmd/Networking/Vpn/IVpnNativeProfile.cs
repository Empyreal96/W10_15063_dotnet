// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNativeProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnNativeProfile))]
  [Guid(2762924702, 25623, 17203, 152, 66, 240, 166, 109, 182, 152, 2)]
  internal interface IVpnNativeProfile : IVpnProfile
  {
    IVector<string> Servers { get; }

    VpnRoutingPolicyType RoutingPolicyType { get; set; }

    VpnNativeProtocolType NativeProtocolType { get; set; }

    VpnAuthenticationMethod UserAuthenticationMethod { get; set; }

    VpnAuthenticationMethod TunnelAuthenticationMethod { get; set; }

    string EapConfiguration { get; set; }
  }
}
