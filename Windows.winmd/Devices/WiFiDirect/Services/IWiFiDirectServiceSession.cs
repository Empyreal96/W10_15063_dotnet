// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2165580131, 58406, 18379, 134, 64, 225, 179, 88, 139, 242, 111)]
  internal interface IWiFiDirectServiceSession : IClosable
  {
    string ServiceName { get; }

    WiFiDirectServiceSessionStatus Status { get; }

    WiFiDirectServiceSessionErrorStatus ErrorStatus { get; }

    uint SessionId { get; }

    uint AdvertisementId { get; }

    string ServiceAddress { get; }

    string SessionAddress { get; }

    IVectorView<EndpointPair> GetConnectionEndpointPairs();

    event TypedEventHandler<WiFiDirectServiceSession, object> SessionStatusChanged;

    [RemoteAsync]
    IAsyncAction AddStreamSocketListenerAsync(StreamSocketListener value);

    [RemoteAsync]
    IAsyncAction AddDatagramSocketAsync(DatagramSocket value);

    event TypedEventHandler<WiFiDirectServiceSession, WiFiDirectServiceRemotePortAddedEventArgs> RemotePortAdded;
  }
}
