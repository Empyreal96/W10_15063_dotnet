// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IOrientedVirtualizingPanelFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class OrientedVirtualizingPanel : 
    VirtualizingPanel,
    IOrientedVirtualizingPanel,
    IScrollSnapPointsInfo,
    IInsertionPanel
  {
    public extern bool CanVerticallyScroll { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanHorizontallyScroll { [MethodImpl] get; [MethodImpl] set; }

    public extern double ExtentWidth { [MethodImpl] get; }

    public extern double ExtentHeight { [MethodImpl] get; }

    public extern double ViewportWidth { [MethodImpl] get; }

    public extern double ViewportHeight { [MethodImpl] get; }

    public extern double HorizontalOffset { [MethodImpl] get; }

    public extern double VerticalOffset { [MethodImpl] get; }

    public extern object ScrollOwner { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void LineUp();

    [MethodImpl]
    public extern void LineDown();

    [MethodImpl]
    public extern void LineLeft();

    [MethodImpl]
    public extern void LineRight();

    [MethodImpl]
    public extern void PageUp();

    [MethodImpl]
    public extern void PageDown();

    [MethodImpl]
    public extern void PageLeft();

    [MethodImpl]
    public extern void PageRight();

    [MethodImpl]
    public extern void MouseWheelUp();

    [MethodImpl]
    public extern void MouseWheelDown();

    [MethodImpl]
    public extern void MouseWheelLeft();

    [MethodImpl]
    public extern void MouseWheelRight();

    [MethodImpl]
    public extern void SetHorizontalOffset(double offset);

    [MethodImpl]
    public extern void SetVerticalOffset(double offset);

    [MethodImpl]
    public extern Rect MakeVisible(UIElement visual, Rect rectangle);

    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    public extern event EventHandler<object> VerticalSnapPointsChanged;

    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    [MethodImpl]
    public extern float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);

    [MethodImpl]
    public extern void GetInsertionIndexes(Point position, out int first, out int second);
  }
}
