// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStencilButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarStencilButton))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(812262934, 23360, 19443, 146, 183, 241, 223, 147, 106, 239, 245)]
  internal interface IInkToolbarStencilButton
  {
    InkPresenterRuler Ruler { get; }

    InkPresenterProtractor Protractor { get; }

    InkToolbarStencilKind SelectedStencil { get; set; }

    bool IsRulerItemVisible { get; set; }

    bool IsProtractorItemVisible { get; set; }
  }
}
