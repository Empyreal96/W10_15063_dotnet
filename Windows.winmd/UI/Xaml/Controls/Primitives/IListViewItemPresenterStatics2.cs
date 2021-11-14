// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenterStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1286846789, 53837, 17059, 158, 131, 168, 109, 6, 24, 191, 27)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  internal interface IListViewItemPresenterStatics2
  {
    DependencyProperty SelectedPressedBackgroundProperty { get; }

    DependencyProperty PressedBackgroundProperty { get; }

    DependencyProperty CheckBoxBrushProperty { get; }

    DependencyProperty FocusSecondaryBorderBrushProperty { get; }

    DependencyProperty CheckModeProperty { get; }

    DependencyProperty PointerOverForegroundProperty { get; }
  }
}
