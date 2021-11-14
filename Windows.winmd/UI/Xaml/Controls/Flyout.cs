// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Flyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IFlyoutFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  public class Flyout : FlyoutBase, IFlyout
  {
    [MethodImpl]
    public extern Flyout();

    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    public extern Style FlyoutPresenterStyle { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty FlyoutPresenterStyleProperty { [MethodImpl] get; }
  }
}
