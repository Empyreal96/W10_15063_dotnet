// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaTimelineController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(2396217843, 2936, 17248, 191, 113, 12, 132, 25, 153, 234, 27)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaTimelineController))]
  internal interface IMediaTimelineController
  {
    void Start();

    void Resume();

    void Pause();

    TimeSpan Position { get; set; }

    double ClockRate { get; set; }

    MediaTimelineControllerState State { get; }

    event TypedEventHandler<MediaTimelineController, object> PositionChanged;

    event TypedEventHandler<MediaTimelineController, object> StateChanged;
  }
}
