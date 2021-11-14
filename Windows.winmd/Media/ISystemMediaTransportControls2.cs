// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControls2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3935884022, 32572, 19186, 165, 134, 114, 136, 152, 8, 239, 177)]
  [ExclusiveTo(typeof (SystemMediaTransportControls))]
  internal interface ISystemMediaTransportControls2
  {
    MediaPlaybackAutoRepeatMode AutoRepeatMode { get; set; }

    bool ShuffleEnabled { get; set; }

    double PlaybackRate { get; set; }

    void UpdateTimelineProperties(
      SystemMediaTransportControlsTimelineProperties timelineProperties);

    event TypedEventHandler<SystemMediaTransportControls, PlaybackPositionChangeRequestedEventArgs> PlaybackPositionChangeRequested;

    event TypedEventHandler<SystemMediaTransportControls, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    event TypedEventHandler<SystemMediaTransportControls, ShuffleEnabledChangeRequestedEventArgs> ShuffleEnabledChangeRequested;

    event TypedEventHandler<SystemMediaTransportControls, AutoRepeatModeChangeRequestedEventArgs> AutoRepeatModeChangeRequested;
  }
}
