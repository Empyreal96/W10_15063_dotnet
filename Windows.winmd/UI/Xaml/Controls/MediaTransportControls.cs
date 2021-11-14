// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaTransportControls
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaTransportControlsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IMediaTransportControlsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMediaTransportControlsStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  public class MediaTransportControls : Control, IMediaTransportControls, IMediaTransportControls2
  {
    [MethodImpl]
    public extern MediaTransportControls();

    public extern bool IsFullWindowButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFullWindowEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFastForwardButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFastForwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFastRewindButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFastRewindEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsStopButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsStopEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsVolumeButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsVolumeEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPlaybackRateButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPlaybackRateEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSeekBarVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSeekEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCompact { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSkipForwardButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSkipForwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSkipBackwardButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSkipBackwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsNextTrackButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPreviousTrackButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern FastPlayFallbackBehaviour FastPlayFallbackBehaviour { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MediaTransportControls, MediaTransportControlsThumbnailRequestedEventArgs> ThumbnailRequested;

    public static extern DependencyProperty IsSkipForwardButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSkipForwardEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSkipBackwardButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSkipBackwardEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsNextTrackButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPreviousTrackButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FastPlayFallbackBehaviourProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFullWindowButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFullWindowEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsZoomButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsZoomEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFastForwardButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFastForwardEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFastRewindButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsFastRewindEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsStopButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsStopEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsVolumeButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsVolumeEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPlaybackRateButtonVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPlaybackRateEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSeekBarVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSeekEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsCompactProperty { [MethodImpl] get; }
  }
}
