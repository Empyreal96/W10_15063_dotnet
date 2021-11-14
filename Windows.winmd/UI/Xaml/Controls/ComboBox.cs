// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ComboBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IComboBoxStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IComboBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IComboBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ComboBox : Selector, IComboBox, IComboBoxOverrides, IComboBox2, IComboBox3, IComboBox4
  {
    [MethodImpl]
    public extern ComboBox();

    public extern bool IsDropDownOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsEditable { [MethodImpl] get; }

    public extern bool IsSelectionBoxHighlighted { [MethodImpl] get; }

    public extern double MaxDropDownHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectionBoxItem { [MethodImpl] get; }

    public extern DataTemplate SelectionBoxItemTemplate { [MethodImpl] get; }

    public extern ComboBoxTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern event EventHandler<object> DropDownClosed;

    public extern event EventHandler<object> DropDownOpened;

    [MethodImpl]
    extern void IComboBoxOverrides.OnDropDownClosed(object e);

    [MethodImpl]
    extern void IComboBoxOverrides.OnDropDownOpened(object e);

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTextSearchEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ComboBoxSelectionChangedTrigger SelectionChangedTrigger { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SelectionChangedTriggerProperty { [MethodImpl] get; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTextSearchEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsDropDownOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxDropDownHeightProperty { [MethodImpl] get; }
  }
}
