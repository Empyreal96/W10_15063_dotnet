// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4124857494, 57634, 19543, 166, 37, 172, 75, 8, 251, 45, 76)]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  internal interface IListViewItemPresenter2
  {
    Brush SelectedPressedBackground { get; set; }

    Brush PressedBackground { get; set; }

    Brush CheckBoxBrush { get; set; }

    Brush FocusSecondaryBorderBrush { get; set; }

    ListViewItemPresenterCheckMode CheckMode { get; set; }

    Brush PointerOverForeground { get; set; }
  }
}
