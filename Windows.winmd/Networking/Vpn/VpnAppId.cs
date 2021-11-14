// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnAppId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVpnAppIdFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  public sealed class VpnAppId : IVpnAppId
  {
    [MethodImpl]
    public extern VpnAppId(VpnAppIdType type, string value);

    public extern VpnAppIdType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
