// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocket2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(3201355495, 63944, 17418, 154, 213, 115, 114, 129, 217, 116, 46)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MessageWebSocket))]
  internal interface IMessageWebSocket2 : IMessageWebSocket, IWebSocket, IClosable
  {
    event TypedEventHandler<MessageWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
