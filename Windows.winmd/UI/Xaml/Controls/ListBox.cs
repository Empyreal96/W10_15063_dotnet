// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListBox
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
  [Static(typeof (IListBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IListBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IListBoxStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  public class ListBox : Selector, IListBox, IListBox2
  {
    [MethodImpl]
    public extern ListBox();

    public extern IVector<object> SelectedItems { [MethodImpl] get; }

    public extern SelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void ScrollIntoView(object item);

    [MethodImpl]
    public extern void SelectAll();

    public extern bool SingleSelectionFollowsFocus { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SingleSelectionFollowsFocusProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }
  }
}
