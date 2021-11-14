// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISlider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Slider))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2304188455, 19528, 18176, 128, 118, 73, 123, 167, 61, 156, 24)]
  internal interface ISlider
  {
    double IntermediateValue { get; set; }

    double StepFrequency { get; set; }

    SliderSnapsTo SnapsTo { get; set; }

    double TickFrequency { get; set; }

    TickPlacement TickPlacement { get; set; }

    Orientation Orientation { get; set; }

    bool IsDirectionReversed { get; set; }

    bool IsThumbToolTipEnabled { get; set; }

    IValueConverter ThumbToolTipValueConverter { get; set; }
  }
}
