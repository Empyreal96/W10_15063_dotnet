// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPlugInProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class VpnPlugInProfile : IVpnPlugInProfile, IVpnProfile, IVpnPlugInProfile2
  {
    [MethodImpl]
    public extern VpnPlugInProfile();

    public extern IVector<Uri> ServerUris { [MethodImpl] get; }

    public extern string CustomConfiguration { [MethodImpl] get; [MethodImpl] set; }

    public extern string VpnPluginPackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string ProfileName { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<VpnAppId> AppTriggers { [MethodImpl] get; }

    public extern IVector<VpnRoute> Routes { [MethodImpl] get; }

    public extern IVector<VpnDomainNameInfo> DomainNameInfoList { [MethodImpl] get; }

    public extern IVector<VpnTrafficFilter> TrafficFilters { [MethodImpl] get; }

    public extern bool RememberCredentials { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AlwaysOn { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RequireVpnClientAppUI { [MethodImpl] get; [MethodImpl] set; }

    public extern VpnManagementConnectionStatus ConnectionStatus { [MethodImpl] get; }
  }
}
