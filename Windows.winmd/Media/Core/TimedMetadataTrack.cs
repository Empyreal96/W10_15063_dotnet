// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (ITimedMetadataTrackFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TimedMetadataTrack : ITimedMetadataTrack, IMediaTrack, ITimedMetadataTrack2
  {
    [MethodImpl]
    public extern TimedMetadataTrack(string id, string language, TimedMetadataKind kind);

    public extern event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueEntered;

    public extern event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueExited;

    public extern event TypedEventHandler<TimedMetadataTrack, TimedMetadataTrackFailedEventArgs> TrackFailed;

    public extern IVectorView<IMediaCue> Cues { [MethodImpl] get; }

    public extern IVectorView<IMediaCue> ActiveCues { [MethodImpl] get; }

    public extern TimedMetadataKind TimedMetadataKind { [MethodImpl] get; }

    public extern string DispatchType { [MethodImpl] get; }

    [MethodImpl]
    public extern void AddCue(IMediaCue cue);

    [MethodImpl]
    public extern void RemoveCue(IMediaCue cue);

    public extern string Id { [MethodImpl] get; }

    public extern string Language { [MethodImpl] get; }

    public extern MediaTrackKind TrackKind { [MethodImpl] get; }

    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }
  }
}
