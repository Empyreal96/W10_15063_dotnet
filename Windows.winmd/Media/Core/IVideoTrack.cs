// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (VideoTrack))]
  [Guid(2582886387, 58008, 17302, 187, 106, 165, 27, 230, 162, 162, 10)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVideoTrack
  {
    event TypedEventHandler<VideoTrack, VideoTrackOpenFailedEventArgs> OpenFailed;

    VideoEncodingProperties GetEncodingProperties();

    MediaPlaybackItem PlaybackItem { get; }

    string Name { get; }

    VideoTrackSupportInfo SupportInfo { get; }
  }
}
