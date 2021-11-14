// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.Timeline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITimelineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ITimelineFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Timeline : DependencyObject, ITimeline
  {
    [MethodImpl]
    protected extern Timeline();

    public extern bool AutoReverse { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> BeginTime { [MethodImpl] get; [MethodImpl] set; }

    public extern Duration Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern double SpeedRatio { [MethodImpl] get; [MethodImpl] set; }

    public extern FillBehavior FillBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern RepeatBehavior RepeatBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<object> Completed;

    public static extern bool AllowDependentAnimations { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty AutoReverseProperty { [MethodImpl] get; }

    public static extern DependencyProperty BeginTimeProperty { [MethodImpl] get; }

    public static extern DependencyProperty DurationProperty { [MethodImpl] get; }

    public static extern DependencyProperty SpeedRatioProperty { [MethodImpl] get; }

    public static extern DependencyProperty FillBehaviorProperty { [MethodImpl] get; }

    public static extern DependencyProperty RepeatBehaviorProperty { [MethodImpl] get; }
  }
}
