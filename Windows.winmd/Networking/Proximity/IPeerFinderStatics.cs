// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerFinderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (PeerFinder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2437626721, 63201, 18372, 161, 76, 20, 138, 25, 3, 208, 198)]
  internal interface IPeerFinderStatics
  {
    bool AllowBluetooth { get; set; }

    bool AllowInfrastructure { get; set; }

    bool AllowWiFiDirect { get; set; }

    string DisplayName { get; set; }

    PeerDiscoveryTypes SupportedDiscoveryTypes { get; }

    IMap<string, string> AlternateIdentities { get; }

    [Overload("Start")]
    void Start();

    [Overload("StartWithMessage")]
    void Start(string peerMessage);

    void Stop();

    event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;

    event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;

    [RemoteAsync]
    IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();

    [RemoteAsync]
    IAsyncOperation<StreamSocket> ConnectAsync(
      PeerInformation peerInformation);
  }
}
