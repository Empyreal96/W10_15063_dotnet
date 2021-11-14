// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StreamSocketListener : 
    IStreamSocketListener,
    IClosable,
    IStreamSocketListener2,
    IStreamSocketListener3
  {
    [MethodImpl]
    public extern StreamSocketListener();

    public extern StreamSocketListenerControl Control { [MethodImpl] get; }

    public extern StreamSocketListenerInformation Information { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(string localServiceName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindEndpointAsync(
      HostName localHostName,
      string localServiceName);

    public extern event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [Overload("BindServiceNameWithProtectionLevelAsync")]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel);

    [RemoteAsync]
    [Overload("BindServiceNameWithProtectionLevelAndAdapterAsync")]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(
      string localServiceName,
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
  }
}
