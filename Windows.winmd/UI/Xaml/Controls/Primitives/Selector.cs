// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.Selector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ISelectorFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISelectorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class Selector : ItemsControl, ISelector
  {
    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectedValue { [MethodImpl] get; [MethodImpl] set; }

    public extern string SelectedValuePath { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<bool> IsSynchronizedWithCurrentItem { [MethodImpl] get; [MethodImpl] set; }

    public extern event SelectionChangedEventHandler SelectionChanged;

    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedValueProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedValuePathProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSynchronizedWithCurrentItemProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsSelectionActive(DependencyObject element);
  }
}
