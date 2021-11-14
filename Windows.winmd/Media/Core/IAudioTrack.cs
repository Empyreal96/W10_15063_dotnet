// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [Guid(4063981175, 16119, 16606, 185, 67, 6, 139, 19, 33, 112, 29)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioTrack))]
  internal interface IAudioTrack
  {
    event TypedEventHandler<AudioTrack, AudioTrackOpenFailedEventArgs> OpenFailed;

    AudioEncodingProperties GetEncodingProperties();

    MediaPlaybackItem PlaybackItem { get; }

    string Name { get; }

    AudioTrackSupportInfo SupportInfo { get; }
  }
}
