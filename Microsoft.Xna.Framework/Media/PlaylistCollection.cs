// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.PlaylistCollection
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class PlaylistCollection : IEnumerable<Playlist>, IEnumerable, IDisposable
  {
    internal static PlaylistCollection Empty = new PlaylistCollection();
    private PlaylistEnumerator enumerator = PlaylistEnumerator.Empty;
    private uint handle = uint.MaxValue;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    internal PlaylistCollection()
    {
    }

    internal PlaylistCollection(uint handle)
    {
      this.handle = handle;
      this.enumerator = new PlaylistEnumerator((PlaylistCollection) null, handle);
    }

    ~PlaylistCollection() => this.Dispose(false);

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
        int num = (int) UnsafeNativeMethods.MediaList_Release(this.Handle);
        this.handle = uint.MaxValue;
      }
      this.enumerator = PlaylistEnumerator.Empty;
    }

    private void ThrowIfDisposed()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
    }

    internal uint Handle => this.handle;

    internal bool IsValidHandle => this.handle != uint.MaxValue;

    public IEnumerator<Playlist> GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator<Playlist>) new PlaylistEnumerator(this, this.Handle) : (IEnumerator<Playlist>) PlaylistEnumerator.Empty;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator) new PlaylistEnumerator(this, this.Handle) : (IEnumerator) PlaylistEnumerator.Empty;
    }

    public Playlist this[int index]
    {
      get
      {
        this.ThrowIfDisposed();
        return this.enumerator[index];
      }
    }

    public int Count
    {
      get
      {
        this.ThrowIfDisposed();
        return this.enumerator.Count;
      }
    }
  }
}
