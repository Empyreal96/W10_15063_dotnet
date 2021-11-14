// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalysisWritingRegion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class InkAnalysisWritingRegion : IInkAnalysisWritingRegion, IInkAnalysisNode
  {
    public extern string RecognizedText { [MethodImpl] get; }

    public extern uint Id { [MethodImpl] get; }

    public extern InkAnalysisNodeKind Kind { [MethodImpl] get; }

    public extern Rect BoundingRect { [MethodImpl] get; }

    public extern IVectorView<Point> RotatedBoundingRect { [MethodImpl] get; }

    public extern IVectorView<IInkAnalysisNode> Children { [MethodImpl] get; }

    public extern IInkAnalysisNode Parent { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<uint> GetStrokeIds();
  }
}
