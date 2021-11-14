// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [Activatable(typeof (IMediaPlaybackItemFactory2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaPlaybackItemStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IMediaPlaybackItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackItem : 
    IMediaPlaybackItem,
    IMediaPlaybackSource,
    IMediaPlaybackItem2,
    IMediaPlaybackItem3
  {
    [MethodImpl]
    public extern MediaPlaybackItem(MediaSource source, TimeSpan startTime);

    [MethodImpl]
    public extern MediaPlaybackItem(MediaSource source, TimeSpan startTime, TimeSpan durationLimit);

    [MethodImpl]
    public extern MediaPlaybackItem(MediaSource source);

    public extern event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> AudioTracksChanged;

    public extern event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> VideoTracksChanged;

    public extern event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> TimedMetadataTracksChanged;

    public extern MediaSource Source { [MethodImpl] get; }

    public extern MediaPlaybackAudioTrackList AudioTracks { [MethodImpl] get; }

    public extern MediaPlaybackVideoTrackList VideoTracks { [MethodImpl] get; }

    public extern MediaPlaybackTimedMetadataTrackList TimedMetadataTracks { [MethodImpl] get; }

    public extern MediaBreakSchedule BreakSchedule { [MethodImpl] get; }

    public extern TimeSpan StartTime { [MethodImpl] get; }

    public extern IReference<TimeSpan> DurationLimit { [MethodImpl] get; }

    public extern bool CanSkip { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern MediaItemDisplayProperties GetDisplayProperties();

    [MethodImpl]
    public extern void ApplyDisplayProperties(MediaItemDisplayProperties value);

    public extern bool IsDisabledInPlaybackList { [MethodImpl] get; [MethodImpl] set; }

    public extern double TotalDownloadProgress { [MethodImpl] get; }

    public extern AutoLoadedDisplayPropertyKind AutoLoadedDisplayProperties { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern MediaPlaybackItem FindFromMediaSource(MediaSource source);
  }
}
