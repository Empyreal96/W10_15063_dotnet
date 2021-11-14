// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisRoot
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkAnalysisRoot))]
  [Guid(1068934084, 12254, 16481, 133, 2, 169, 15, 50, 84, 91, 132)]
  internal interface IInkAnalysisRoot : IInkAnalysisNode
  {
    string RecognizedText { get; }

    IVectorView<IInkAnalysisNode> FindNodes(InkAnalysisNodeKind nodeKind);
  }
}
