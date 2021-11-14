// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeBuilder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2193347036, 7267, 16860, 158, 7, 75, 74, 112, 206, 216, 1)]
  [ExclusiveTo(typeof (InkStrokeBuilder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInkStrokeBuilder
  {
    void BeginStroke(PointerPoint pointerPoint);

    PointerPoint AppendToStroke(PointerPoint pointerPoint);

    InkStroke EndStroke(PointerPoint pointerPoint);

    InkStroke CreateStroke(IIterable<Point> points);

    void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);
  }
}
