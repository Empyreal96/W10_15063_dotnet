// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class DatagramSocketControl : 
    IDatagramSocketControl,
    IDatagramSocketControl2,
    IDatagramSocketControl3
  {
    public extern SocketQualityOfService QualityOfService { [MethodImpl] get; [MethodImpl] set; }

    public extern byte OutboundUnicastHopLimit { [MethodImpl] get; [MethodImpl] set; }

    public extern uint InboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DontFragment { [MethodImpl] get; [MethodImpl] set; }

    public extern bool MulticastOnly { [MethodImpl] get; [MethodImpl] set; }
  }
}
