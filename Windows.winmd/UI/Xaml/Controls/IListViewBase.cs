// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  [Guid(1023939514, 26768, 17719, 191, 229, 121, 109, 148, 88, 237, 214)]
  internal interface IListViewBase
  {
    IVector<object> SelectedItems { get; }

    ListViewSelectionMode SelectionMode { get; set; }

    bool IsSwipeEnabled { get; set; }

    bool CanDragItems { get; set; }

    bool CanReorderItems { get; set; }

    bool IsItemClickEnabled { get; set; }

    double DataFetchSize { get; set; }

    double IncrementalLoadingThreshold { get; set; }

    IncrementalLoadingTrigger IncrementalLoadingTrigger { get; set; }

    event ItemClickEventHandler ItemClick;

    event DragItemsStartingEventHandler DragItemsStarting;

    [Overload("ScrollIntoView")]
    void ScrollIntoView(object item);

    void SelectAll();

    [RemoteAsync]
    IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();

    [Overload("ScrollIntoViewWithAlignment")]
    void ScrollIntoView(object item, ScrollIntoViewAlignment alignment);

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    TransitionCollection HeaderTransitions { get; set; }
  }
}
