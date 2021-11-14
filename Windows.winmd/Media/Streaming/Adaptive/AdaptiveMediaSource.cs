// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IAdaptiveMediaSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AdaptiveMediaSource : 
    IAdaptiveMediaSource,
    IMediaSource,
    IAdaptiveMediaSource2,
    IAdaptiveMediaSource3,
    IClosable
  {
    public extern bool IsLive { [MethodImpl] get; }

    public extern TimeSpan DesiredLiveOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern uint InitialBitrate { [MethodImpl] get; [MethodImpl] set; }

    public extern uint CurrentDownloadBitrate { [MethodImpl] get; }

    public extern uint CurrentPlaybackBitrate { [MethodImpl] get; }

    public extern IVectorView<uint> AvailableBitrates { [MethodImpl] get; }

    public extern IReference<uint> DesiredMinBitrate { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<uint> DesiredMaxBitrate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AudioOnlyPlayback { [MethodImpl] get; }

    public extern ulong InboundBitsPerSecond { [MethodImpl] get; }

    public extern TimeSpan InboundBitsPerSecondWindow { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadBitrateChangedEventArgs> DownloadBitrateChanged;

    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourcePlaybackBitrateChangedEventArgs> PlaybackBitrateChanged;

    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadRequestedEventArgs> DownloadRequested;

    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadCompletedEventArgs> DownloadCompleted;

    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadFailedEventArgs> DownloadFailed;

    public extern AdaptiveMediaSourceAdvancedSettings AdvancedSettings { [MethodImpl] get; }

    public extern IReference<TimeSpan> MinLiveOffset { [MethodImpl] get; }

    public extern IReference<TimeSpan> MaxSeekableWindowSize { [MethodImpl] get; }

    public extern IReference<TimeSpan> DesiredSeekableWindowSize { [MethodImpl] get; [MethodImpl] set; }

    public extern AdaptiveMediaSourceDiagnostics Diagnostics { [MethodImpl] get; }

    [MethodImpl]
    public extern AdaptiveMediaSourceCorrelatedTimes GetCorrelatedTimes();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public static extern bool IsContentTypeSupported(string contentType);

    [RemoteAsync]
    [Overload("CreateFromUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("CreateFromUriWithDownloaderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri,
      HttpClient httpClient);

    [Overload("CreateFromStreamAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType);

    [Overload("CreateFromStreamWithDownloaderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType,
      HttpClient httpClient);
  }
}
