// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.AlbumCollection
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class AlbumCollection : IEnumerable<Album>, IEnumerable, IDisposable
  {
    internal static AlbumCollection Empty = new AlbumCollection();
    private AlbumEnumerator enumerator = AlbumEnumerator.Empty;
    private uint handle = uint.MaxValue;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    private AlbumCollection()
    {
    }

    internal AlbumCollection(uint handle)
    {
      this.handle = handle;
      this.enumerator = new AlbumEnumerator((AlbumCollection) null, handle);
    }

    ~AlbumCollection() => this.Dispose(false);

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
      this.enumerator = AlbumEnumerator.Empty;
    }

    private void ThrowIfDisposed()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
    }

    internal uint Handle => this.handle;

    internal bool IsValidHandle => this.handle != uint.MaxValue;

    public IEnumerator<Album> GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator<Album>) new AlbumEnumerator(this, this.Handle) : (IEnumerator<Album>) AlbumEnumerator.Empty;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator) new AlbumEnumerator(this, this.Handle) : (IEnumerator) AlbumEnumerator.Empty;
    }

    public Album this[int index]
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
