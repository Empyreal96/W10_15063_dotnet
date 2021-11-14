// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Use MediaPlaybackState instead of MediaPlayerState.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public enum MediaPlayerState
  {
    Closed,
    Opening,
    Buffering,
    Playing,
    Paused,
    Stopped,
  }
}
