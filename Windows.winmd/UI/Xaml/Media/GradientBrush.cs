// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IGradientBrushFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGradientBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "GradientStops")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class GradientBrush : Brush, IGradientBrush
  {
    [MethodImpl]
    protected extern GradientBrush();

    public extern GradientSpreadMethod SpreadMethod { [MethodImpl] get; [MethodImpl] set; }

    public extern BrushMappingMode MappingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern ColorInterpolationMode ColorInterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    public extern GradientStopCollection GradientStops { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SpreadMethodProperty { [MethodImpl] get; }

    public static extern DependencyProperty MappingModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ColorInterpolationModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty GradientStopsProperty { [MethodImpl] get; }
  }
}
