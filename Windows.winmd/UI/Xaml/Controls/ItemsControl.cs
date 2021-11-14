// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContentProperty(Name = "Items")]
  [Composable(typeof (IItemsControlFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IItemsControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ItemsControl : 
    Control,
    IItemsControl,
    IItemsControlOverrides,
    IItemsControl2,
    IItemContainerMapping,
    IItemsControl3
  {
    [MethodImpl]
    public extern ItemsControl();

    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    public extern ItemCollection Items { [MethodImpl] get; }

    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplateSelector ItemTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    public extern ItemsPanelTemplate ItemsPanel { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayMemberPath { [MethodImpl] get; [MethodImpl] set; }

    public extern Style ItemContainerStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern StyleSelector ItemContainerStyleSelector { [MethodImpl] get; [MethodImpl] set; }

    public extern ItemContainerGenerator ItemContainerGenerator { [MethodImpl] get; }

    public extern TransitionCollection ItemContainerTransitions { [MethodImpl] get; [MethodImpl] set; }

    public extern IObservableVector<global::Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { [MethodImpl] get; }

    public extern GroupStyleSelector GroupStyleSelector { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsGrouping { [MethodImpl] get; }

    [MethodImpl]
    extern bool IItemsControlOverrides.IsItemItsOwnContainerOverride(
      object item);

    [MethodImpl]
    extern DependencyObject IItemsControlOverrides.GetContainerForItemOverride();

    [MethodImpl]
    extern void IItemsControlOverrides.ClearContainerForItemOverride(
      DependencyObject element,
      object item);

    [MethodImpl]
    extern void IItemsControlOverrides.PrepareContainerForItemOverride(
      DependencyObject element,
      object item);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemsChanged(object e);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemContainerStyleChanged(
      Style oldItemContainerStyle,
      Style newItemContainerStyle);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemContainerStyleSelectorChanged(
      StyleSelector oldItemContainerStyleSelector,
      StyleSelector newItemContainerStyleSelector);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemTemplateChanged(
      DataTemplate oldItemTemplate,
      DataTemplate newItemTemplate);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemTemplateSelectorChanged(
      DataTemplateSelector oldItemTemplateSelector,
      DataTemplateSelector newItemTemplateSelector);

    [MethodImpl]
    extern void IItemsControlOverrides.OnGroupStyleSelectorChanged(
      GroupStyleSelector oldGroupStyleSelector,
      GroupStyleSelector newGroupStyleSelector);

    public extern Panel ItemsPanelRoot { [MethodImpl] get; }

    [MethodImpl]
    public extern object ItemFromContainer(DependencyObject container);

    [MethodImpl]
    public extern DependencyObject ContainerFromItem(object item);

    [MethodImpl]
    public extern int IndexFromContainer(DependencyObject container);

    [MethodImpl]
    public extern DependencyObject ContainerFromIndex(int index);

    [MethodImpl]
    public extern DependencyObject GroupHeaderContainerFromItemContainer(
      DependencyObject itemContainer);

    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemTemplateSelectorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemsPanelProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisplayMemberPathProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemContainerStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemContainerStyleSelectorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemContainerTransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty GroupStyleSelectorProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsGroupingProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern ItemsControl GetItemsOwner(DependencyObject element);

    [MethodImpl]
    public static extern ItemsControl ItemsControlFromItemContainer(
      DependencyObject container);
  }
}
