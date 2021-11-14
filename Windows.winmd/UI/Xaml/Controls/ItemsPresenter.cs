// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsPresenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IItemsPresenterStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IItemsPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ItemsPresenter : 
    FrameworkElement,
    IItemsPresenter,
    IScrollSnapPointsInfo,
    IItemsPresenter2
  {
    [MethodImpl]
    public extern ItemsPresenter();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection HeaderTransitions { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

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

    public extern object Footer { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate FooterTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection FooterTransitions { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FooterProperty { [MethodImpl] get; }

    public static extern DependencyProperty FooterTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty FooterTransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTransitionsProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }
  }
}
