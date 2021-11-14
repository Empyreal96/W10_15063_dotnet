// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.Popup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPopupStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Child")]
  [Static(typeof (IPopupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Popup : FrameworkElement, IPopup, IPopup2
  {
    [MethodImpl]
    public extern Popup();

    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection ChildTransitions { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLightDismissEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<object> Opened;

    public extern event EventHandler<object> Closed;

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildTransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsLightDismissEnabledProperty { [MethodImpl] get; }
  }
}
