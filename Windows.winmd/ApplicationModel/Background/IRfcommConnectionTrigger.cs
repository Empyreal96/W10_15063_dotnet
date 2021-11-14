// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IRfcommConnectionTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.ApplicationModel.Background
{
  [Guid(3905211106, 2899, 17508, 147, 148, 253, 135, 86, 84, 222, 100)]
  [ExclusiveTo(typeof (RfcommConnectionTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommConnectionTrigger : IBackgroundTrigger
  {
    RfcommInboundConnectionInformation InboundConnection { get; }

    RfcommOutboundConnectionInformation OutboundConnection { get; }

    bool AllowMultipleConnections { get; set; }

    SocketProtectionLevel ProtectionLevel { get; set; }

    HostName RemoteHostName { get; set; }
  }
}
