// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlaybackSession : IMediaPlaybackSession, IMediaPlaybackSession2
  {
    public extern event TypedEventHandler<MediaPlaybackSession, object> PlaybackStateChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> PlaybackRateChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> SeekCompleted;

    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferingStarted;

    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferingEnded;

    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferingProgressChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> DownloadProgressChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> NaturalDurationChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> PositionChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> NaturalVideoSizeChanged;

    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    public extern TimeSpan NaturalDuration { [MethodImpl] get; }

    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlaybackState PlaybackState { [MethodImpl] get; }

    public extern bool CanSeek { [MethodImpl] get; }

    public extern bool CanPause { [MethodImpl] get; }

    public extern bool IsProtected { [MethodImpl] get; }

    public extern double PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    public extern double BufferingProgress { [MethodImpl] get; }

    public extern double DownloadProgress { [MethodImpl] get; }

    public extern uint NaturalVideoHeight { [MethodImpl] get; }

    public extern uint NaturalVideoWidth { [MethodImpl] get; }

    public extern Rect NormalizedSourceRect { [MethodImpl] get; [MethodImpl] set; }

    public extern StereoscopicVideoPackingMode StereoscopicVideoPackingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferedRangesChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> PlayedRangesChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> SeekableRangesChanged;

    public extern event TypedEventHandler<MediaPlaybackSession, object> SupportedPlaybackRatesChanged;

    public extern MediaPlaybackSphericalVideoProjection SphericalVideoProjection { [MethodImpl] get; }

    public extern bool IsMirroring { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IVectorView<MediaTimeRange> GetBufferedRanges();

    [MethodImpl]
    public extern IVectorView<MediaTimeRange> GetPlayedRanges();

    [MethodImpl]
    public extern IVectorView<MediaTimeRange> GetSeekableRanges();

    [MethodImpl]
    public extern bool IsSupportedPlaybackRateRange(double rate1, double rate2);
  }
}
