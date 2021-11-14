// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.MediaQueue
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class MediaQueue
  {
    internal MediaQueue()
    {
    }

    [SecuritySafeCritical]
    internal void Play(Song song)
    {
      if (song == (Song) null)
        throw new ArgumentNullException(nameof (song), FrameworkResources.NullNotAllowed);
      ErrorCodes error = !song.IsGameSong ? (!song.IsValidHandle ? ErrorCodes.E_FAIL : UnsafeNativeMethods.MediaQueue_PlaySong(song.Handle)) : UnsafeNativeMethods.MediaQueue_PlaySongFromFile(song.Name, (uint) song.Name.Length, song.FileName, (uint) song.FileName.Length, (int) song.Duration.TotalMilliseconds);
      if (Helpers.Failed(error))
        throw new InvalidOperationException(FrameworkResources.SongPlaybackFailed, Helpers.GetExceptionFromResult((uint) error));
    }

    [SecuritySafeCritical]
    internal void Play(SongCollection songCollection)
    {
      if (songCollection == null)
        throw new ArgumentNullException(nameof (songCollection), FrameworkResources.NullNotAllowed);
      if (songCollection.Count == 0)
        throw new ArgumentException(FrameworkResources.EmptySongCollectionsCannotBePlayed, nameof (songCollection));
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_PlaySongList(songCollection.Handle, -1));
    }

    [SecuritySafeCritical]
    internal void Play(SongCollection songCollection, int index)
    {
      if (songCollection == null)
        throw new ArgumentNullException(nameof (songCollection), FrameworkResources.NullNotAllowed);
      if (songCollection.Count == 0)
        throw new ArgumentException(FrameworkResources.EmptySongCollectionsCannotBePlayed, nameof (songCollection));
      if (index < 0 || index >= songCollection.Count)
        throw new ArgumentOutOfRangeException(nameof (index), FrameworkResources.MustBeValidIndex);
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_PlaySongList(songCollection.Handle, index));
    }

    [SecuritySafeCritical]
    internal void MoveNext()
    {
      if (this.Count <= 0)
        return;
      if (this.ActiveSongIndex < this.Count - 1)
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_MoveNext());
      else
        this.ActiveSongIndex = 0;
    }

    [SecuritySafeCritical]
    internal void MovePrevious()
    {
      if (this.Count <= 0)
        return;
      if (this.ActiveSongIndex > 0)
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_MovePrev());
      else
        this.ActiveSongIndex = this.Count - 1;
    }

    public int Count
    {
      [SecuritySafeCritical] get
      {
        int songCount = 0;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetSongCount(ref songCount));
        return songCount;
      }
    }

    public int ActiveSongIndex
    {
      [SecuritySafeCritical] get
      {
        int songIndex = -1;
        if (this.Count != 0)
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetActiveSongIndex(ref songIndex));
        return songIndex;
      }
      [SecuritySafeCritical] set
      {
        value = value < 0 ? 0 : value;
        value = value > this.Count - 1 ? this.Count - 1 : value;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_MoveTo(value));
      }
    }

    public Song ActiveSong
    {
      [SecuritySafeCritical] get
      {
        Song song = (Song) null;
        uint maxValue = uint.MaxValue;
        if (UnsafeNativeMethods.MediaQueue_GetActiveSong(ref maxValue) == ErrorCodes.Success)
          song = new Song(maxValue);
        return song;
      }
    }

    public Song this[int index]
    {
      [SecuritySafeCritical] get
      {
        if (index < 0 || index >= this.Count)
          throw new ArgumentOutOfRangeException(nameof (index), FrameworkResources.MustBeValidIndex);
        uint maxValue = uint.MaxValue;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetSongAtIndex(index, ref maxValue));
        return new Song(maxValue);
      }
    }

    internal TimeSpan PlayPosition
    {
      [SecuritySafeCritical] get
      {
        TimeSpan timeSpan = new TimeSpan(0L);
        if (this.ActiveSongIndex != -1)
        {
          int position = 0;
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaQueue_GetPlayPosition(ref position));
          timeSpan = new TimeSpan(0, 0, 0, 0, position);
        }
        return timeSpan;
      }
    }
  }
}
