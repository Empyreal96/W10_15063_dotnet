// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4104723928, 55673, 17281, 134, 82, 189, 160, 52, 42, 118, 94)]
  internal interface IItemsControl
  {
    object ItemsSource { get; set; }

    ItemCollection Items { get; }

    DataTemplate ItemTemplate { get; set; }

    DataTemplateSelector ItemTemplateSelector { get; set; }

    ItemsPanelTemplate ItemsPanel { get; set; }

    string DisplayMemberPath { get; set; }

    Style ItemContainerStyle { get; set; }

    StyleSelector ItemContainerStyleSelector { get; set; }

    ItemContainerGenerator ItemContainerGenerator { get; }

    TransitionCollection ItemContainerTransitions { get; set; }

    IObservableVector<global::Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { get; }

    GroupStyleSelector GroupStyleSelector { get; set; }

    bool IsGrouping { get; }
  }
}
