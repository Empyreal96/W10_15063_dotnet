// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStroke
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(353652064, 52451, 20431, 157, 82, 17, 81, 138, 182, 175, 212)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStroke))]
  internal interface IInkStroke
  {
    InkDrawingAttributes DrawingAttributes { get; set; }

    Rect BoundingRect { get; }

    bool Selected { get; set; }

    bool Recognized { get; }

    IVectorView<InkStrokeRenderingSegment> GetRenderingSegments();

    InkStroke Clone();
  }
}
