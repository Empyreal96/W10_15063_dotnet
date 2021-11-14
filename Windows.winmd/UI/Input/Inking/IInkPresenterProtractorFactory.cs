// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterProtractorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkPresenterProtractor))]
  [Guid(838927305, 26874, 18409, 129, 39, 131, 112, 113, 31, 196, 108)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkPresenterProtractorFactory
  {
    InkPresenterProtractor Create(InkPresenter inkPresenter);
  }
}
