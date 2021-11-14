// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IShape
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2020551541, 39584, 17741, 174, 6, 162, 70, 110, 55, 200, 50)]
  [ExclusiveTo(typeof (Shape))]
  internal interface IShape
  {
    Brush Fill { get; set; }

    Brush Stroke { get; set; }

    double StrokeMiterLimit { get; set; }

    double StrokeThickness { get; set; }

    PenLineCap StrokeStartLineCap { get; set; }

    PenLineCap StrokeEndLineCap { get; set; }

    PenLineJoin StrokeLineJoin { get; set; }

    double StrokeDashOffset { get; set; }

    PenLineCap StrokeDashCap { get; set; }

    DoubleCollection StrokeDashArray { get; set; }

    Stretch Stretch { get; set; }

    Transform GeometryTransform { get; }
  }
}
