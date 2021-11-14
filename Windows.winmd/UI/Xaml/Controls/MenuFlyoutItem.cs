// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Text")]
  [Static(typeof (IMenuFlyoutItemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IMenuFlyoutItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMenuFlyoutItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class MenuFlyoutItem : MenuFlyoutItemBase, IMenuFlyoutItem, IMenuFlyoutItem2
  {
    [MethodImpl]
    public extern MenuFlyoutItem();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    public extern object CommandParameter { [MethodImpl] get; [MethodImpl] set; }

    public extern event RoutedEventHandler Click;

    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }

    public static extern DependencyProperty CommandParameterProperty { [MethodImpl] get; }
  }
}
