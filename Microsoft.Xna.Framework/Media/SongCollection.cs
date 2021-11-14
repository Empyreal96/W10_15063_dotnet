// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.SongCollection
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class SongCollection : IEnumerable<Song>, IEnumerable, IDisposable
  {
    internal static SongCollection Empty = new SongCollection();
    private SongLibraryEnumerator libraryCollection = SongLibraryEnumerator.Empty;
    private uint handle = uint.MaxValue;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    private SongCollection()
    {
    }

    internal SongCollection(uint handle)
    {
      this.handle = handle;
      this.libraryCollection = new SongLibraryEnumerator((SongCollection) null, handle);
    }

    ~SongCollection() => this.Dispose(false);

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
      this.libraryCollection = SongLibraryEnumerator.Empty;
    }

    private void ThrowIfDisposed()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
    }

    internal uint Handle => this.handle;

    internal bool IsValidHandle => this.handle != uint.MaxValue;

    public int Count
    {
      get
      {
        this.ThrowIfDisposed();
        return this.libraryCollection.Count;
      }
    }

    public Song this[int index]
    {
      get
      {
        this.ThrowIfDisposed();
        return this.libraryCollection[index];
      }
    }

    public IEnumerator<Song> GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator<Song>) new SongLibraryEnumerator(this, this.Handle) : (IEnumerator<Song>) SongLibraryEnumerator.Empty;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator) new SongLibraryEnumerator(this, this.Handle) : (IEnumerator) SongLibraryEnumerator.Empty;
    }
  }
}
