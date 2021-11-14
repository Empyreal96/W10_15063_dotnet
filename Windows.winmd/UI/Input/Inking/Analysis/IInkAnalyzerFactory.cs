// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalyzerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [Guid(689145478, 6499, 18904, 149, 137, 225, 67, 132, 199, 105, 227)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IInkAnalyzerFactory
  {
    InkAnalyzer CreateAnalyzer();
  }
}
