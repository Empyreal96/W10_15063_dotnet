// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterRulerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(875961323, 36865, 19019, 166, 144, 105, 219, 175, 99, 229, 1)]
  public interface IInkPresenterRulerFactory
  {
    InkPresenterRuler Create(InkPresenter inkPresenter);
  }
}
