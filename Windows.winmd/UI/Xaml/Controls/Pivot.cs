// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Pivot
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IPivotStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPivotStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IPivotFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPivotStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class Pivot : ItemsControl, IPivot, IPivot2, IPivot3
  {
    [MethodImpl]
    public extern Pivot();

    public extern object Title { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate TitleTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLocked { [MethodImpl] get; [MethodImpl] set; }

    public extern event SelectionChangedEventHandler SelectionChanged;

    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoading;

    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoaded;

    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloading;

    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloaded;

    public extern object LeftHeader { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate LeftHeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern object RightHeader { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate RightHeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern PivotHeaderFocusVisualPlacement HeaderFocusVisualPlacement { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHeaderItemsCarouselEnabled { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty HeaderFocusVisualPlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsHeaderItemsCarouselEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty LeftHeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty LeftHeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty RightHeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty RightHeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    public static extern DependencyProperty TitleTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsLockedProperty { [MethodImpl] get; }

    public static extern DependencyProperty SlideInAnimationGroupProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern PivotSlideInAnimationGroup GetSlideInAnimationGroup(
      FrameworkElement element);

    [MethodImpl]
    public static extern void SetSlideInAnimationGroup(
      FrameworkElement element,
      PivotSlideInAnimationGroup value);
  }
}
