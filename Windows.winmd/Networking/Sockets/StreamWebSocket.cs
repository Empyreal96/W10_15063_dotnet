// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamWebSocket
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
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StreamWebSocket : IStreamWebSocket, IWebSocket, IClosable, IStreamWebSocket2
  {
    [MethodImpl]
    public extern StreamWebSocket();

    public extern StreamWebSocketControl Control { [MethodImpl] get; }

    public extern StreamWebSocketInformation Information { [MethodImpl] get; }

    public extern IInputStream InputStream { [MethodImpl] get; }

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

    public extern event TypedEventHandler<StreamWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
