// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListPickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(252492247, 58867, 17894, 144, 99, 255, 123, 187, 25, 60, 71)]
  [ExclusiveTo(typeof (ListPickerFlyout))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListPickerFlyout
  {
    object ItemsSource { get; set; }

    DataTemplate ItemTemplate { get; set; }

    string DisplayMemberPath { get; set; }

    ListPickerFlyoutSelectionMode SelectionMode { get; set; }

    int SelectedIndex { get; set; }

    object SelectedItem { get; set; }

    object SelectedValue { get; set; }

    string SelectedValuePath { get; set; }

    IVector<object> SelectedItems { get; }

    event TypedEventHandler<ListPickerFlyout, ItemsPickedEventArgs> ItemsPicked;

    [RemoteAsync]
    IAsyncOperation<IVectorView<object>> ShowAtAsync(
      FrameworkElement target);
  }
}
