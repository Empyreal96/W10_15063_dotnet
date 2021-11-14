// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.BezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BezierSegment : PathSegment, IBezierSegment
  {
    [MethodImpl]
    public extern BezierSegment();

    public extern Point Point1 { [MethodImpl] get; [MethodImpl] set; }

    public extern Point Point2 { [MethodImpl] get; [MethodImpl] set; }

    public extern Point Point3 { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty Point1Property { [MethodImpl] get; }

    public static extern DependencyProperty Point2Property { [MethodImpl] get; }

    public static extern DependencyProperty Point3Property { [MethodImpl] get; }
  }
}
