// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RelativePanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IRelativePanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRelativePanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class RelativePanel : Panel, IRelativePanel
  {
    [MethodImpl]
    public extern RelativePanel();

    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LeftOfProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetLeftOf(UIElement element);

    [MethodImpl]
    public static extern void SetLeftOf(UIElement element, object value);

    public static extern DependencyProperty AboveProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAbove(UIElement element);

    [MethodImpl]
    public static extern void SetAbove(UIElement element, object value);

    public static extern DependencyProperty RightOfProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetRightOf(UIElement element);

    [MethodImpl]
    public static extern void SetRightOf(UIElement element, object value);

    public static extern DependencyProperty BelowProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetBelow(UIElement element);

    [MethodImpl]
    public static extern void SetBelow(UIElement element, object value);

    public static extern DependencyProperty AlignHorizontalCenterWithProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAlignHorizontalCenterWith(UIElement element);

    [MethodImpl]
    public static extern void SetAlignHorizontalCenterWith(UIElement element, object value);

    public static extern DependencyProperty AlignVerticalCenterWithProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAlignVerticalCenterWith(UIElement element);

    [MethodImpl]
    public static extern void SetAlignVerticalCenterWith(UIElement element, object value);

    public static extern DependencyProperty AlignLeftWithProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAlignLeftWith(UIElement element);

    [MethodImpl]
    public static extern void SetAlignLeftWith(UIElement element, object value);

    public static extern DependencyProperty AlignTopWithProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAlignTopWith(UIElement element);

    [MethodImpl]
    public static extern void SetAlignTopWith(UIElement element, object value);

    public static extern DependencyProperty AlignRightWithProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAlignRightWith(UIElement element);

    [MethodImpl]
    public static extern void SetAlignRightWith(UIElement element, object value);

    public static extern DependencyProperty AlignBottomWithProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern object GetAlignBottomWith(UIElement element);

    [MethodImpl]
    public static extern void SetAlignBottomWith(UIElement element, object value);

    public static extern DependencyProperty AlignLeftWithPanelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetAlignLeftWithPanel(UIElement element);

    [MethodImpl]
    public static extern void SetAlignLeftWithPanel(UIElement element, bool value);

    public static extern DependencyProperty AlignTopWithPanelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetAlignTopWithPanel(UIElement element);

    [MethodImpl]
    public static extern void SetAlignTopWithPanel(UIElement element, bool value);

    public static extern DependencyProperty AlignRightWithPanelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetAlignRightWithPanel(UIElement element);

    [MethodImpl]
    public static extern void SetAlignRightWithPanel(UIElement element, bool value);

    public static extern DependencyProperty AlignBottomWithPanelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetAlignBottomWithPanel(UIElement element);

    [MethodImpl]
    public static extern void SetAlignBottomWithPanel(UIElement element, bool value);

    public static extern DependencyProperty AlignHorizontalCenterWithPanelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetAlignHorizontalCenterWithPanel(UIElement element);

    [MethodImpl]
    public static extern void SetAlignHorizontalCenterWithPanel(UIElement element, bool value);

    public static extern DependencyProperty AlignVerticalCenterWithPanelProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetAlignVerticalCenterWithPanel(UIElement element);

    [MethodImpl]
    public static extern void SetAlignVerticalCenterWithPanel(UIElement element, bool value);

    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }
  }
}
