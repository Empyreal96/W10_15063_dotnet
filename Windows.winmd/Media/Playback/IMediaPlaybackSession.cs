// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackSession))]
  [Guid(3274401853, 1031, 16826, 137, 70, 139, 52, 90, 90, 84, 53)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackSession
  {
    event TypedEventHandler<MediaPlaybackSession, object> PlaybackStateChanged;

    event TypedEventHandler<MediaPlaybackSession, object> PlaybackRateChanged;

    event TypedEventHandler<MediaPlaybackSession, object> SeekCompleted;

    event TypedEventHandler<MediaPlaybackSession, object> BufferingStarted;

    event TypedEventHandler<MediaPlaybackSession, object> BufferingEnded;

    event TypedEventHandler<MediaPlaybackSession, object> BufferingProgressChanged;

    event TypedEventHandler<MediaPlaybackSession, object> DownloadProgressChanged;

    event TypedEventHandler<MediaPlaybackSession, object> NaturalDurationChanged;

    event TypedEventHandler<MediaPlaybackSession, object> PositionChanged;

    event TypedEventHandler<MediaPlaybackSession, object> NaturalVideoSizeChanged;

    MediaPlayer MediaPlayer { get; }

    TimeSpan NaturalDuration { get; }

    TimeSpan Position { get; set; }

    MediaPlaybackState PlaybackState { get; }

    bool CanSeek { get; }

    bool CanPause { get; }

    bool IsProtected { get; }

    double PlaybackRate { get; set; }

    double BufferingProgress { get; }

    double DownloadProgress { get; }

    uint NaturalVideoHeight { get; }

    uint NaturalVideoWidth { get; }

    Rect NormalizedSourceRect { get; set; }

    StereoscopicVideoPackingMode StereoscopicVideoPackingMode { get; set; }
  }
}
