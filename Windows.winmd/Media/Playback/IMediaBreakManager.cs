// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaBreakManager))]
  [Guid(2824134065, 65204, 19867, 157, 151, 15, 219, 229, 142, 94, 57)]
  internal interface IMediaBreakManager
  {
    event TypedEventHandler<MediaBreakManager, MediaBreakSeekedOverEventArgs> BreaksSeekedOver;

    event TypedEventHandler<MediaBreakManager, MediaBreakStartedEventArgs> BreakStarted;

    event TypedEventHandler<MediaBreakManager, MediaBreakEndedEventArgs> BreakEnded;

    event TypedEventHandler<MediaBreakManager, MediaBreakSkippedEventArgs> BreakSkipped;

    MediaBreak CurrentBreak { get; }

    MediaPlaybackSession PlaybackSession { get; }

    void PlayBreak(MediaBreak value);

    void SkipCurrentBreak();
  }
}
