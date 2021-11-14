// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IInkToolbarFlyoutItemStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IInkToolbarFlyoutItemFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarFlyoutItem : ButtonBase, IInkToolbarFlyoutItem
  {
    [MethodImpl]
    public extern InkToolbarFlyoutItem();

    public extern InkToolbarFlyoutItemKind Kind { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsChecked { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<InkToolbarFlyoutItem, object> Checked;

    public extern event TypedEventHandler<InkToolbarFlyoutItem, object> Unchecked;

    public static extern DependencyProperty KindProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsCheckedProperty { [MethodImpl] get; }
  }
}
