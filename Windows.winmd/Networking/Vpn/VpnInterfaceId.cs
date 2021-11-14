// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnInterfaceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IVpnInterfaceIdFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnInterfaceId : IVpnInterfaceId
  {
    [MethodImpl]
    public extern VpnInterfaceId([Range(0, 8)] byte[] address);

    [MethodImpl]
    public extern void GetAddressInfo(out byte[] id);
  }
}
