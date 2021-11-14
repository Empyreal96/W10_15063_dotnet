// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Polyline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPolylineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Polyline : Shape, IPolyline
  {
    [MethodImpl]
    public extern Polyline();

    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
