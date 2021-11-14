// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedMetadataTrack))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2657807774, 63098, 18857, 179, 48, 207, 3, 176, 233, 207, 7)]
  internal interface ITimedMetadataTrack : IMediaTrack
  {
    event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueEntered;

    event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueExited;

    event TypedEventHandler<TimedMetadataTrack, TimedMetadataTrackFailedEventArgs> TrackFailed;

    IVectorView<IMediaCue> Cues { get; }

    IVectorView<IMediaCue> ActiveCues { get; }

    TimedMetadataKind TimedMetadataKind { get; }

    string DispatchType { get; }

    void AddCue(IMediaCue cue);

    void RemoveCue(IMediaCue cue);
  }
}
