// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDatagramSocketStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DatagramSocket : IDatagramSocket, IClosable, IDatagramSocket2, IDatagramSocket3
  {
    [MethodImpl]
    public extern DatagramSocket();

    public extern DatagramSocketControl Control { [MethodImpl] get; }

    public extern DatagramSocketInformation Information { [MethodImpl] get; }

    public extern IOutputStream OutputStream { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("ConnectAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [Overload("ConnectWithEndpointPairAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(EndpointPair endpointPair);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(string localServiceName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindEndpointAsync(
      HostName localHostName,
      string localServiceName);

    [MethodImpl]
    public extern void JoinMulticastGroup(HostName host);

    [Overload("GetOutputStreamAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [RemoteAsync]
    [Overload("GetOutputStreamWithEndpointPairAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      EndpointPair endpointPair);

    public extern event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;

    [MethodImpl]
    public extern void Close();

    [Overload("BindServiceNameAndAdapterAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(
      string localServiceName,
      NetworkAdapter adapter);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CancelIOAsync();

    [Overload("EnableTransferOwnership")]
    [MethodImpl]
    public extern void EnableTransferOwnership(Guid taskId);

    [Overload("EnableTransferOwnershipWithConnectedStandbyAction")]
    [MethodImpl]
    public extern void EnableTransferOwnership(
      Guid taskId,
      SocketActivityConnectedStandbyAction connectedStandbyAction);

    [Overload("TransferOwnership")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId);

    [Overload("TransferOwnershipWithContext")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId, SocketActivityContext data);

    [Overload("TransferOwnershipWithContextAndKeepAliveTime")]
    [MethodImpl]
    public extern void TransferOwnership(
      string socketId,
      SocketActivityContext data,
      global::Windows.Foundation.TimeSpan keepAliveTime);

    [Overload("GetEndpointPairsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [Overload("GetEndpointPairsWithSortOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName,
      HostNameSortOptions sortOptions);
  }
}
