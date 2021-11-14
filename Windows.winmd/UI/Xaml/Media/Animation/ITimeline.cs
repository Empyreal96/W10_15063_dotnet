// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ITimeline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(197420508, 48717, 19725, 149, 73, 34, 8, 183, 21, 244, 13)]
  [ExclusiveTo(typeof (Timeline))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimeline
  {
    bool AutoReverse { get; set; }

    IReference<TimeSpan> BeginTime { get; set; }

    Duration Duration { get; set; }

    double SpeedRatio { get; set; }

    FillBehavior FillBehavior { get; set; }

    RepeatBehavior RepeatBehavior { get; set; }

    event EventHandler<object> Completed;
  }
}
