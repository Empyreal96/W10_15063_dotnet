// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.Playlist
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class Playlist : IEquatable<Playlist>, IDisposable
  {
    internal static Playlist Empty = new Playlist();
    private uint handle = uint.MaxValue;
    private int hashcode = -1;
    private string name = string.Empty;
    private SongCollection songs = SongCollection.Empty;
    private TimeSpan duration = TimeSpan.Zero;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    internal Playlist()
    {
    }

    [SecuritySafeCritical]
    internal Playlist(uint handle)
    {
      this.handle = handle;
      if (!this.IsValidHandle)
        return;
      StringBuilder sbName = new StringBuilder(260);
      if (!Helpers.Succeeded(UnsafeNativeMethods.MediaItem_GetName(handle, sbName, 260U)))
        return;
      this.name = sbName.ToString();
    }

    ~Playlist() => this.Dispose(false);

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

    public SongCollection Songs
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.songs == SongCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaPlaylist_GetSongs(this.Handle, ref maxValue)))
            this.songs = new SongCollection(maxValue);
        }
        return this.songs;
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
          this.duration = !Helpers.Failed(UnsafeNativeMethods.MediaPlaylist_GetDuration(this.Handle, ref duration)) ? new TimeSpan(0, 0, 0, 0, duration) : throw new InvalidOperationException();
        }
        return this.duration;
      }
    }

    public static bool operator ==(Playlist first, Playlist second) => object.Equals((object) first, (object) second);

    public static bool operator !=(Playlist first, Playlist second) => !(first == second);

    [SecuritySafeCritical]
    public override bool Equals(object obj)
    {
      this.ThrowIfDisposed();
      bool equal = false;
      Playlist playlist = obj as Playlist;
      if (this.IsValidHandle && playlist != (Playlist) null)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, playlist.Handle, ref equal);
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

    [SecuritySafeCritical]
    public bool Equals(Playlist other)
    {
      this.ThrowIfDisposed();
      bool equal = false;
      if (this.IsValidHandle && other != (Playlist) null)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, other.Handle, ref equal);
      }
      return equal;
    }
  }
}
