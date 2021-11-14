// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.QuadraticBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IQuadraticBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class QuadraticBezierSegment : PathSegment, IQuadraticBezierSegment
  {
    [MethodImpl]
    public extern QuadraticBezierSegment();

    public extern Point Point1 { [MethodImpl] get; [MethodImpl] set; }

    public extern Point Point2 { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty Point1Property { [MethodImpl] get; }

    public static extern DependencyProperty Point2Property { [MethodImpl] get; }
  }
}
