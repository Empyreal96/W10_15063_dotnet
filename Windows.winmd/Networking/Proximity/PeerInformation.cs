// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Proximity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PeerInformation : 
    IPeerInformation,
    IPeerInformation3,
    IPeerInformationWithHostAndService
  {
    public extern string DisplayName { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern IBuffer DiscoveryData { [MethodImpl] get; }

    public extern HostName HostName { [MethodImpl] get; }

    public extern string ServiceName { [MethodImpl] get; }
  }
}
