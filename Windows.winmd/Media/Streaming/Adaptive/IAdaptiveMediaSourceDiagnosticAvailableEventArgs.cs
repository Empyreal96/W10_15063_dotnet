// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDiagnosticAvailableEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDiagnosticAvailableEventArgs))]
  [Guid(989220614, 28060, 18762, 183, 169, 179, 165, 222, 230, 173, 104)]
  internal interface IAdaptiveMediaSourceDiagnosticAvailableEventArgs
  {
    AdaptiveMediaSourceDiagnosticType DiagnosticType { get; }

    IReference<int> RequestId { get; }

    IReference<TimeSpan> Position { get; }

    IReference<ulong> SegmentId { get; }

    IReference<AdaptiveMediaSourceResourceType> ResourceType { get; }

    Uri ResourceUri { get; }

    IReference<ulong> ResourceByteRangeOffset { get; }

    IReference<ulong> ResourceByteRangeLength { get; }

    IReference<uint> Bitrate { get; }
  }
}
