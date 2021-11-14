// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSession2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackSession))]
  [Guid(4172971129, 8136, 16535, 173, 112, 192, 250, 24, 204, 0, 80)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaPlaybackSession2
  {
    event TypedEventHandler<MediaPlaybackSession, object> BufferedRangesChanged;

    event TypedEventHandler<MediaPlaybackSession, object> PlayedRangesChanged;

    event TypedEventHandler<MediaPlaybackSession, object> SeekableRangesChanged;

    event TypedEventHandler<MediaPlaybackSession, object> SupportedPlaybackRatesChanged;

    MediaPlaybackSphericalVideoProjection SphericalVideoProjection { get; }

    bool IsMirroring { get; set; }

    IVectorView<MediaTimeRange> GetBufferedRanges();

    IVectorView<MediaTimeRange> GetPlayedRanges();

    IVectorView<MediaTimeRange> GetSeekableRanges();

    bool IsSupportedPlaybackRateRange(double rate1, double rate2);
  }
}
