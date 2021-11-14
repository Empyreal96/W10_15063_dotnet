// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.FlyoutBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Static(typeof (IFlyoutBaseStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFlyoutBaseStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IFlyoutBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IFlyoutBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class FlyoutBase : 
    DependencyObject,
    IFlyoutBase,
    IFlyoutBaseOverrides,
    IFlyoutBase2,
    IFlyoutBase3
  {
    [MethodImpl]
    protected extern FlyoutBase();

    public extern FlyoutPlacementMode Placement { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<object> Opened;

    public extern event EventHandler<object> Closed;

    public extern event EventHandler<object> Opening;

    [MethodImpl]
    public extern void ShowAt(FrameworkElement placementTarget);

    [MethodImpl]
    public extern void Hide();

    [MethodImpl]
    extern Control IFlyoutBaseOverrides.CreatePresenter();

    public extern FrameworkElement Target { [MethodImpl] get; }

    public extern bool AllowFocusOnInteraction { [MethodImpl] get; [MethodImpl] set; }

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowFocusWhenDisabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<FlyoutBase, FlyoutBaseClosingEventArgs> Closing;

    public extern DependencyObject OverlayInputPassThroughElement { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty OverlayInputPassThroughElementProperty { [MethodImpl] get; }

    public static extern DependencyProperty AllowFocusOnInteractionProperty { [MethodImpl] get; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty AllowFocusWhenDisabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty ElementSoundModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty AttachedFlyoutProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern FlyoutBase GetAttachedFlyout(FrameworkElement element);

    [MethodImpl]
    public static extern void SetAttachedFlyout(FrameworkElement element, FlyoutBase value);

    [MethodImpl]
    public static extern void ShowAttachedFlyout(FrameworkElement flyoutOwner);
  }
}
