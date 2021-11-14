// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPacketBuffer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnPacketBuffer))]
  [Guid(1717473776, 34821, 19445, 166, 25, 46, 132, 136, 46, 107, 79)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnPacketBuffer2
  {
    VpnAppId AppId { get; }
  }
}
