// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VirtualizingStackPanel
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IVirtualizingStackPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class VirtualizingStackPanel : 
    OrientedVirtualizingPanel,
    IVirtualizingStackPanel,
    IVirtualizingStackPanelOverrides
  {
    [MethodImpl]
    public extern VirtualizingStackPanel();

    public extern bool AreScrollSnapPointsRegular { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;

    [MethodImpl]
    extern void IVirtualizingStackPanelOverrides.OnCleanUpVirtualizedItem(
      CleanUpVirtualizedItemEventArgs e);

    public static extern DependencyProperty AreScrollSnapPointsRegularProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty VirtualizationModeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern VirtualizationMode GetVirtualizationMode(
      DependencyObject element);

    [MethodImpl]
    public static extern void SetVirtualizationMode(
      DependencyObject element,
      VirtualizationMode value);

    public static extern DependencyProperty IsVirtualizingProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsVirtualizing(DependencyObject o);
  }
}
