// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PolyBezierSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPolyBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Points")]
  public sealed class PolyBezierSegment : PathSegment, IPolyBezierSegment
  {
    [MethodImpl]
    public extern PolyBezierSegment();

    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
