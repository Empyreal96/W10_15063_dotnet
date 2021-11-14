// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IMediaStreamSourceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class MediaStreamSource : 
    IMediaStreamSource,
    IMediaSource,
    IMediaStreamSource2,
    IMediaStreamSource3
  {
    [MethodImpl]
    public extern MediaStreamSource(IMediaStreamDescriptor descriptor);

    [MethodImpl]
    public extern MediaStreamSource(
      IMediaStreamDescriptor descriptor,
      IMediaStreamDescriptor descriptor2);

    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceClosedEventArgs> Closed;

    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceStartingEventArgs> Starting;

    public extern event TypedEventHandler<MediaStreamSource, object> Paused;

    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRequestedEventArgs> SampleRequested;

    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceSwitchStreamsRequestedEventArgs> SwitchStreamsRequested;

    [MethodImpl]
    public extern void NotifyError(MediaStreamSourceErrorStatus errorStatus);

    [MethodImpl]
    public extern void AddStreamDescriptor(IMediaStreamDescriptor descriptor);

    public extern MediaProtectionManager MediaProtectionManager { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern bool CanSeek { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan BufferTime { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void SetBufferedRange(TimeSpan startOffset, TimeSpan endOffset);

    public extern MusicProperties MusicProperties { [MethodImpl] get; }

    public extern VideoProperties VideoProperties { [MethodImpl] get; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void AddProtectionKey(
      IMediaStreamDescriptor streamDescriptor,
      byte[] keyIdentifier,
      byte[] licenseData);

    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRenderedEventArgs> SampleRendered;

    public extern IReference<double> MaxSupportedPlaybackRate { [MethodImpl] set; [MethodImpl] get; }
  }
}
