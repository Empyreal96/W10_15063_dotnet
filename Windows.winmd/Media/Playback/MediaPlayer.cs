// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Casting;
using Windows.Media.Core;
using Windows.Media.Protection;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlayer : 
    IMediaPlayer,
    IMediaPlayerSource,
    IMediaPlayerSource2,
    IMediaPlayer2,
    IMediaPlayerEffects,
    IClosable,
    IMediaPlayer3,
    IMediaPlayer4,
    IMediaPlayerEffects2,
    IMediaPlayer5
  {
    [MethodImpl]
    public extern MediaPlayer();

    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan NaturalDuration { [Deprecated("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern TimeSpan Position { [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern double BufferingProgress { [Deprecated("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern MediaPlayerState CurrentState { [Deprecated("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern bool CanSeek { [Deprecated("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern bool CanPause { [Deprecated("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern bool IsLoopingEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsProtected { [Deprecated("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern bool IsMuted { [MethodImpl] get; [MethodImpl] set; }

    public extern double PlaybackRate { [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    public extern PlaybackMediaMarkerSequence PlaybackMediaMarkers { [Deprecated("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern event TypedEventHandler<MediaPlayer, object> MediaOpened;

    public extern event TypedEventHandler<MediaPlayer, object> MediaEnded;

    public extern event TypedEventHandler<MediaPlayer, MediaPlayerFailedEventArgs> MediaFailed;

    public extern event TypedEventHandler<MediaPlayer, object> CurrentStateChanged;

    public extern event TypedEventHandler<MediaPlayer, PlaybackMediaMarkerReachedEventArgs> PlaybackMediaMarkerReached;

    public extern event TypedEventHandler<MediaPlayer, MediaPlayerRateChangedEventArgs> MediaPlayerRateChanged;

    public extern event TypedEventHandler<MediaPlayer, object> VolumeChanged;

    public extern event TypedEventHandler<MediaPlayer, object> SeekCompleted;

    public extern event TypedEventHandler<MediaPlayer, object> BufferingStarted;

    public extern event TypedEventHandler<MediaPlayer, object> BufferingEnded;

    [MethodImpl]
    public extern void Play();

    [MethodImpl]
    public extern void Pause();

    [Deprecated("Use Source instead of SetUriSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetUriSource(Uri value);

    public extern MediaProtectionManager ProtectionManager { [MethodImpl] get; [MethodImpl] set; }

    [Deprecated("Use Source instead of SetFileSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetFileSource(IStorageFile file);

    [Deprecated("Use Source instead of SetStreamSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetStreamSource(IRandomAccessStream stream);

    [Deprecated("Use Source instead of SetMediaSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetMediaSource(IMediaSource source);

    public extern IMediaPlaybackSource Source { [MethodImpl] get; [MethodImpl] set; }

    public extern SystemMediaTransportControls SystemMediaTransportControls { [MethodImpl] get; }

    public extern MediaPlayerAudioCategory AudioCategory { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlayerAudioDeviceType AudioDeviceType { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddAudioEffect(
      string activatableClassId,
      bool effectOptional,
      IPropertySet configuration);

    [MethodImpl]
    public extern void RemoveAllEffects();

    [MethodImpl]
    public extern void Close();

    public extern event TypedEventHandler<MediaPlayer, object> IsMutedChanged;

    public extern event TypedEventHandler<MediaPlayer, object> SourceChanged;

    public extern double AudioBalance { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RealTimePlayback { [MethodImpl] get; [MethodImpl] set; }

    public extern StereoscopicVideoRenderMode StereoscopicVideoRenderMode { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaBreakManager BreakManager { [MethodImpl] get; }

    public extern MediaPlaybackCommandManager CommandManager { [MethodImpl] get; }

    public extern DeviceInformation AudioDevice { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaTimelineController TimelineController { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan TimelineControllerPositionOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlaybackSession PlaybackSession { [MethodImpl] get; }

    [MethodImpl]
    public extern void StepForwardOneFrame();

    [MethodImpl]
    public extern void StepBackwardOneFrame();

    [MethodImpl]
    public extern CastingSource GetAsCastingSource();

    [MethodImpl]
    public extern void SetSurfaceSize(Size size);

    [MethodImpl]
    public extern MediaPlayerSurface GetSurface(Compositor compositor);

    [MethodImpl]
    public extern void AddVideoEffect(
      string activatableClassId,
      bool effectOptional,
      IPropertySet effectConfiguration);

    public extern event TypedEventHandler<MediaPlayer, object> VideoFrameAvailable;

    public extern bool IsVideoFrameServerEnabled { [MethodImpl] get; [MethodImpl] set; }

    [Overload("CopyFrameToVideoSurface")]
    [MethodImpl]
    public extern void CopyFrameToVideoSurface(IDirect3DSurface destination);

    [Overload("CopyFrameToVideoSurfaceWithTargetRectangle")]
    [MethodImpl]
    public extern void CopyFrameToVideoSurface(IDirect3DSurface destination, Rect targetRectangle);

    [MethodImpl]
    public extern void CopyFrameToStereoscopicVideoSurfaces(
      IDirect3DSurface destinationLeftEye,
      IDirect3DSurface destinationRightEye);
  }
}
