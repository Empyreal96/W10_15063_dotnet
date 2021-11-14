// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Media.PlayTo;
using Windows.Media.Protection;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaElement : FrameworkElement, IMediaElement, IMediaElement2, IMediaElement3
  {
    [MethodImpl]
    public extern MediaElement();

    public extern ImageSource PosterSource { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsMuted { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAudioOnly { [MethodImpl] get; }

    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    public extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    public extern double Balance { [MethodImpl] get; [MethodImpl] set; }

    public extern int NaturalVideoHeight { [MethodImpl] get; }

    public extern int NaturalVideoWidth { [MethodImpl] get; }

    public extern Duration NaturalDuration { [MethodImpl] get; }

    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }

    public extern double DownloadProgress { [MethodImpl] get; }

    public extern double BufferingProgress { [MethodImpl] get; }

    public extern double DownloadProgressOffset { [MethodImpl] get; }

    public extern MediaElementState CurrentState { [MethodImpl] get; }

    public extern TimelineMarkerCollection Markers { [MethodImpl] get; }

    public extern bool CanSeek { [MethodImpl] get; }

    public extern bool CanPause { [MethodImpl] get; }

    public extern int AudioStreamCount { [MethodImpl] get; }

    public extern IReference<int> AudioStreamIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern double PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLooping { [MethodImpl] get; [MethodImpl] set; }

    public extern PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern double DefaultPlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    public extern int AspectRatioWidth { [MethodImpl] get; }

    public extern int AspectRatioHeight { [MethodImpl] get; }

    public extern bool RealTimePlayback { [MethodImpl] get; [MethodImpl] set; }

    public extern AudioCategory AudioCategory { [MethodImpl] get; [MethodImpl] set; }

    public extern AudioDeviceType AudioDeviceType { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaProtectionManager ProtectionManager { [MethodImpl] get; [MethodImpl] set; }

    public extern Stereo3DVideoPackingMode Stereo3DVideoPackingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern Stereo3DVideoRenderMode Stereo3DVideoRenderMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsStereo3DVideo { [MethodImpl] get; }

    public extern event RoutedEventHandler MediaOpened;

    public extern event RoutedEventHandler MediaEnded;

    public extern event ExceptionRoutedEventHandler MediaFailed;

    public extern event RoutedEventHandler DownloadProgressChanged;

    public extern event RoutedEventHandler BufferingProgressChanged;

    public extern event RoutedEventHandler CurrentStateChanged;

    public extern event TimelineMarkerRoutedEventHandler MarkerReached;

    public extern event RateChangedRoutedEventHandler RateChanged;

    public extern event RoutedEventHandler VolumeChanged;

    public extern event RoutedEventHandler SeekCompleted;

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Play();

    [MethodImpl]
    public extern void Pause();

    [MethodImpl]
    public extern MediaCanPlayResponse CanPlayType(string type);

    [MethodImpl]
    public extern void SetSource(IRandomAccessStream stream, string mimeType);

    [MethodImpl]
    public extern string GetAudioStreamLanguage(IReference<int> index);

    [MethodImpl]
    public extern void AddAudioEffect(
      string effectID,
      bool effectOptional,
      IPropertySet effectConfiguration);

    [MethodImpl]
    public extern void AddVideoEffect(
      string effectID,
      bool effectOptional,
      IPropertySet effectConfiguration);

    [MethodImpl]
    public extern void RemoveAllEffects();

    public extern Stereo3DVideoPackingMode ActualStereo3DVideoPackingMode { [MethodImpl] get; }

    public extern bool AreTransportControlsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFullWindow { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void SetMediaStreamSource(IMediaSource source);

    public extern Uri PlayToPreferredSourceUri { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern MediaTransportControls TransportControls { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MediaElement, PartialMediaFailureDetectedEventArgs> PartialMediaFailureDetected;

    [MethodImpl]
    public extern void SetPlaybackSource(IMediaPlaybackSource source);

    [MethodImpl]
    public extern CastingSource GetAsCastingSource();

    public static extern DependencyProperty AreTransportControlsEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFullWindowProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlayToPreferredSourceUriProperty { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty PosterSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsMutedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsAudioOnlyProperty { [MethodImpl] get; }

    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    public static extern DependencyProperty VolumeProperty { [MethodImpl] get; }

    public static extern DependencyProperty BalanceProperty { [MethodImpl] get; }

    public static extern DependencyProperty NaturalVideoHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty NaturalVideoWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty NaturalDurationProperty { [MethodImpl] get; }

    public static extern DependencyProperty PositionProperty { [MethodImpl] get; }

    public static extern DependencyProperty DownloadProgressProperty { [MethodImpl] get; }

    public static extern DependencyProperty BufferingProgressProperty { [MethodImpl] get; }

    public static extern DependencyProperty DownloadProgressOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty CurrentStateProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanSeekProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanPauseProperty { [MethodImpl] get; }

    public static extern DependencyProperty AudioStreamCountProperty { [MethodImpl] get; }

    public static extern DependencyProperty AudioStreamIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaybackRateProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsLoopingProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty DefaultPlaybackRateProperty { [MethodImpl] get; }

    public static extern DependencyProperty AspectRatioWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty AspectRatioHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty RealTimePlaybackProperty { [MethodImpl] get; }

    public static extern DependencyProperty AudioCategoryProperty { [MethodImpl] get; }

    public static extern DependencyProperty AudioDeviceTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ProtectionManagerProperty { [MethodImpl] get; }

    public static extern DependencyProperty Stereo3DVideoPackingModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty Stereo3DVideoRenderModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsStereo3DVideoProperty { [MethodImpl] get; }

    public static extern DependencyProperty ActualStereo3DVideoPackingModeProperty { [MethodImpl] get; }
  }
}
