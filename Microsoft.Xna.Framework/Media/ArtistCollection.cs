// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.ArtistCollection
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class ArtistCollection : IEnumerable<Artist>, IEnumerable, IDisposable
  {
    internal static ArtistCollection Empty = new ArtistCollection();
    private ArtistEnumerator enumerator = ArtistEnumerator.Empty;
    private uint handle = uint.MaxValue;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    private ArtistCollection()
    {
    }

    internal ArtistCollection(uint handle)
    {
      this.handle = handle;
      this.enumerator = new ArtistEnumerator((ArtistCollection) null, handle);
    }

    ~ArtistCollection() => this.Dispose(false);

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
      int num = (int) UnsafeNativeMethods.MediaList_Release(this.Handle);
      this.handle = uint.MaxValue;
    }

    private void ThrowIfDisposed()
    {
      if (this.IsDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
    }

    internal uint Handle => this.handle;

    internal bool IsValidHandle => this.handle != uint.MaxValue;

    public IEnumerator<Artist> GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator<Artist>) new ArtistEnumerator(this, this.Handle) : (IEnumerator<Artist>) ArtistEnumerator.Empty;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      this.ThrowIfDisposed();
      return this.IsValidHandle ? (IEnumerator) new ArtistEnumerator(this, this.Handle) : (IEnumerator) ArtistEnumerator.Empty;
    }

    public Artist this[int index]
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
