// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ArcSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IArcSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ArcSegment : PathSegment, IArcSegment
  {
    [MethodImpl]
    public extern ArcSegment();

    public extern Point Point { [MethodImpl] get; [MethodImpl] set; }

    public extern Size Size { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLargeArc { [MethodImpl] get; [MethodImpl] set; }

    public extern SweepDirection SweepDirection { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PointProperty { [MethodImpl] get; }

    public static extern DependencyProperty SizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty RotationAngleProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsLargeArcProperty { [MethodImpl] get; }

    public static extern DependencyProperty SweepDirectionProperty { [MethodImpl] get; }
  }
}
