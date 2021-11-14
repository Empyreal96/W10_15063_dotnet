// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivot
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Pivot))]
  [Guid(272538387, 13312, 18966, 144, 185, 105, 18, 191, 6, 151, 78)]
  internal interface IPivot
  {
    object Title { get; set; }

    DataTemplate TitleTemplate { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    int SelectedIndex { get; set; }

    object SelectedItem { get; set; }

    bool IsLocked { get; set; }

    event SelectionChangedEventHandler SelectionChanged;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoading;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoaded;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloading;

    event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloaded;
  }
}
