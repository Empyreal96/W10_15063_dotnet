// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalysisInkDrawing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkAnalysisInkDrawing : IInkAnalysisInkDrawing, IInkAnalysisNode
  {
    public extern InkAnalysisDrawingKind DrawingKind { [MethodImpl] get; }

    public extern Point Center { [MethodImpl] get; }

    public extern IVectorView<Point> Points { [MethodImpl] get; }

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
