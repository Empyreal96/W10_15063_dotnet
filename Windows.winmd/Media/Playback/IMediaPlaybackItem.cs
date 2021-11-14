// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [Guid(74487762, 58543, 18603, 178, 131, 105, 41, 230, 116, 236, 226)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlaybackItem : IMediaPlaybackSource
  {
    event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> AudioTracksChanged;

    event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> VideoTracksChanged;

    event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> TimedMetadataTracksChanged;

    MediaSource Source { get; }

    MediaPlaybackAudioTrackList AudioTracks { get; }

    MediaPlaybackVideoTrackList VideoTracks { get; }

    MediaPlaybackTimedMetadataTrackList TimedMetadataTracks { get; }
  }
}
