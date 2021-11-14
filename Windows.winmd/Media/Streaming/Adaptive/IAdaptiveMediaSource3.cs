// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3127911421, 49972, 17947, 163, 110, 201, 159, 84, 247, 23, 74)]
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  internal interface IAdaptiveMediaSource3
  {
    IReference<TimeSpan> MinLiveOffset { get; }

    IReference<TimeSpan> MaxSeekableWindowSize { get; }

    IReference<TimeSpan> DesiredSeekableWindowSize { get; set; }

    AdaptiveMediaSourceDiagnostics Diagnostics { get; }

    AdaptiveMediaSourceCorrelatedTimes GetCorrelatedTimes();
  }
}
