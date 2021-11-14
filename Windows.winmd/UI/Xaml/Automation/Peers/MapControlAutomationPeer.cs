// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MapControlAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class MapControlAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMapControlAutomationPeer,
    IScrollProvider,
    ITransformProvider2,
    ITransformProvider
  {
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

    public extern bool CanZoom { [MethodImpl] get; }

    public extern double ZoomLevel { [MethodImpl] get; }

    public extern double MaxZoom { [MethodImpl] get; }

    public extern double MinZoom { [MethodImpl] get; }

    [MethodImpl]
    public extern void Zoom(double zoom);

    [MethodImpl]
    public extern void ZoomByUnit(ZoomUnit zoomUnit);

    public extern bool CanMove { [MethodImpl] get; }

    public extern bool CanResize { [MethodImpl] get; }

    public extern bool CanRotate { [MethodImpl] get; }

    [MethodImpl]
    public extern void Move(double x, double y);

    [MethodImpl]
    public extern void Resize(double width, double height);

    [MethodImpl]
    public extern void Rotate(double degrees);
  }
}
