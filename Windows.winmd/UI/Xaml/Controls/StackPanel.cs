// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.StackPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IStackPanelStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IStackPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStackPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class StackPanel : Panel, IStackPanel, IScrollSnapPointsInfo, IStackPanel2, IInsertionPanel
  {
    [MethodImpl]
    public extern StackPanel();

    public extern bool AreScrollSnapPointsRegular { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

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

    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void GetInsertionIndexes(Point position, out int first, out int second);

    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty AreScrollSnapPointsRegularProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }
  }
}
