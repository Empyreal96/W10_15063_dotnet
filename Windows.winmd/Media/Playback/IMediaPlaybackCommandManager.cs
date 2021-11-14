// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManager))]
  [Guid(1523508646, 23734, 19034, 133, 33, 204, 134, 177, 193, 237, 55)]
  internal interface IMediaPlaybackCommandManager
  {
    bool IsEnabled { get; set; }

    MediaPlayer MediaPlayer { get; }

    MediaPlaybackCommandManagerCommandBehavior PlayBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior PauseBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior NextBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior PreviousBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior FastForwardBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior RewindBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior ShuffleBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior AutoRepeatModeBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior PositionBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior RateBehavior { get; }

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPlayReceivedEventArgs> PlayReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPauseReceivedEventArgs> PauseReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerNextReceivedEventArgs> NextReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPreviousReceivedEventArgs> PreviousReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerFastForwardReceivedEventArgs> FastForwardReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRewindReceivedEventArgs> RewindReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerShuffleReceivedEventArgs> ShuffleReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs> AutoRepeatModeReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPositionReceivedEventArgs> PositionReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRateReceivedEventArgs> RateReceived;
  }
}
