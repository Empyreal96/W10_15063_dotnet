// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MediaTransportControls))]
  [Guid(1494132999, 53999, 19482, 148, 41, 180, 177, 93, 100, 253, 86)]
  internal interface IMediaTransportControlsStatics
  {
    DependencyProperty IsFullWindowButtonVisibleProperty { get; }

    DependencyProperty IsFullWindowEnabledProperty { get; }

    DependencyProperty IsZoomButtonVisibleProperty { get; }

    DependencyProperty IsZoomEnabledProperty { get; }

    DependencyProperty IsFastForwardButtonVisibleProperty { get; }

    DependencyProperty IsFastForwardEnabledProperty { get; }

    DependencyProperty IsFastRewindButtonVisibleProperty { get; }

    DependencyProperty IsFastRewindEnabledProperty { get; }

    DependencyProperty IsStopButtonVisibleProperty { get; }

    DependencyProperty IsStopEnabledProperty { get; }

    DependencyProperty IsVolumeButtonVisibleProperty { get; }

    DependencyProperty IsVolumeEnabledProperty { get; }

    DependencyProperty IsPlaybackRateButtonVisibleProperty { get; }

    DependencyProperty IsPlaybackRateEnabledProperty { get; }

    DependencyProperty IsSeekBarVisibleProperty { get; }

    DependencyProperty IsSeekEnabledProperty { get; }

    DependencyProperty IsCompactProperty { get; }
  }
}
