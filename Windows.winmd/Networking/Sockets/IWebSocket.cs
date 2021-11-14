// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(4168563055, 39345, 19992, 188, 8, 133, 12, 154, 223, 21, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebSocket : IClosable
  {
    IOutputStream OutputStream { get; }

    [RemoteAsync]
    IAsyncAction ConnectAsync(Uri uri);

    void SetRequestHeader(string headerName, string headerValue);

    event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

    [Overload("CloseWithStatus")]
    void Close(ushort code, string reason);
  }
}
