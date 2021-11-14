// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.MediaPlayer
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public static class MediaPlayer
  {
    private static MediaFinalizerHelper mediaHelper;
    private static bool shuffle = false;
    private static bool repeat = false;
    private static MediaQueue queue = new MediaQueue();

    [SecuritySafeCritical]
    static MediaPlayer()
    {
      UserAsyncDispatcher.Initialize();
      MediaPlayer.mediaHelper = new MediaFinalizerHelper();
      int shuffle = (int) UnsafeNativeMethods.MediaQueue_GetShuffle(ref MediaPlayer.shuffle);
      int repeat = (int) UnsafeNativeMethods.MediaQueue_GetRepeat(ref MediaPlayer.repeat);
    }

    public static void Play(Song song) => MediaPlayer.queue.Play(song);

    public static void Play(SongCollection songs) => MediaPlayer.queue.Play(songs);

    public static void Play(SongCollection songs, int index) => MediaPlayer.queue.Play(songs, index);

    [SecuritySafeCritical]
    public static void Pause()
    {
      if (MediaPlayer.State != MediaState.Playing)
        return;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_Pause());
    }

    [SecuritySafeCritical]
    public static void Resume()
    {
      if (MediaPlayer.State == MediaState.Playing)
        return;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_Resume());
    }

    [SecuritySafeCritical]
    public static void Stop()
    {
      if (MediaPlayer.State == MediaState.Stopped)
        return;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_Stop());
    }

    public static void MoveNext() => MediaPlayer.queue.MoveNext();

    public static void MovePrevious() => MediaPlayer.queue.MovePrevious();

    public static bool IsShuffled
    {
      [SecuritySafeCritical] get
      {
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetShuffle(ref MediaPlayer.shuffle));
        return MediaPlayer.shuffle;
      }
      [SecuritySafeCritical] set
      {
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_SetShuffle(value));
        MediaPlayer.shuffle = value;
      }
    }

    public static bool IsRepeating
    {
      [SecuritySafeCritical] get
      {
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetRepeat(ref MediaPlayer.repeat));
        return MediaPlayer.repeat;
      }
      [SecuritySafeCritical] set
      {
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_SetRepeat(value));
        MediaPlayer.repeat = value;
      }
    }

    public static MediaQueue Queue => MediaPlayer.queue;

    public static MediaState State
    {
      [SecuritySafeCritical] get
      {
        MediaState state = MediaState.Stopped;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetPlayState(ref state));
        return state;
      }
    }

    public static TimeSpan PlayPosition => MediaPlayer.queue.PlayPosition;

    public static float Volume
    {
      [SecuritySafeCritical] get
      {
        float volume = 0.0f;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetVolume(ref volume));
        return volume;
      }
      [SecuritySafeCritical] set
      {
        value = (double) value < 0.0 ? 0.0f : value;
        value = (double) value > 1.0 ? 1f : value;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_SetVolume(value));
      }
    }

    public static bool IsMuted
    {
      [SecuritySafeCritical] get
      {
        bool muted = false;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_IsMuted(ref muted));
        return muted;
      }
      [SecuritySafeCritical] set => Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_SetMute(value));
    }

    public static bool IsVisualizationEnabled
    {
      [SecuritySafeCritical] get => false;
      [SecuritySafeCritical] set
      {
      }
    }

    public static bool GameHasControl
    {
      [SecuritySafeCritical] get
      {
        bool gameHasControl = false;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaPlayer_GameHasControl(ref gameHasControl));
        return gameHasControl;
      }
    }

    [SecuritySafeCritical]
    public static void GetVisualizationData(VisualizationData visualizationData)
    {
      if (visualizationData == null)
        throw new ArgumentNullException(nameof (visualizationData), FrameworkResources.NullNotAllowed);
      if (!MediaPlayer.IsVisualizationEnabled)
        return;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetVisualizationData(visualizationData.frequencies, visualizationData.frequencies.Length, visualizationData.samples, visualizationData.samples.Length));
    }

    public static event EventHandler<EventArgs> ActiveSongChanged;

    internal static void OnActiveSongChanged(EventArgs args)
    {
      EventHandler<EventArgs> activeSongChanged = MediaPlayer.ActiveSongChanged;
      if (activeSongChanged == null)
        return;
      activeSongChanged((object) null, args);
    }

    public static event EventHandler<EventArgs> MediaStateChanged;

    internal static void OnMediaStateChanged(EventArgs args)
    {
      EventHandler<EventArgs> mediaStateChanged = MediaPlayer.MediaStateChanged;
      if (mediaStateChanged == null)
        return;
      mediaStateChanged((object) null, args);
    }
  }
}
