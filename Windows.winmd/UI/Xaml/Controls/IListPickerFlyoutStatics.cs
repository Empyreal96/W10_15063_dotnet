// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListPickerFlyoutStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4276247447, 35734, 17922, 129, 210, 130, 253, 142, 15, 126, 168)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListPickerFlyout))]
  internal interface IListPickerFlyoutStatics
  {
    DependencyProperty ItemsSourceProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }

    DependencyProperty DisplayMemberPathProperty { get; }

    DependencyProperty SelectionModeProperty { get; }

    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty SelectedValueProperty { get; }

    DependencyProperty SelectedValuePathProperty { get; }
  }
}
