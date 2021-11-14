// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnNamespaceAssignment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnNamespaceAssignment : IVpnNamespaceAssignment
  {
    [MethodImpl]
    public extern VpnNamespaceAssignment();

    public extern IVector<VpnNamespaceInfo> NamespaceList { [MethodImpl] set; [MethodImpl] get; }

    public extern Uri ProxyAutoConfigUri { [MethodImpl] set; [MethodImpl] get; }
  }
}
