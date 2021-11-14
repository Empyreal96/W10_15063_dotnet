// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPacketBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Vpn
{
  [Guid(3271070204, 19804, 19043, 183, 13, 78, 48, 126, 172, 206, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnPacketBuffer))]
  internal interface IVpnPacketBuffer
  {
    Buffer Buffer { get; }

    VpnPacketBufferStatus Status { set; get; }

    uint TransportAffinity { set; get; }
  }
}
