// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwapChainPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISwapChainPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISwapChainPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class SwapChainPanel : Grid, ISwapChainPanel
  {
    [MethodImpl]
    public extern SwapChainPanel();

    public extern float CompositionScaleX { [MethodImpl] get; }

    public extern float CompositionScaleY { [MethodImpl] get; }

    public extern event TypedEventHandler<SwapChainPanel, object> CompositionScaleChanged;

    [MethodImpl]
    public extern CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);

    public static extern DependencyProperty CompositionScaleXProperty { [MethodImpl] get; }

    public static extern DependencyProperty CompositionScaleYProperty { [MethodImpl] get; }
  }
}
