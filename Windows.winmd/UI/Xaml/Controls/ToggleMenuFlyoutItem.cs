// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IToggleMenuFlyoutItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IToggleMenuFlyoutItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class ToggleMenuFlyoutItem : MenuFlyoutItem, IToggleMenuFlyoutItem
  {
    [MethodImpl]
    public extern ToggleMenuFlyoutItem();

    public extern bool IsChecked { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsCheckedProperty { [MethodImpl] get; }
  }
}
