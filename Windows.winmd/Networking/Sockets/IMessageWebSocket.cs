// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MessageWebSocket))]
  [Guid(863141128, 13525, 18246, 173, 123, 141, 222, 91, 194, 239, 136)]
  internal interface IMessageWebSocket : IWebSocket, IClosable
  {
    MessageWebSocketControl Control { get; }

    MessageWebSocketInformation Information { get; }

    event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;
  }
}
