// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControlStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(937082249, 56571, 17848, 154, 254, 135, 77, 240, 151, 144, 94)]
  [ExclusiveTo(typeof (ItemsControl))]
  internal interface IItemsControlStatics
  {
    DependencyProperty ItemsSourceProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }

    DependencyProperty ItemTemplateSelectorProperty { get; }

    DependencyProperty ItemsPanelProperty { get; }

    DependencyProperty DisplayMemberPathProperty { get; }

    DependencyProperty ItemContainerStyleProperty { get; }

    DependencyProperty ItemContainerStyleSelectorProperty { get; }

    DependencyProperty ItemContainerTransitionsProperty { get; }

    DependencyProperty GroupStyleSelectorProperty { get; }

    DependencyProperty IsGroupingProperty { get; }

    ItemsControl GetItemsOwner(DependencyObject element);

    ItemsControl ItemsControlFromItemContainer(DependencyObject container);
  }
}
