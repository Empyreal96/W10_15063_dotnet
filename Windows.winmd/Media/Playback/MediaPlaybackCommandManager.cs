// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackCommandManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaPlaybackCommandManager : IMediaPlaybackCommandManager
  {
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior PlayBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior PauseBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior NextBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior PreviousBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior FastForwardBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior RewindBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior ShuffleBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior AutoRepeatModeBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior PositionBehavior { [MethodImpl] get; }

    public extern MediaPlaybackCommandManagerCommandBehavior RateBehavior { [MethodImpl] get; }

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPlayReceivedEventArgs> PlayReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPauseReceivedEventArgs> PauseReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerNextReceivedEventArgs> NextReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPreviousReceivedEventArgs> PreviousReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerFastForwardReceivedEventArgs> FastForwardReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRewindReceivedEventArgs> RewindReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerShuffleReceivedEventArgs> ShuffleReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs> AutoRepeatModeReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPositionReceivedEventArgs> PositionReceived;

    public extern event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRateReceivedEventArgs> RateReceived;
  }
}
