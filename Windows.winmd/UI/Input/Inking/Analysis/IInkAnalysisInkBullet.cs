// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.IInkAnalysisInkBullet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3993277288, 24848, 16694, 149, 249, 238, 128, 159, 194, 0, 48)]
  [ExclusiveTo(typeof (InkAnalysisInkBullet))]
  internal interface IInkAnalysisInkBullet : IInkAnalysisNode
  {
    string RecognizedText { get; }
  }
}
