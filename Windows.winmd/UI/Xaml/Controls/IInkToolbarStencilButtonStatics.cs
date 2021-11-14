// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStencilButtonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1195950207, 25572, 16909, 147, 154, 107, 114, 67, 233, 209, 36)]
  [ExclusiveTo(typeof (InkToolbarStencilButton))]
  internal interface IInkToolbarStencilButtonStatics
  {
    DependencyProperty RulerProperty { get; }

    DependencyProperty ProtractorProperty { get; }

    DependencyProperty SelectedStencilProperty { get; }

    DependencyProperty IsRulerItemVisibleProperty { get; }

    DependencyProperty IsProtractorItemVisibleProperty { get; }
  }
}
