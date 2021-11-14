// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(4283511863, 57247, 19952, 191, 130, 14, 197, 215, 179, 90, 174)]
  [ExclusiveTo(typeof (StreamSocketListener))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListener : IClosable
  {
    StreamSocketListenerControl Control { get; }

    StreamSocketListenerInformation Information { get; }

    [RemoteAsync]
    IAsyncAction BindServiceNameAsync(string localServiceName);

    [RemoteAsync]
    IAsyncAction BindEndpointAsync(HostName localHostName, string localServiceName);

    event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;
  }
}
