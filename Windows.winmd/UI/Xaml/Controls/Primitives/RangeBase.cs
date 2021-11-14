// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.RangeBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IRangeBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRangeBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class RangeBase : Control, IRangeBase, IRangeBaseOverrides
  {
    [MethodImpl]
    protected extern RangeBase();

    public extern double Minimum { [MethodImpl] get; [MethodImpl] set; }

    public extern double Maximum { [MethodImpl] get; [MethodImpl] set; }

    public extern double SmallChange { [MethodImpl] get; [MethodImpl] set; }

    public extern double LargeChange { [MethodImpl] get; [MethodImpl] set; }

    public extern double Value { [MethodImpl] get; [MethodImpl] set; }

    public extern event RangeBaseValueChangedEventHandler ValueChanged;

    [MethodImpl]
    extern void IRangeBaseOverrides.OnMinimumChanged(
      double oldMinimum,
      double newMinimum);

    [MethodImpl]
    extern void IRangeBaseOverrides.OnMaximumChanged(
      double oldMaximum,
      double newMaximum);

    [MethodImpl]
    extern void IRangeBaseOverrides.OnValueChanged(
      double oldValue,
      double newValue);

    public static extern DependencyProperty MinimumProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaximumProperty { [MethodImpl] get; }

    public static extern DependencyProperty SmallChangeProperty { [MethodImpl] get; }

    public static extern DependencyProperty LargeChangeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ValueProperty { [MethodImpl] get; }
  }
}
