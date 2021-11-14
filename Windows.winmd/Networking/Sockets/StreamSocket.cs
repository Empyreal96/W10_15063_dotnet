// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocket
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
  [Static(typeof (IStreamSocketStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StreamSocket : IStreamSocket, IClosable, IStreamSocket2, IStreamSocket3
  {
    [MethodImpl]
    public extern StreamSocket();

    public extern StreamSocketControl Control { [MethodImpl] get; }

    public extern StreamSocketInformation Information { [MethodImpl] get; }

    public extern IInputStream InputStream { [MethodImpl] get; }

    public extern IOutputStream OutputStream { [MethodImpl] get; }

    [Overload("ConnectWithEndpointPairAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(EndpointPair endpointPair);

    [Overload("ConnectAsync")]
    [RemoteAsync]
    [DefaultOverload]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      EndpointPair endpointPair,
      SocketProtectionLevel protectionLevel);

    [Overload("ConnectWithProtectionLevelAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpgradeToSslAsync(
      SocketProtectionLevel protectionLevel,
      HostName validationHostName);

    [MethodImpl]
    public extern void Close();

    [Overload("ConnectWithProtectionLevelAndAdapterAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel,
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

    [RemoteAsync]
    [Overload("GetEndpointPairsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [RemoteAsync]
    [Overload("GetEndpointPairsWithSortOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName,
      HostNameSortOptions sortOptions);
  }
}
