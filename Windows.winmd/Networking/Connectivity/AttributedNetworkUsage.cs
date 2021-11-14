// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.AttributedNetworkUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AttributedNetworkUsage : IAttributedNetworkUsage
  {
    public extern ulong BytesSent { [MethodImpl] get; }

    public extern ulong BytesReceived { [MethodImpl] get; }

    public extern string AttributionId { [MethodImpl] get; }

    public extern string AttributionName { [MethodImpl] get; }

    public extern IRandomAccessStreamReference AttributionThumbnail { [MethodImpl] get; }
  }
}
