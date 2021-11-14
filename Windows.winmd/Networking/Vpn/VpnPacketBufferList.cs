// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPacketBufferList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnPacketBufferList : IVpnPacketBufferList, IIterable<VpnPacketBuffer>
  {
    [MethodImpl]
    public extern void Append(VpnPacketBuffer nextVpnPacketBuffer);

    [MethodImpl]
    public extern void AddAtBegin(VpnPacketBuffer nextVpnPacketBuffer);

    [MethodImpl]
    public extern VpnPacketBuffer RemoveAtEnd();

    [MethodImpl]
    public extern VpnPacketBuffer RemoveAtBegin();

    [MethodImpl]
    public extern void Clear();

    public extern VpnPacketBufferStatus Status { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IIterator<VpnPacketBuffer> First();
  }
}
