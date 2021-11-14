// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.FlipView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IFlipViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFlipViewStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public class FlipView : Selector, IFlipView, IFlipView2
  {
    [MethodImpl]
    public extern FlipView();

    public extern bool UseTouchAnimationsForAllNavigation { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty UseTouchAnimationsForAllNavigationProperty { [MethodImpl] get; }
  }
}
