// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Panel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContentProperty(Name = "Children")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IPanelFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class Panel : FrameworkElement, IPanel
  {
    [MethodImpl]
    protected extern Panel();

    public extern UIElementCollection Children { [MethodImpl] get; }

    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsItemsHost { [MethodImpl] get; }

    public extern TransitionCollection ChildrenTransitions { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsItemsHostProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildrenTransitionsProperty { [MethodImpl] get; }
  }
}
