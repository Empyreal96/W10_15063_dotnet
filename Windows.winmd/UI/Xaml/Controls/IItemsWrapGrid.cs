// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsWrapGrid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3724438367, 47752, 19069, 138, 91, 229, 140, 175, 15, 78, 45)]
  [ExclusiveTo(typeof (ItemsWrapGrid))]
  internal interface IItemsWrapGrid
  {
    Thickness GroupPadding { get; set; }

    Orientation Orientation { get; set; }

    int MaximumRowsOrColumns { get; set; }

    double ItemWidth { get; set; }

    double ItemHeight { get; set; }

    int FirstCacheIndex { get; }

    int FirstVisibleIndex { get; }

    int LastVisibleIndex { get; }

    int LastCacheIndex { get; }

    PanelScrollingDirection ScrollingDirection { get; }

    GroupHeaderPlacement GroupHeaderPlacement { get; set; }

    double CacheLength { get; set; }
  }
}
