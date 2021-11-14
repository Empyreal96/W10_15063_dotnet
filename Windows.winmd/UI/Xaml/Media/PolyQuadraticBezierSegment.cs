// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PolyQuadraticBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (IPolyQuadraticBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Points")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class PolyQuadraticBezierSegment : PathSegment, IPolyQuadraticBezierSegment
  {
    [MethodImpl]
    public extern PolyQuadraticBezierSegment();

    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
