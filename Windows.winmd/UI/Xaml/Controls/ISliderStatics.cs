// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISliderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Slider))]
  [WebHostHidden]
  [Guid(2319672279, 32735, 19760, 152, 254, 206, 120, 192, 91, 49, 207)]
  internal interface ISliderStatics
  {
    DependencyProperty IntermediateValueProperty { get; }

    DependencyProperty StepFrequencyProperty { get; }

    DependencyProperty SnapsToProperty { get; }

    DependencyProperty TickFrequencyProperty { get; }

    DependencyProperty TickPlacementProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty IsDirectionReversedProperty { get; }

    DependencyProperty IsThumbToolTipEnabledProperty { get; }

    DependencyProperty ThumbToolTipValueConverterProperty { get; }
  }
}
