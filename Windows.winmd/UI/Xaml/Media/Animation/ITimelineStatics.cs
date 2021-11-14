// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ITimelineStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2835541326, 61200, 19823, 154, 64, 147, 203, 136, 149, 244, 229)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Timeline))]
  internal interface ITimelineStatics
  {
    bool AllowDependentAnimations { get; set; }

    DependencyProperty AutoReverseProperty { get; }

    DependencyProperty BeginTimeProperty { get; }

    DependencyProperty DurationProperty { get; }

    DependencyProperty SpeedRatioProperty { get; }

    DependencyProperty FillBehaviorProperty { get; }

    DependencyProperty RepeatBehaviorProperty { get; }
  }
}
