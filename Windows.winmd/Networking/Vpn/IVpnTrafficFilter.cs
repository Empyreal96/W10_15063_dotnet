// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnTrafficFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(795417440, 27807, 18421, 172, 54, 187, 27, 4, 46, 44, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnTrafficFilter))]
  internal interface IVpnTrafficFilter
  {
    VpnAppId AppId { get; set; }

    IVector<string> AppClaims { get; }

    VpnIPProtocol Protocol { get; set; }

    IVector<string> LocalPortRanges { get; }

    IVector<string> RemotePortRanges { get; }

    IVector<string> LocalAddressRanges { get; }

    IVector<string> RemoteAddressRanges { get; }

    VpnRoutingPolicyType RoutingPolicyType { get; set; }
  }
}
