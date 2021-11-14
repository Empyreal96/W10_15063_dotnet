// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.Devices.WiFiDirect.Services
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectServiceSession : IWiFiDirectServiceSession, IClosable
  {
    public extern string ServiceName { [MethodImpl] get; }

    public extern WiFiDirectServiceSessionStatus Status { [MethodImpl] get; }

    public extern WiFiDirectServiceSessionErrorStatus ErrorStatus { [MethodImpl] get; }

    public extern uint SessionId { [MethodImpl] get; }

    public extern uint AdvertisementId { [MethodImpl] get; }

    public extern string ServiceAddress { [MethodImpl] get; }

    public extern string SessionAddress { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<EndpointPair> GetConnectionEndpointPairs();

    public extern event TypedEventHandler<WiFiDirectServiceSession, object> SessionStatusChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AddStreamSocketListenerAsync(StreamSocketListener value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AddDatagramSocketAsync(DatagramSocket value);

    public extern event TypedEventHandler<WiFiDirectServiceSession, WiFiDirectServiceRemotePortAddedEventArgs> RemotePortAdded;

    [MethodImpl]
    public extern void Close();
  }
}
