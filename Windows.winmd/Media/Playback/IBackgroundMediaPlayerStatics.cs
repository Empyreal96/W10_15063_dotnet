// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IBackgroundMediaPlayerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (BackgroundMediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2238569409, 22007, 18207, 160, 242, 104, 172, 76, 144, 69, 146)]
  internal interface IBackgroundMediaPlayerStatics
  {
    MediaPlayer Current { [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromBackground;

    event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromForeground;

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void SendMessageToBackground(ValueSet value);

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void SendMessageToForeground(ValueSet value);

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool IsMediaPlaying();

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Shutdown();
  }
}
