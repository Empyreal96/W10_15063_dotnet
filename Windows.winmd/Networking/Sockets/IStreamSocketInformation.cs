// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(998288944, 24168, 16901, 136, 240, 220, 133, 210, 226, 93, 237)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocketInformation))]
  internal interface IStreamSocketInformation
  {
    HostName LocalAddress { get; }

    string LocalPort { get; }

    HostName RemoteHostName { get; }

    HostName RemoteAddress { get; }

    string RemoteServiceName { get; }

    string RemotePort { get; }

    RoundTripTimeStatistics RoundTripTimeStatistics { get; }

    BandwidthStatistics BandwidthStatistics { get; }

    SocketProtectionLevel ProtectionLevel { get; }

    IBuffer SessionKey { get; }
  }
}
