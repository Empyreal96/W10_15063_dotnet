// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Polygon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPolygonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Polygon : Shape, IPolygon
  {
    [MethodImpl]
    public extern Polygon();

    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
