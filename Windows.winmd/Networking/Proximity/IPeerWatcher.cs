// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  [ExclusiveTo(typeof (PeerWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1022239224, 12198, 18041, 150, 145, 3, 201, 74, 66, 15, 52)]
  internal interface IPeerWatcher
  {
    event TypedEventHandler<PeerWatcher, PeerInformation> Added;

    event TypedEventHandler<PeerWatcher, PeerInformation> Removed;

    event TypedEventHandler<PeerWatcher, PeerInformation> Updated;

    event TypedEventHandler<PeerWatcher, object> EnumerationCompleted;

    event TypedEventHandler<PeerWatcher, object> Stopped;

    PeerWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
