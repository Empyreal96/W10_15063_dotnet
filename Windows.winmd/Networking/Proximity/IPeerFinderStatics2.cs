// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerFinderStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PeerFinder))]
  [Guid(3605478501, 64976, 19211, 147, 18, 134, 100, 8, 147, 93, 130)]
  internal interface IPeerFinderStatics2
  {
    PeerRole Role { get; set; }

    IBuffer DiscoveryData { get; set; }

    PeerWatcher CreateWatcher();
  }
}
