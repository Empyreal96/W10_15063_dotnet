// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.PictureAlbum
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class PictureAlbum : IEquatable<PictureAlbum>, IDisposable
  {
    internal static PictureAlbum Empty = new PictureAlbum();
    private uint handle = uint.MaxValue;
    private int hashcode = -1;
    private string name = string.Empty;
    private PictureAlbumCollection albums = PictureAlbumCollection.Empty;
    private PictureAlbum parent = PictureAlbum.Empty;
    private PictureCollection pictures = PictureCollection.Empty;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    internal PictureAlbum()
    {
    }

    internal PictureAlbum(uint handle) => this.handle = handle;

    ~PictureAlbum() => this.Dispose(false);

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
      this.albums = PictureAlbumCollection.Empty;
      this.parent = PictureAlbum.Empty;
      this.pictures = PictureCollection.Empty;
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
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && string.IsNullOrEmpty(this.name))
        {
          StringBuilder sbName = new StringBuilder(260);
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaItem_GetName(this.handle, sbName, 260U)))
            this.name = sbName.ToString();
        }
        return this.name;
      }
    }

    public PictureAlbumCollection Albums
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.albums == PictureAlbumCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaPictureAlbum_GetChildAlbums(this.Handle, ref maxValue)))
            this.albums = new PictureAlbumCollection(maxValue);
        }
        return this.albums;
      }
    }

    public PictureCollection Pictures
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.pictures == PictureCollection.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaPictureAlbum_GetPictures(this.Handle, ref maxValue)))
            this.pictures = new PictureCollection(maxValue);
        }
        return this.pictures;
      }
    }

    public PictureAlbum Parent
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle && this.parent == PictureAlbum.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaPictureAlbum_GetParentAlbum(this.Handle, ref maxValue)))
            this.parent = new PictureAlbum(maxValue);
        }
        return this.parent;
      }
    }

    public static bool operator ==(PictureAlbum first, PictureAlbum second) => object.Equals((object) first, (object) second);

    public static bool operator !=(PictureAlbum first, PictureAlbum second) => !(first == second);

    [SecuritySafeCritical]
    public override bool Equals(object obj)
    {
      this.ThrowIfDisposed();
      bool equal = false;
      PictureAlbum pictureAlbum = obj as PictureAlbum;
      if (this.IsValidHandle && pictureAlbum != (PictureAlbum) null)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, pictureAlbum.Handle, ref equal);
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
    public bool Equals(PictureAlbum other)
    {
      this.ThrowIfDisposed();
      bool equal = false;
      if (this.IsValidHandle && other != (PictureAlbum) null)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, other.Handle, ref equal);
      }
      return equal;
    }
  }
}
