// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnTrafficFilterAssignment
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
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnTrafficFilterAssignment : IVpnTrafficFilterAssignment
  {
    [MethodImpl]
    public extern VpnTrafficFilterAssignment();

    public extern IVector<VpnTrafficFilter> TrafficFilterList { [MethodImpl] get; }

    public extern bool AllowOutbound { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowInbound { [MethodImpl] get; [MethodImpl] set; }
  }
}
