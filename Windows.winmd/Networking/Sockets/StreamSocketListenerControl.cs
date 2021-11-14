// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketListenerControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StreamSocketListenerControl : 
    IStreamSocketListenerControl,
    IStreamSocketListenerControl2
  {
    public extern SocketQualityOfService QualityOfService { [MethodImpl] get; [MethodImpl] set; }

    public extern bool NoDelay { [MethodImpl] get; [MethodImpl] set; }

    public extern bool KeepAlive { [MethodImpl] get; [MethodImpl] set; }

    public extern uint OutboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    public extern byte OutboundUnicastHopLimit { [MethodImpl] get; [MethodImpl] set; }
  }
}
