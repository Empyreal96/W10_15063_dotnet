// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakSchedule
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaBreakSchedule : IMediaBreakSchedule
  {
    public extern event TypedEventHandler<MediaBreakSchedule, object> ScheduleChanged;

    [MethodImpl]
    public extern void InsertMidrollBreak(MediaBreak mediaBreak);

    [MethodImpl]
    public extern void RemoveMidrollBreak(MediaBreak mediaBreak);

    public extern IVectorView<MediaBreak> MidrollBreaks { [MethodImpl] get; }

    public extern MediaBreak PrerollBreak { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaBreak PostrollBreak { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }
  }
}
