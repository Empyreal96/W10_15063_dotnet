// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPacketBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Vpn
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVpnPacketBufferFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VpnPacketBuffer : IVpnPacketBuffer, IVpnPacketBuffer2
  {
    [MethodImpl]
    public extern VpnPacketBuffer(VpnPacketBuffer parentBuffer, uint offset, uint length);

    public extern Buffer Buffer { [MethodImpl] get; }

    public extern VpnPacketBufferStatus Status { [MethodImpl] set; [MethodImpl] get; }

    public extern uint TransportAffinity { [MethodImpl] set; [MethodImpl] get; }

    public extern VpnAppId AppId { [MethodImpl] get; }
  }
}
