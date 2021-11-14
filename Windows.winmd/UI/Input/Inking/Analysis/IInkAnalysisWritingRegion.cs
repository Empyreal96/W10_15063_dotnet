// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisWritingRegion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(3714933297, 48406, 18019, 181, 174, 148, 29, 48, 67, 239, 91)]
  [ExclusiveTo(typeof (InkAnalysisWritingRegion))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkAnalysisWritingRegion : IInkAnalysisNode
  {
    string RecognizedText { get; }
  }
}
