// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.Song
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class Song : IEquatable<Song>, IDisposable
  {
    internal static Song Empty = new Song();
    private uint handle = uint.MaxValue;
    private int hashcode = -1;
    private static object mediaInitiazationLock = new object();
    private static MediaFinalizerHelper mediaHelper;
    private string filename = string.Empty;
    private string name = string.Empty;
    private Artist artist = Artist.Empty;
    private Album album = Album.Empty;
    private Genre genre = Genre.Empty;
    private TimeSpan duration = TimeSpan.Zero;
    private int rating = -1;
    private int trackNumber = -1;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    private static void EnsureMedia()
    {
      lock (Song.mediaInitiazationLock)
      {
        if (Song.mediaHelper != null)
          return;
        Song.mediaHelper = new MediaFinalizerHelper();
      }
    }

    private Song()
    {
    }

    [SecuritySafeCritical]
    internal Song(uint handle)
    {
      this.handle = handle;
      if (!this.IsValidHandle)
        return;
      Song.EnsureMedia();
      StringBuilder sbName = new StringBuilder(260);
      if (Helpers.Succeeded(UnsafeNativeMethods.MediaItem_GetName(handle, sbName, 260U)))
        this.name = sbName.ToString();
      int duration = 0;
      if (Helpers.Succeeded(UnsafeNativeMethods.MediaSong_GetDuration(this.Handle, ref duration)))
        this.duration = new TimeSpan(0, 0, 0, 0, duration);
      int rating = (int) UnsafeNativeMethods.MediaSong_GetRating(this.Handle, ref this.rating);
      int trackNumber = (int) UnsafeNativeMethods.MediaSong_GetTrackNumber(this.Handle, ref this.trackNumber);
    }

    public static Song FromUri(string name, Uri uri) => new Song(name, uri);

    [SecuritySafeCritical]
    internal Song(string name, Uri uri)
    {
      if (string.IsNullOrEmpty(name))
      {
        if (name == null)
          throw new ArgumentNullException(nameof (name));
        throw new ArgumentOutOfRangeException(nameof (name));
      }
      if (uri == (Uri) null)
        throw new ArgumentNullException(nameof (uri));
      Song.EnsureMedia();
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaSong_FromUri(name, uri, ref this.handle));
      this.name = name;
      int rating = (int) UnsafeNativeMethods.MediaSong_GetRating(this.Handle, ref this.rating);
      int trackNumber = (int) UnsafeNativeMethods.MediaSong_GetTrackNumber(this.Handle, ref this.trackNumber);
    }

    [SecuritySafeCritical]
    internal Song(string name, string filename, int duration)
    {
      this.name = name;
      this.rating = 0;
      this.trackNumber = 0;
      this.filename = filename;
      this.duration = new TimeSpan(0, 0, 0, 0, duration);
    }

    ~Song() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    private void Dispose(bool disposing)
    {
      if (this.IsDisposed)
        return;
      this.isDisposed = true;
      if (!this.IsValidHandle)
        return;
      int num = (int) UnsafeNativeMethods.MediaItem_Release(this.handle);
      this.handle = uint.MaxValue;
    }

    private void ThrowIfDisposed()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
    }

    internal uint Handle => this.handle;

    internal bool IsValidHandle => this.handle != uint.MaxValue;

    internal bool IsGameSong => !this.IsValidHandle && !string.IsNullOrEmpty(this.filename);

    internal string FileName => this.filename;

    public string Name
    {
      get
      {
        this.ThrowIfDisposed();
        return this.name;
      }
    }

    public Artist Artist
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.artist == Artist.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaSong_GetArtist(this.Handle, ref maxValue)))
            this.artist = new Artist(maxValue);
        }
        return this.artist;
      }
    }

    public Album Album
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.album == Album.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaSong_GetAlbum(this.Handle, ref maxValue)))
            this.album = new Album(maxValue);
        }
        return this.album;
      }
    }

    public Genre Genre
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.genre == Genre.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaSong_GetGenre(this.Handle, ref maxValue)))
            this.genre = new Genre(maxValue);
        }
        return this.genre;
      }
    }

    public TimeSpan Duration
    {
      get
      {
        this.ThrowIfDisposed();
        return this.duration;
      }
    }

    public bool IsRated
    {
      get
      {
        this.ThrowIfDisposed();
        return this.Rating > 0;
      }
    }

    public int Rating
    {
      get
      {
        this.ThrowIfDisposed();
        return this.rating;
      }
    }

    public int PlayCount
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        int playCount1 = 0;
        if (this.IsValidHandle)
        {
          int playCount2 = (int) UnsafeNativeMethods.MediaSong_GetPlayCount(this.Handle, ref playCount1);
        }
        return playCount1;
      }
    }

    public int TrackNumber
    {
      get
      {
        this.ThrowIfDisposed();
        return this.trackNumber;
      }
    }

    public bool IsProtected
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        bool restricted = false;
        if (this.IsValidHandle)
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaSong_IsRestricted(this.Handle, ref restricted));
        return restricted;
      }
    }

    public static bool operator ==(Song first, Song second) => object.Equals((object) first, (object) second);

    public static bool operator !=(Song first, Song second) => !(first == second);

    [SecuritySafeCritical]
    public override bool Equals(object obj)
    {
      this.ThrowIfDisposed();
      bool equal = (object) this == obj;
      if (!equal)
      {
        Song song = obj as Song;
        if (this.IsValidHandle && song != (Song) null && song.IsValidHandle)
        {
          int num1 = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, song.Handle, ref equal);
        }
        else if (!equal && song != (Song) null)
        {
          if (this.IsGameSong && song.IsGameSong)
          {
            equal = string.Compare(this.filename, song.FileName, StringComparison.InvariantCultureIgnoreCase) == 0;
          }
          else
          {
            string filename = this.IsGameSong ? this.FileName : song.FileName;
            int num2 = (int) UnsafeNativeMethods.MediaSong_IsEqualTitleSong(filename, filename.Length, this.IsValidHandle ? this.Handle : song.Handle, ref equal);
          }
        }
      }
      return equal;
    }

    [SecuritySafeCritical]
    public bool Equals(Song other)
    {
      this.ThrowIfDisposed();
      bool equal = (object) this == (object) other;
      if (!equal && this.IsValidHandle && (other != (Song) null && other.IsValidHandle))
      {
        int num1 = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, other.Handle, ref equal);
      }
      else if (!equal && other != (Song) null)
      {
        if (this.IsGameSong && other.IsGameSong)
        {
          equal = string.Compare(this.filename, other.FileName, StringComparison.InvariantCultureIgnoreCase) == 0;
        }
        else
        {
          string filename = this.IsGameSong ? this.FileName : other.FileName;
          int num2 = (int) UnsafeNativeMethods.MediaSong_IsEqualTitleSong(filename, filename.Length, this.IsValidHandle ? this.Handle : other.Handle, ref equal);
        }
      }
      return equal;
    }

    public override string ToString()
    {
      this.ThrowIfDisposed();
      return this.Name;
    }

    public override int GetHashCode()
    {
      this.ThrowIfDisposed();
      if (this.hashcode == -1)
        this.hashcode = this.Name.GetHashCode();
      return this.hashcode;
    }
  }
}
