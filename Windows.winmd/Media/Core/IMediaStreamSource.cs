// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSource))]
  [Guid(923981123, 17899, 16696, 170, 98, 192, 30, 38, 243, 132, 63)]
  internal interface IMediaStreamSource : IMediaSource
  {
    event TypedEventHandler<MediaStreamSource, MediaStreamSourceClosedEventArgs> Closed;

    event TypedEventHandler<MediaStreamSource, MediaStreamSourceStartingEventArgs> Starting;

    event TypedEventHandler<MediaStreamSource, object> Paused;

    event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRequestedEventArgs> SampleRequested;

    event TypedEventHandler<MediaStreamSource, MediaStreamSourceSwitchStreamsRequestedEventArgs> SwitchStreamsRequested;

    void NotifyError(MediaStreamSourceErrorStatus errorStatus);

    void AddStreamDescriptor(IMediaStreamDescriptor descriptor);

    MediaProtectionManager MediaProtectionManager { set; get; }

    TimeSpan Duration { set; get; }

    bool CanSeek { set; get; }

    TimeSpan BufferTime { set; get; }

    void SetBufferedRange(TimeSpan startOffset, TimeSpan endOffset);

    MusicProperties MusicProperties { get; }

    VideoProperties VideoProperties { get; }

    IRandomAccessStreamReference Thumbnail { set; get; }

    void AddProtectionKey(
      IMediaStreamDescriptor streamDescriptor,
      byte[] keyIdentifier,
      byte[] licenseData);
  }
}
