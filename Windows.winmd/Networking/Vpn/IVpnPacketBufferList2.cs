// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPacketBufferList2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(1048236005, 59934, 18474, 141, 152, 192, 101, 245, 125, 137, 234)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnPacketBufferList))]
  internal interface IVpnPacketBufferList2 : IIterable<VpnPacketBuffer>
  {
    void AddLeadingPacket(VpnPacketBuffer nextVpnPacketBuffer);

    VpnPacketBuffer RemoveLeadingPacket();

    void AddTrailingPacket(VpnPacketBuffer nextVpnPacketBuffer);

    VpnPacketBuffer RemoveTrailingPacket();
  }
}
