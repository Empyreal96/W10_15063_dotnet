// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(3993395418, 795, 20459, 189, 155, 146, 224, 160, 168, 210, 153)]
  internal interface IMediaPlayer3
  {
    event TypedEventHandler<MediaPlayer, object> IsMutedChanged;

    event TypedEventHandler<MediaPlayer, object> SourceChanged;

    double AudioBalance { get; set; }

    bool RealTimePlayback { get; set; }

    StereoscopicVideoRenderMode StereoscopicVideoRenderMode { get; set; }

    MediaBreakManager BreakManager { get; }

    MediaPlaybackCommandManager CommandManager { get; }

    DeviceInformation AudioDevice { get; set; }

    MediaTimelineController TimelineController { get; set; }

    TimeSpan TimelineControllerPositionOffset { get; set; }

    MediaPlaybackSession PlaybackSession { get; }

    void StepForwardOneFrame();

    void StepBackwardOneFrame();

    CastingSource GetAsCastingSource();
  }
}
