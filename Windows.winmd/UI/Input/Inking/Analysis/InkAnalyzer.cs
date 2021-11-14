// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalyzer
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
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkAnalyzer : IInkAnalyzer
  {
    [MethodImpl]
    public extern InkAnalyzer();

    public extern InkAnalysisRoot AnalysisRoot { [MethodImpl] get; }

    public extern bool IsAnalyzing { [MethodImpl] get; }

    [MethodImpl]
    public extern void AddDataForStroke(InkStroke stroke);

    [MethodImpl]
    public extern void AddDataForStrokes(IIterable<InkStroke> strokes);

    [MethodImpl]
    public extern void ClearDataForAllStrokes();

    [MethodImpl]
    public extern void RemoveDataForStroke(uint strokeId);

    [MethodImpl]
    public extern void RemoveDataForStrokes(IIterable<uint> strokeIds);

    [MethodImpl]
    public extern void ReplaceDataForStroke(InkStroke stroke);

    [MethodImpl]
    public extern void SetStrokeDataKind(uint strokeId, InkAnalysisStrokeKind strokeKind);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<InkAnalysisResult> AnalyzeAsync();
  }
}
