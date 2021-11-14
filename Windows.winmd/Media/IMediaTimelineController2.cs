// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaTimelineController2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(4017416760, 40562, 19961, 131, 85, 110, 144, 200, 27, 186, 221)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaTimelineController))]
  internal interface IMediaTimelineController2
  {
    IReference<TimeSpan> Duration { get; set; }

    bool IsLoopingEnabled { get; set; }

    event TypedEventHandler<MediaTimelineController, MediaTimelineControllerFailedEventArgs> Failed;

    event TypedEventHandler<MediaTimelineController, object> Ended;
  }
}
