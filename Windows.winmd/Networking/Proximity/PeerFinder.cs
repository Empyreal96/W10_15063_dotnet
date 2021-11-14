// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerFinder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPeerFinderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPeerFinderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class PeerFinder
  {
    public static extern PeerRole Role { [MethodImpl] get; [MethodImpl] set; }

    public static extern IBuffer DiscoveryData { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern PeerWatcher CreateWatcher();

    public static extern bool AllowBluetooth { [MethodImpl] get; [MethodImpl] set; }

    public static extern bool AllowInfrastructure { [MethodImpl] get; [MethodImpl] set; }

    public static extern bool AllowWiFiDirect { [MethodImpl] get; [MethodImpl] set; }

    public static extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public static extern PeerDiscoveryTypes SupportedDiscoveryTypes { [MethodImpl] get; }

    public static extern IMap<string, string> AlternateIdentities { [MethodImpl] get; }

    [Overload("Start")]
    [MethodImpl]
    public static extern void Start();

    [Overload("StartWithMessage")]
    [MethodImpl]
    public static extern void Start(string peerMessage);

    [MethodImpl]
    public static extern void Stop();

    public static extern event TypedEventHandler<object, TriggeredConnectionStateChangedEventArgs> TriggeredConnectionStateChanged;

    public static extern event TypedEventHandler<object, ConnectionRequestedEventArgs> ConnectionRequested;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PeerInformation>> FindAllPeersAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StreamSocket> ConnectAsync(
      PeerInformation peerInformation);
  }
}
