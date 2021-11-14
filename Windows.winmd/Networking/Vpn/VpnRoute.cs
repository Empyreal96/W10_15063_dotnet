// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnRoute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVpnRouteFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnRoute : IVpnRoute
  {
    [MethodImpl]
    public extern VpnRoute(HostName address, [Range(0, 128)] byte prefixSize);

    public extern HostName Address { [MethodImpl] set; [MethodImpl] get; }

    public extern byte PrefixSize { [MethodImpl] [param: Range(0, 128)] set; [MethodImpl] get; }
  }
}
