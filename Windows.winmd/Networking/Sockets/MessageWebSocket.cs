// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.MessageWebSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MessageWebSocket : IMessageWebSocket, IWebSocket, IClosable, IMessageWebSocket2
  {
    [MethodImpl]
    public extern MessageWebSocket();

    public extern MessageWebSocketControl Control { [MethodImpl] get; }

    public extern MessageWebSocketInformation Information { [MethodImpl] get; }

    public extern event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;

    public extern IOutputStream OutputStream { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(Uri uri);

    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    public extern event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

    [Overload("CloseWithStatus")]
    [MethodImpl]
    public extern void Close(ushort code, string reason);

    [MethodImpl]
    public extern void Close();

    public extern event TypedEventHandler<MessageWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
