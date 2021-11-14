// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(1282618095, 54175, 17302, 180, 217, 4, 57, 87, 167, 201, 100)]
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveMediaSource : IMediaSource
  {
    bool IsLive { get; }

    TimeSpan DesiredLiveOffset { get; set; }

    uint InitialBitrate { get; set; }

    uint CurrentDownloadBitrate { get; }

    uint CurrentPlaybackBitrate { get; }

    IVectorView<uint> AvailableBitrates { get; }

    IReference<uint> DesiredMinBitrate { get; set; }

    IReference<uint> DesiredMaxBitrate { get; set; }

    bool AudioOnlyPlayback { get; }

    ulong InboundBitsPerSecond { get; }

    TimeSpan InboundBitsPerSecondWindow { get; set; }

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadBitrateChangedEventArgs> DownloadBitrateChanged;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourcePlaybackBitrateChangedEventArgs> PlaybackBitrateChanged;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadRequestedEventArgs> DownloadRequested;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadCompletedEventArgs> DownloadCompleted;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadFailedEventArgs> DownloadFailed;
  }
}
