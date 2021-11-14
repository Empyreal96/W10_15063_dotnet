// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisInkDrawing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(1787161887, 8164, 19989, 137, 140, 142, 17, 35, 119, 224, 33)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkAnalysisInkDrawing))]
  internal interface IInkAnalysisInkDrawing : IInkAnalysisNode
  {
    InkAnalysisDrawingKind DrawingKind { get; }

    Point Center { get; }

    IVectorView<Point> Points { get; }
  }
}
