// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SplitView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISplitViewStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (ISplitViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISplitViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  public class SplitView : Control, ISplitView, ISplitView2
  {
    [MethodImpl]
    public extern SplitView();

    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    public extern UIElement Pane { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPaneOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern double OpenPaneLength { [MethodImpl] get; [MethodImpl] set; }

    public extern double CompactPaneLength { [MethodImpl] get; [MethodImpl] set; }

    public extern SplitViewPanePlacement PanePlacement { [MethodImpl] get; [MethodImpl] set; }

    public extern SplitViewDisplayMode DisplayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern SplitViewTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern Brush PaneBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<SplitView, SplitViewPaneClosingEventArgs> PaneClosing;

    public extern event TypedEventHandler<SplitView, object> PaneClosed;

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaneProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsPaneOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty OpenPaneLengthProperty { [MethodImpl] get; }

    public static extern DependencyProperty CompactPaneLengthProperty { [MethodImpl] get; }

    public static extern DependencyProperty PanePlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TemplateSettingsProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaneBackgroundProperty { [MethodImpl] get; }
  }
}
