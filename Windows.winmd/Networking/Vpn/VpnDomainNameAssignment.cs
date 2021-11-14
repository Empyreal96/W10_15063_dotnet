// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnDomainNameAssignment
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnDomainNameAssignment : IVpnDomainNameAssignment
  {
    [MethodImpl]
    public extern VpnDomainNameAssignment();

    public extern IVector<VpnDomainNameInfo> DomainNameList { [MethodImpl] get; }

    public extern Uri ProxyAutoConfigurationUri { [MethodImpl] set; [MethodImpl] get; }
  }
}
