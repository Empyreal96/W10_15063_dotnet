// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ScrollViewerAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IScrollViewerAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ScrollViewerAutomationPeer : 
    FrameworkElementAutomationPeer,
    IScrollViewerAutomationPeer,
    IScrollProvider
  {
    [MethodImpl]
    public extern ScrollViewerAutomationPeer(ScrollViewer owner);

    public extern bool HorizontallyScrollable { [MethodImpl] get; }

    public extern double HorizontalScrollPercent { [MethodImpl] get; }

    public extern double HorizontalViewSize { [MethodImpl] get; }

    public extern bool VerticallyScrollable { [MethodImpl] get; }

    public extern double VerticalScrollPercent { [MethodImpl] get; }

    public extern double VerticalViewSize { [MethodImpl] get; }

    [MethodImpl]
    public extern void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

    [MethodImpl]
    public extern void SetScrollPercent(double horizontalPercent, double verticalPercent);
  }
}
