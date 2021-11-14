// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(813899525, 24420, 18988, 186, 55, 79, 72, 135, 135, 149, 116)]
  public interface IInkAnalysisNode
  {
    uint Id { get; }

    InkAnalysisNodeKind Kind { get; }

    Rect BoundingRect { get; }

    IVectorView<Point> RotatedBoundingRect { get; }

    IVectorView<IInkAnalysisNode> Children { get; }

    IInkAnalysisNode Parent { get; }

    IVectorView<uint> GetStrokeIds();
  }
}
