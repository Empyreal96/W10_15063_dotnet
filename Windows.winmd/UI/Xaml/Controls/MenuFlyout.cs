// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [ContentProperty(Name = "Items")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IMenuFlyoutFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMenuFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class MenuFlyout : FlyoutBase, IMenuFlyout, IMenuFlyout2
  {
    [MethodImpl]
    public extern MenuFlyout();

    public extern IVector<MenuFlyoutItemBase> Items { [MethodImpl] get; }

    public extern Style MenuFlyoutPresenterStyle { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void ShowAt(UIElement targetElement, Point point);

    public static extern DependencyProperty MenuFlyoutPresenterStyleProperty { [MethodImpl] get; }
  }
}
