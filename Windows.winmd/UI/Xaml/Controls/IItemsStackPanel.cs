// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsStackPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemsStackPanel))]
  [WebHostHidden]
  [Guid(3749361565, 31445, 19288, 147, 99, 145, 154, 249, 2, 38, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsStackPanel
  {
    Thickness GroupPadding { get; set; }

    Orientation Orientation { get; set; }

    int FirstCacheIndex { get; }

    int FirstVisibleIndex { get; }

    int LastVisibleIndex { get; }

    int LastCacheIndex { get; }

    PanelScrollingDirection ScrollingDirection { get; }

    GroupHeaderPlacement GroupHeaderPlacement { get; set; }

    ItemsUpdatingScrollMode ItemsUpdatingScrollMode { get; set; }

    double CacheLength { get; set; }
  }
}
