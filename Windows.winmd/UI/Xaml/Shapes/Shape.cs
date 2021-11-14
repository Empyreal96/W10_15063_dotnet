// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Shape
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IShapeStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IShapeFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class Shape : FrameworkElement, IShape, IShape2
  {
    [MethodImpl]
    protected extern Shape();

    public extern Brush Fill { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Stroke { [MethodImpl] get; [MethodImpl] set; }

    public extern double StrokeMiterLimit { [MethodImpl] get; [MethodImpl] set; }

    public extern double StrokeThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern PenLineCap StrokeStartLineCap { [MethodImpl] get; [MethodImpl] set; }

    public extern PenLineCap StrokeEndLineCap { [MethodImpl] get; [MethodImpl] set; }

    public extern PenLineJoin StrokeLineJoin { [MethodImpl] get; [MethodImpl] set; }

    public extern double StrokeDashOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern PenLineCap StrokeDashCap { [MethodImpl] get; [MethodImpl] set; }

    public extern DoubleCollection StrokeDashArray { [MethodImpl] get; [MethodImpl] set; }

    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    public extern Transform GeometryTransform { [MethodImpl] get; }

    [MethodImpl]
    public extern CompositionBrush GetAlphaMask();

    public static extern DependencyProperty FillProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeMiterLimitProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeStartLineCapProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeEndLineCapProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeLineJoinProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeDashOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeDashCapProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeDashArrayProperty { [MethodImpl] get; }

    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }
  }
}
