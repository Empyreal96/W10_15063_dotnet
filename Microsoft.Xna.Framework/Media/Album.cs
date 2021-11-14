// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.Album
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.IO;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class Album : IEquatable<Album>, IDisposable
  {
    internal static Album Empty = new Album();
    private uint handle = uint.MaxValue;
    private int hashcode = -1;
    private string name = string.Empty;
    private Artist artist = Artist.Empty;
    private Genre genre = Genre.Empty;
    private SongCollection songs = SongCollection.Empty;
    private TimeSpan duration = TimeSpan.Zero;
    private bool hasArt;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    private Album()
    {
    }

    [SecuritySafeCritical]
    internal Album(uint handle)
    {
      this.handle = handle;
      if (!this.IsValidHandle)
        return;
      StringBuilder sbName = new StringBuilder(260);
      if (!Helpers.Succeeded(UnsafeNativeMethods.MediaItem_GetName(handle, sbName, 260U)))
        return;
      this.name = sbName.ToString();
    }

    ~Album() => this.Dispose(false);

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
      if (this.IsValidHandle)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_Release(this.handle);
        this.handle = uint.MaxValue;
      }
      this.songs = SongCollection.Empty;
    }

    private void ThrowIfDisposed()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
    }

    internal uint Handle => this.handle;

    internal bool IsValidHandle => this.handle != uint.MaxValue;

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
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaAlbum_GetArtist(this.Handle, ref maxValue)))
            this.artist = new Artist(maxValue);
        }
        return this.artist;
      }
    }

    public SongCollection Songs
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.songs == SongCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaAlbum_GetSongs(this.Handle, ref maxValue)))
            this.songs = new SongCollection(maxValue);
        }
        return this.songs;
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
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaAlbum_GetGenre(this.Handle, ref maxValue)))
            this.genre = new Genre(maxValue);
        }
        return this.genre;
      }
    }

    public TimeSpan Duration
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.duration == TimeSpan.Zero)
        {
          int duration = 0;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaAlbum_GetDuration(this.Handle, ref duration)))
            this.duration = new TimeSpan(0, 0, 0, 0, duration);
        }
        return this.duration;
      }
    }

    public bool HasArt
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle)
        {
          int num = (int) UnsafeNativeMethods.MediaAlbum_HasArt(this.Handle, ref this.hasArt);
        }
        return this.hasArt;
      }
    }

    public Stream GetAlbumArt()
    {
      this.ThrowIfDisposed();
      return this.GetImageStream(false);
    }

    public Stream GetThumbnail()
    {
      this.ThrowIfDisposed();
      return this.GetImageStream(true);
    }

    [SecuritySafeCritical]
    private Stream GetImageStream(bool thumbnail)
    {
      Stream stream = (Stream) null;
      if (this.HasArt)
      {
        uint maxValue = uint.MaxValue;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaAlbum_GetArtStream(this.Handle, thumbnail, ref maxValue));
        stream = (Stream) new ImageStream(maxValue);
      }
      return stream;
    }

    public static bool operator ==(Album first, Album second) => object.Equals((object) first, (object) second);

    public static bool operator !=(Album first, Album second) => !(first == second);

    [SecuritySafeCritical]
    public override bool Equals(object obj)
    {
      this.ThrowIfDisposed();
      bool equal = (object) this == obj;
      if (!equal)
      {
        Album album = obj as Album;
        if (this.IsValidHandle && album != (Album) null && album.IsValidHandle)
        {
          int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, album.Handle, ref equal);
        }
      }
      return equal;
    }

    [SecuritySafeCritical]
    public bool Equals(Album other)
    {
      this.ThrowIfDisposed();
      bool equal = (object) this == (object) other;
      if (!equal && this.IsValidHandle && (other != (Album) null && other.IsValidHandle))
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, other.Handle, ref equal);
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
