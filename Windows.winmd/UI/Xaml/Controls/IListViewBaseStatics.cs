// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewBase))]
  [Guid(2234693879, 15894, 17755, 137, 168, 193, 52, 98, 35, 246, 211)]
  [WebHostHidden]
  internal interface IListViewBaseStatics
  {
    DependencyProperty SelectionModeProperty { get; }

    DependencyProperty IsSwipeEnabledProperty { get; }

    DependencyProperty CanDragItemsProperty { get; }

    DependencyProperty CanReorderItemsProperty { get; }

    DependencyProperty IsItemClickEnabledProperty { get; }

    DependencyProperty DataFetchSizeProperty { get; }

    DependencyProperty IncrementalLoadingThresholdProperty { get; }

    DependencyProperty IncrementalLoadingTriggerProperty { get; }

    DependencyProperty SemanticZoomOwnerProperty { get; }

    DependencyProperty IsActiveViewProperty { get; }

    DependencyProperty IsZoomedInViewProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty HeaderTransitionsProperty { get; }
  }
}
