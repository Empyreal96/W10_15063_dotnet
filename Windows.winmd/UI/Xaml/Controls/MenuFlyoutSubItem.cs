// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyoutSubItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMenuFlyoutSubItemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Items")]
  [Static(typeof (IMenuFlyoutSubItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class MenuFlyoutSubItem : MenuFlyoutItemBase, IMenuFlyoutSubItem, IMenuFlyoutSubItem2
  {
    [MethodImpl]
    public extern MenuFlyoutSubItem();

    public extern IVector<MenuFlyoutItemBase> Items { [MethodImpl] get; }

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextProperty { [MethodImpl] get; }
  }
}
