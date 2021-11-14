// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(3478382098, 39476, 4582, 159, 51, 162, 79, 192, 217, 100, 156)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkPresenter))]
  internal interface IInkPresenter2 : IInkPresenter
  {
    InkHighContrastAdjustment HighContrastAdjustment { get; set; }
  }
}
