// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MessageWebSocketControl))]
  [Guid(2165848202, 50729, 20234, 128, 251, 129, 252, 5, 83, 136, 98)]
  internal interface IMessageWebSocketControl : IWebSocketControl
  {
    uint MaxMessageSize { get; set; }

    SocketMessageType MessageType { get; set; }
  }
}
