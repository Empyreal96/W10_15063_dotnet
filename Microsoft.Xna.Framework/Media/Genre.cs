// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.Genre
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class Genre : IEquatable<Genre>, IDisposable
  {
    internal static Genre Empty = new Genre();
    private uint handle = uint.MaxValue;
    private int hashcode = -1;
    private string name = string.Empty;
    private SongCollection songs = SongCollection.Empty;
    private AlbumCollection albums = AlbumCollection.Empty;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    private Genre()
    {
    }

    [SecuritySafeCritical]
    internal Genre(uint handle)
    {
      this.handle = handle;
      if (!this.IsValidHandle)
        return;
      StringBuilder sbName = new StringBuilder(260);
      if (!Helpers.Succeeded(UnsafeNativeMethods.MediaItem_GetName(handle, sbName, 260U)))
        return;
      this.name = sbName.ToString();
    }

    ~Genre() => this.Dispose(false);

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
      this.albums = AlbumCollection.Empty;
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

    public SongCollection Songs
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.songs == SongCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaGenre_GetSongs(this.Handle, ref maxValue)))
            this.songs = new SongCollection(maxValue);
        }
        return this.songs;
      }
    }

    public AlbumCollection Albums
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.albums == AlbumCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaGenre_GetAlbums(this.Handle, ref maxValue)))
            this.albums = new AlbumCollection(maxValue);
        }
        return this.albums;
      }
    }

    public static bool operator ==(Genre first, Genre second) => object.Equals((object) first, (object) second);

    public static bool operator !=(Genre first, Genre second) => !(first == second);

    [SecuritySafeCritical]
    public override bool Equals(object obj)
    {
      this.ThrowIfDisposed();
      bool equal = (object) this == obj;
      if (!equal)
      {
        Genre genre = obj as Genre;
        if (this.IsValidHandle && genre != (Genre) null && genre.IsValidHandle)
        {
          int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, genre.Handle, ref equal);
        }
      }
      return equal;
    }

    [SecuritySafeCritical]
    public bool Equals(Genre other)
    {
      this.ThrowIfDisposed();
      bool equal = (object) this == (object) other;
      if (!equal && this.IsValidHandle && (other != (Genre) null && other.IsValidHandle))
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
