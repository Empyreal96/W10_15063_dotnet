// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.IPeerInformation3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [Guid(2987352362, 56272, 16632, 149, 189, 45, 66, 9, 199, 131, 111)]
  [ExclusiveTo(typeof (PeerInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPeerInformation3
  {
    string Id { get; }

    IBuffer DiscoveryData { get; }
  }
}
