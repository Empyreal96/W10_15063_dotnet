// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackTimedMetadataTrackList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(1924403993, 48123, 18083, 147, 114, 156, 156, 116, 75, 148, 56)]
  [ExclusiveTo(typeof (MediaPlaybackTimedMetadataTrackList))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlaybackTimedMetadataTrackList
  {
    event TypedEventHandler<MediaPlaybackTimedMetadataTrackList, TimedMetadataPresentationModeChangedEventArgs> PresentationModeChanged;

    TimedMetadataTrackPresentationMode GetPresentationMode(
      uint index);

    void SetPresentationMode(uint index, TimedMetadataTrackPresentationMode value);
  }
}
