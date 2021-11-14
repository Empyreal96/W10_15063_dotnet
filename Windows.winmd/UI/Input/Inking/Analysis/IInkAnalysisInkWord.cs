// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisInkWord
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1272064173, 33711, 16436, 143, 59, 248, 104, 125, 255, 244, 54)]
  [ExclusiveTo(typeof (InkAnalysisInkWord))]
  internal interface IInkAnalysisInkWord : IInkAnalysisNode
  {
    string RecognizedText { get; }

    IVectorView<string> TextAlternates { get; }
  }
}
