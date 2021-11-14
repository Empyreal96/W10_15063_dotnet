// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Static(typeof (IMediaSourceStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMediaSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaSource : 
    IMediaSource2,
    IClosable,
    IMediaPlaybackSource,
    IMediaSource3,
    IMediaSource4
  {
    public extern event TypedEventHandler<MediaSource, MediaSourceOpenOperationCompletedEventArgs> OpenOperationCompleted;

    public extern ValueSet CustomProperties { [MethodImpl] get; }

    public extern IReference<TimeSpan> Duration { [MethodImpl] get; }

    public extern bool IsOpen { [MethodImpl] get; }

    public extern IObservableVector<TimedTextSource> ExternalTimedTextSources { [MethodImpl] get; }

    public extern IObservableVector<TimedMetadataTrack> ExternalTimedMetadataTracks { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    public extern event TypedEventHandler<MediaSource, MediaSourceStateChangedEventArgs> StateChanged;

    public extern MediaSourceState State { [MethodImpl] get; }

    [MethodImpl]
    public extern void Reset();

    public extern AdaptiveMediaSource AdaptiveMediaSource { [MethodImpl] get; }

    public extern MediaStreamSource MediaStreamSource { [MethodImpl] get; }

    public extern MseStreamSource MseStreamSource { [MethodImpl] get; }

    public extern Uri Uri { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction OpenAsync();

    [MethodImpl]
    public static extern MediaSource CreateFromMediaBinder(MediaBinder binder);

    [MethodImpl]
    public static extern MediaSource CreateFromAdaptiveMediaSource(
      AdaptiveMediaSource mediaSource);

    [MethodImpl]
    public static extern MediaSource CreateFromMediaStreamSource(
      MediaStreamSource mediaSource);

    [MethodImpl]
    public static extern MediaSource CreateFromMseStreamSource(
      MseStreamSource mediaSource);

    [MethodImpl]
    public static extern MediaSource CreateFromIMediaSource(IMediaSource mediaSource);

    [MethodImpl]
    public static extern MediaSource CreateFromStorageFile(IStorageFile file);

    [MethodImpl]
    public static extern MediaSource CreateFromStream(
      IRandomAccessStream stream,
      string contentType);

    [MethodImpl]
    public static extern MediaSource CreateFromStreamReference(
      IRandomAccessStreamReference stream,
      string contentType);

    [MethodImpl]
    public static extern MediaSource CreateFromUri(Uri uri);
  }
}
