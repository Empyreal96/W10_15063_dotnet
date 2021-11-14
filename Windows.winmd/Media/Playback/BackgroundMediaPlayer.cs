// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.BackgroundMediaPlayer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Static(typeof (IBackgroundMediaPlayerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public static class BackgroundMediaPlayer
  {
    public static extern MediaPlayer Current { [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromBackground;

    public static extern event EventHandler<MediaPlayerDataReceivedEventArgs> MessageReceivedFromForeground;

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void SendMessageToBackground(ValueSet value);

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void SendMessageToForeground(ValueSet value);

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool IsMediaPlaying();

    [Deprecated("Use MediaPlayer instead of BackgroundMediaPlayer.  For more info, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void Shutdown();
  }
}
