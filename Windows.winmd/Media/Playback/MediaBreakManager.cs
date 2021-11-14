// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaBreakManager : IMediaBreakManager
  {
    public extern event TypedEventHandler<MediaBreakManager, MediaBreakSeekedOverEventArgs> BreaksSeekedOver;

    public extern event TypedEventHandler<MediaBreakManager, MediaBreakStartedEventArgs> BreakStarted;

    public extern event TypedEventHandler<MediaBreakManager, MediaBreakEndedEventArgs> BreakEnded;

    public extern event TypedEventHandler<MediaBreakManager, MediaBreakSkippedEventArgs> BreakSkipped;

    public extern MediaBreak CurrentBreak { [MethodImpl] get; }

    public extern MediaPlaybackSession PlaybackSession { [MethodImpl] get; }

    [MethodImpl]
    public extern void PlayBreak(MediaBreak value);

    [MethodImpl]
    public extern void SkipCurrentBreak();
  }
}
