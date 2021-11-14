// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisListItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ExclusiveTo(typeof (InkAnalysisListItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3034825279, 50371, 19514, 161, 166, 157, 133, 84, 126, 229, 134)]
  internal interface IInkAnalysisListItem : IInkAnalysisNode
  {
    string RecognizedText { get; }
  }
}
