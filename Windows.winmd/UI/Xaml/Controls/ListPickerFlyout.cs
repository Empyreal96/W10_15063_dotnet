// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListPickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IListPickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ListPickerFlyout : PickerFlyoutBase, IListPickerFlyout
  {
    [MethodImpl]
    public extern ListPickerFlyout();

    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayMemberPath { [MethodImpl] get; [MethodImpl] set; }

    public extern ListPickerFlyoutSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectedValue { [MethodImpl] get; [MethodImpl] set; }

    public extern string SelectedValuePath { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<object> SelectedItems { [MethodImpl] get; }

    public extern event TypedEventHandler<ListPickerFlyout, ItemsPickedEventArgs> ItemsPicked;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<object>> ShowAtAsync(
      FrameworkElement target);

    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisplayMemberPathProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedValueProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedValuePathProperty { [MethodImpl] get; }
  }
}
