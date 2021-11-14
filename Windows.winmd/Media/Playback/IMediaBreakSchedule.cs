// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakSchedule
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaBreakSchedule))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2711246867, 39094, 16856, 131, 218, 249, 113, 210, 43, 123, 186)]
  internal interface IMediaBreakSchedule
  {
    event TypedEventHandler<MediaBreakSchedule, object> ScheduleChanged;

    void InsertMidrollBreak(MediaBreak mediaBreak);

    void RemoveMidrollBreak(MediaBreak mediaBreak);

    IVectorView<MediaBreak> MidrollBreaks { get; }

    MediaBreak PrerollBreak { set; get; }

    MediaBreak PostrollBreak { set; get; }

    MediaPlaybackItem PlaybackItem { get; }
  }
}
