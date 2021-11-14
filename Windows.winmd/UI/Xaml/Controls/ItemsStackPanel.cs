// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsStackPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IItemsStackPanelStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IItemsStackPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ItemsStackPanel : Panel, IItemsStackPanel, IItemsStackPanel2
  {
    [MethodImpl]
    public extern ItemsStackPanel();

    public extern Thickness GroupPadding { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern int FirstCacheIndex { [MethodImpl] get; }

    public extern int FirstVisibleIndex { [MethodImpl] get; }

    public extern int LastVisibleIndex { [MethodImpl] get; }

    public extern int LastCacheIndex { [MethodImpl] get; }

    public extern PanelScrollingDirection ScrollingDirection { [MethodImpl] get; }

    public extern GroupHeaderPlacement GroupHeaderPlacement { [MethodImpl] get; [MethodImpl] set; }

    public extern ItemsUpdatingScrollMode ItemsUpdatingScrollMode { [MethodImpl] get; [MethodImpl] set; }

    public extern double CacheLength { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AreStickyGroupHeadersEnabled { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty AreStickyGroupHeadersEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty GroupPaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty GroupHeaderPlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty CacheLengthProperty { [MethodImpl] get; }
  }
}
