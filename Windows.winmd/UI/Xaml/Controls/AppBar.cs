// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBar
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
  [Static(typeof (IAppBarStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IAppBarFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAppBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppBarStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public class AppBar : 
    ContentControl,
    IAppBar,
    IAppBarOverrides,
    IAppBar2,
    IAppBar3,
    IAppBarOverrides3,
    IAppBar4
  {
    [MethodImpl]
    public extern AppBar();

    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSticky { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<object> Opened;

    public extern event EventHandler<object> Closed;

    [MethodImpl]
    extern void IAppBarOverrides.OnClosed(object e);

    [MethodImpl]
    extern void IAppBarOverrides.OnOpened(object e);

    public extern AppBarClosedDisplayMode ClosedDisplayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern AppBarTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern event EventHandler<object> Opening;

    public extern event EventHandler<object> Closing;

    [MethodImpl]
    extern void IAppBarOverrides3.OnClosing(object e);

    [MethodImpl]
    extern void IAppBarOverrides3.OnOpening(object e);

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ClosedDisplayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsStickyProperty { [MethodImpl] get; }
  }
}
