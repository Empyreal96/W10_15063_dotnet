// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GradientBrush))]
  [Guid(560391839, 37722, 16785, 142, 60, 28, 141, 253, 252, 220, 120)]
  [WebHostHidden]
  internal interface IGradientBrush
  {
    GradientSpreadMethod SpreadMethod { get; set; }

    BrushMappingMode MappingMode { get; set; }

    ColorInterpolationMode ColorInterpolationMode { get; set; }

    GradientStopCollection GradientStops { get; set; }
  }
}
