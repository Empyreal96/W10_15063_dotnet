// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IListViewBaseStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IListViewBaseStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListViewBaseStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IListViewBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IListViewBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IListViewBaseStatics4), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ListViewBase : 
    Selector,
    IListViewBase,
    ISemanticZoomInformation,
    IListViewBase2,
    IListViewBase3,
    IListViewBase4,
    IListViewBase5,
    IListViewBase6
  {
    [MethodImpl]
    protected extern ListViewBase();

    public extern IVector<object> SelectedItems { [MethodImpl] get; }

    public extern ListViewSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSwipeEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanDragItems { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanReorderItems { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsItemClickEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern double DataFetchSize { [MethodImpl] get; [MethodImpl] set; }

    public extern double IncrementalLoadingThreshold { [MethodImpl] get; [MethodImpl] set; }

    public extern IncrementalLoadingTrigger IncrementalLoadingTrigger { [MethodImpl] get; [MethodImpl] set; }

    public extern event ItemClickEventHandler ItemClick;

    public extern event DragItemsStartingEventHandler DragItemsStarting;

    [Overload("ScrollIntoView")]
    [MethodImpl]
    public extern void ScrollIntoView(object item);

    [MethodImpl]
    public extern void SelectAll();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();

    [Overload("ScrollIntoViewWithAlignment")]
    [MethodImpl]
    public extern void ScrollIntoView(object item, ScrollIntoViewAlignment alignment);

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection HeaderTransitions { [MethodImpl] get; [MethodImpl] set; }

    public extern SemanticZoom SemanticZoomOwner { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsActiveView { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void InitializeViewChange();

    [MethodImpl]
    public extern void CompleteViewChange();

    [MethodImpl]
    public extern void MakeVisible(SemanticZoomLocation item);

    [MethodImpl]
    public extern void StartViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    [MethodImpl]
    public extern void StartViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    [MethodImpl]
    public extern void CompleteViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    [MethodImpl]
    public extern void CompleteViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    public extern bool ShowsScrollingPlaceholders { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> ContainerContentChanging;

    [MethodImpl]
    public extern void SetDesiredContainerUpdateDuration(TimeSpan duration);

    public extern object Footer { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate FooterTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection FooterTransitions { [MethodImpl] get; [MethodImpl] set; }

    public extern ListViewReorderMode ReorderMode { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<ItemIndexRange> SelectedRanges { [MethodImpl] get; }

    public extern bool IsMultiSelectCheckBoxEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<ListViewBase, DragItemsCompletedEventArgs> DragItemsCompleted;

    public extern event TypedEventHandler<ListViewBase, ChoosingItemContainerEventArgs> ChoosingItemContainer;

    public extern event TypedEventHandler<ListViewBase, ChoosingGroupHeaderContainerEventArgs> ChoosingGroupHeaderContainer;

    [MethodImpl]
    public extern void SelectRange(ItemIndexRange itemIndexRange);

    [MethodImpl]
    public extern void DeselectRange(ItemIndexRange itemIndexRange);

    public extern bool SingleSelectionFollowsFocus { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern bool IsDragSource();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryStartConnectedAnimationAsync(
      ConnectedAnimation animation,
      object item,
      string elementName);

    [MethodImpl]
    public extern ConnectedAnimation PrepareConnectedAnimation(
      string key,
      object item,
      string elementName);

    public static extern DependencyProperty SingleSelectionFollowsFocusProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsMultiSelectCheckBoxEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty ReorderModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ShowsScrollingPlaceholdersProperty { [MethodImpl] get; }

    public static extern DependencyProperty FooterProperty { [MethodImpl] get; }

    public static extern DependencyProperty FooterTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty FooterTransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSwipeEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanDragItemsProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanReorderItemsProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsItemClickEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty DataFetchSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IncrementalLoadingThresholdProperty { [MethodImpl] get; }

    public static extern DependencyProperty IncrementalLoadingTriggerProperty { [MethodImpl] get; }

    public static extern DependencyProperty SemanticZoomOwnerProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsActiveViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsZoomedInViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTransitionsProperty { [MethodImpl] get; }
  }
}
