// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  [Guid(414677291, 4572, 20150, 167, 188, 116, 26, 219, 62, 235, 121)]
  [ExclusiveTo(typeof (ListViewBase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IListViewBase4
  {
    IVectorView<ItemIndexRange> SelectedRanges { get; }

    bool IsMultiSelectCheckBoxEnabled { get; set; }

    event TypedEventHandler<ListViewBase, DragItemsCompletedEventArgs> DragItemsCompleted;

    event TypedEventHandler<ListViewBase, ChoosingItemContainerEventArgs> ChoosingItemContainer;

    event TypedEventHandler<ListViewBase, ChoosingGroupHeaderContainerEventArgs> ChoosingGroupHeaderContainer;

    void SelectRange(ItemIndexRange itemIndexRange);

    void DeselectRange(ItemIndexRange itemIndexRange);
  }
}
