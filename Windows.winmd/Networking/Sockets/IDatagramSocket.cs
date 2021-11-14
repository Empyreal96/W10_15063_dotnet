// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(2145541051, 50108, 18039, 132, 70, 202, 40, 164, 101, 163, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocket))]
  internal interface IDatagramSocket : IClosable
  {
    DatagramSocketControl Control { get; }

    DatagramSocketInformation Information { get; }

    IOutputStream OutputStream { get; }

    [RemoteAsync]
    [Overload("ConnectAsync")]
    IAsyncAction ConnectAsync(HostName remoteHostName, string remoteServiceName);

    [Overload("ConnectWithEndpointPairAsync")]
    IAsyncAction ConnectAsync(EndpointPair endpointPair);

    [RemoteAsync]
    IAsyncAction BindServiceNameAsync(string localServiceName);

    [RemoteAsync]
    IAsyncAction BindEndpointAsync(HostName localHostName, string localServiceName);

    void JoinMulticastGroup(HostName host);

    [Overload("GetOutputStreamAsync")]
    [RemoteAsync]
    IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [RemoteAsync]
    [Overload("GetOutputStreamWithEndpointPairAsync")]
    IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      EndpointPair endpointPair);

    event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;
  }
}
