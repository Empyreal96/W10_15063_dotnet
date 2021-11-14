// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapItemsControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2495792339, 45877, 17093, 182, 96, 230, 160, 126, 195, 189, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapItemsControl))]
  [WebHostHidden]
  internal interface IMapItemsControl
  {
    object ItemsSource { get; set; }

    IVector<DependencyObject> Items { get; }

    DataTemplate ItemTemplate { get; set; }
  }
}
