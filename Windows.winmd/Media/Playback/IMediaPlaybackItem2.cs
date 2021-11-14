// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItem2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [Guid(3629764977, 55279, 19329, 172, 31, 244, 4, 147, 203, 176, 145)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackItem2 : IMediaPlaybackItem, IMediaPlaybackSource
  {
    MediaBreakSchedule BreakSchedule { get; }

    TimeSpan StartTime { get; }

    IReference<TimeSpan> DurationLimit { get; }

    bool CanSkip { get; set; }

    MediaItemDisplayProperties GetDisplayProperties();

    void ApplyDisplayProperties(MediaItemDisplayProperties value);
  }
}
