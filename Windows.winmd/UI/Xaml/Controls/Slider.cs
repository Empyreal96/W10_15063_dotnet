// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Slider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (ISliderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISliderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISliderFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Slider : RangeBase, ISlider, ISlider2
  {
    [MethodImpl]
    public extern Slider();

    public extern double IntermediateValue { [MethodImpl] get; [MethodImpl] set; }

    public extern double StepFrequency { [MethodImpl] get; [MethodImpl] set; }

    public extern SliderSnapsTo SnapsTo { [MethodImpl] get; [MethodImpl] set; }

    public extern double TickFrequency { [MethodImpl] get; [MethodImpl] set; }

    public extern TickPlacement TickPlacement { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDirectionReversed { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsThumbToolTipEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern IValueConverter ThumbToolTipValueConverter { [MethodImpl] get; [MethodImpl] set; }

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty IntermediateValueProperty { [MethodImpl] get; }

    public static extern DependencyProperty StepFrequencyProperty { [MethodImpl] get; }

    public static extern DependencyProperty SnapsToProperty { [MethodImpl] get; }

    public static extern DependencyProperty TickFrequencyProperty { [MethodImpl] get; }

    public static extern DependencyProperty TickPlacementProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsDirectionReversedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsThumbToolTipEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty ThumbToolTipValueConverterProperty { [MethodImpl] get; }
  }
}
