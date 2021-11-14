// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControlOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemsControl))]
  [Guid(3348870171, 41092, 17153, 164, 150, 114, 151, 31, 54, 78, 209)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsControlOverrides
  {
    bool IsItemItsOwnContainerOverride(object item);

    DependencyObject GetContainerForItemOverride();

    void ClearContainerForItemOverride(DependencyObject element, object item);

    void PrepareContainerForItemOverride(DependencyObject element, object item);

    void OnItemsChanged(object e);

    void OnItemContainerStyleChanged(Style oldItemContainerStyle, Style newItemContainerStyle);

    void OnItemContainerStyleSelectorChanged(
      StyleSelector oldItemContainerStyleSelector,
      StyleSelector newItemContainerStyleSelector);

    void OnItemTemplateChanged(DataTemplate oldItemTemplate, DataTemplate newItemTemplate);

    void OnItemTemplateSelectorChanged(
      DataTemplateSelector oldItemTemplateSelector,
      DataTemplateSelector newItemTemplateSelector);

    void OnGroupStyleSelectorChanged(
      GroupStyleSelector oldGroupStyleSelector,
      GroupStyleSelector newGroupStyleSelector);
  }
}
