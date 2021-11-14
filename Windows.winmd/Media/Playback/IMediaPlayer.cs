// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(941261771, 28671, 18843, 141, 100, 40, 133, 223, 193, 36, 158)]
  internal interface IMediaPlayer
  {
    bool AutoPlay { get; set; }

    TimeSpan NaturalDuration { [Deprecated("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    TimeSpan Position { [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }

    double BufferingProgress { [Deprecated("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    MediaPlayerState CurrentState { [Deprecated("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool CanSeek { [Deprecated("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool CanPause { [Deprecated("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsLoopingEnabled { get; set; }

    bool IsProtected { [Deprecated("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsMuted { get; set; }

    double PlaybackRate { [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }

    double Volume { get; set; }

    PlaybackMediaMarkerSequence PlaybackMediaMarkers { [Deprecated("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")] get; }

    event TypedEventHandler<MediaPlayer, object> MediaOpened;

    event TypedEventHandler<MediaPlayer, object> MediaEnded;

    event TypedEventHandler<MediaPlayer, MediaPlayerFailedEventArgs> MediaFailed;

    event TypedEventHandler<MediaPlayer, object> CurrentStateChanged;

    event TypedEventHandler<MediaPlayer, PlaybackMediaMarkerReachedEventArgs> PlaybackMediaMarkerReached;

    event TypedEventHandler<MediaPlayer, MediaPlayerRateChangedEventArgs> MediaPlayerRateChanged;

    event TypedEventHandler<MediaPlayer, object> VolumeChanged;

    event TypedEventHandler<MediaPlayer, object> SeekCompleted;

    event TypedEventHandler<MediaPlayer, object> BufferingStarted;

    event TypedEventHandler<MediaPlayer, object> BufferingEnded;

    void Play();

    void Pause();

    [Deprecated("Use Source instead of SetUriSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetUriSource(Uri value);
  }
}
