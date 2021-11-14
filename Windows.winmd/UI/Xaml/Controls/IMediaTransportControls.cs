// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControls
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3606486653, 2085, 18857, 159, 206, 85, 134, 216, 105, 79, 12)]
  [ExclusiveTo(typeof (MediaTransportControls))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaTransportControls
  {
    bool IsFullWindowButtonVisible { get; set; }

    bool IsFullWindowEnabled { get; set; }

    bool IsZoomButtonVisible { get; set; }

    bool IsZoomEnabled { get; set; }

    bool IsFastForwardButtonVisible { get; set; }

    bool IsFastForwardEnabled { get; set; }

    bool IsFastRewindButtonVisible { get; set; }

    bool IsFastRewindEnabled { get; set; }

    bool IsStopButtonVisible { get; set; }

    bool IsStopEnabled { get; set; }

    bool IsVolumeButtonVisible { get; set; }

    bool IsVolumeEnabled { get; set; }

    bool IsPlaybackRateButtonVisible { get; set; }

    bool IsPlaybackRateEnabled { get; set; }

    bool IsSeekBarVisible { get; set; }

    bool IsSeekEnabled { get; set; }

    bool IsCompact { get; set; }
  }
}
