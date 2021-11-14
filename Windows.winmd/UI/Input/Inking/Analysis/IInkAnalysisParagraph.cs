// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisParagraph
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ExclusiveTo(typeof (InkAnalysisParagraph))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3651994716, 3281, 19924, 166, 139, 235, 31, 18, 179, 215, 39)]
  internal interface IInkAnalysisParagraph : IInkAnalysisNode
  {
    string RecognizedText { get; }
  }
}
