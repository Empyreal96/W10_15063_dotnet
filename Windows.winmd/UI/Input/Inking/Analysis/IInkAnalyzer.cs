// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalyzer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(4046163861, 2150, 19909, 140, 119, 248, 134, 20, 223, 227, 140)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkAnalyzer))]
  internal interface IInkAnalyzer
  {
    InkAnalysisRoot AnalysisRoot { get; }

    bool IsAnalyzing { get; }

    void AddDataForStroke(InkStroke stroke);

    void AddDataForStrokes(IIterable<InkStroke> strokes);

    void ClearDataForAllStrokes();

    void RemoveDataForStroke(uint strokeId);

    void RemoveDataForStrokes(IIterable<uint> strokeIds);

    void ReplaceDataForStroke(InkStroke stroke);

    void SetStrokeDataKind(uint strokeId, InkAnalysisStrokeKind strokeKind);

    [RemoteAsync]
    IAsyncOperation<InkAnalysisResult> AnalyzeAsync();
  }
}
