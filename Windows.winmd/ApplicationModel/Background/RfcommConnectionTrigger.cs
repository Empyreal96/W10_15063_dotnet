// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.RfcommConnectionTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RfcommConnectionTrigger : IRfcommConnectionTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern RfcommConnectionTrigger();

    public extern RfcommInboundConnectionInformation InboundConnection { [MethodImpl] get; }

    public extern RfcommOutboundConnectionInformation OutboundConnection { [MethodImpl] get; }

    public extern bool AllowMultipleConnections { [MethodImpl] get; [MethodImpl] set; }

    public extern SocketProtectionLevel ProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern HostName RemoteHostName { [MethodImpl] get; [MethodImpl] set; }
  }
}
