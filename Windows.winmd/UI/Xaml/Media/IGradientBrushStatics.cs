// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientBrushStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (GradientBrush))]
  [Guid(2518049273, 35764, 20076, 185, 35, 181, 215, 135, 224, 241, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IGradientBrushStatics
  {
    DependencyProperty SpreadMethodProperty { get; }

    DependencyProperty MappingModeProperty { get; }

    DependencyProperty ColorInterpolationModeProperty { get; }

    DependencyProperty GradientStopsProperty { get; }
  }
}
