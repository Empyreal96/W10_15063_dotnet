// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IAttributedNetworkUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (AttributedNetworkUsage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4150898745, 60578, 17899, 173, 225, 176, 54, 139, 117, 108, 73)]
  internal interface IAttributedNetworkUsage
  {
    ulong BytesSent { get; }

    ulong BytesReceived { get; }

    string AttributionId { get; }

    string AttributionName { get; }

    IRandomAccessStreamReference AttributionThumbnail { get; }
  }
}
