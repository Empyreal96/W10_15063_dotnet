// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.Picture
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Phone;
using System;
using System.IO;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Media
{
  public sealed class Picture : IEquatable<Picture>, IDisposable
  {
    internal static Picture Empty = new Picture();
    private uint handle = uint.MaxValue;
    private int hashcode = -1;
    private string name = string.Empty;
    private PictureAlbum album = PictureAlbum.Empty;
    private int width;
    private int height;
    private DateTime date = DateTime.MinValue;
    private bool isDisposed;

    public bool IsDisposed => this.isDisposed;

    internal Picture()
    {
    }

    internal Picture(uint handle) => this.handle = handle;

    ~Picture() => this.Dispose(false);

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

    public PictureAlbum Album
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle & this.album == PictureAlbum.Empty)
        {
          uint maxValue = uint.MaxValue;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaPicture_GetAlbum(this.Handle, ref maxValue)))
            this.album = new PictureAlbum(maxValue);
        }
        return this.album;
      }
    }

    public int Width
    {
      get
      {
        this.ThrowIfDisposed();
        if (this.width == 0)
          this.GetDimensions();
        return this.width;
      }
    }

    public int Height
    {
      get
      {
        this.ThrowIfDisposed();
        if (this.height == 0)
          this.GetDimensions();
        return this.height;
      }
    }

    public DateTime Date
    {
      [SecuritySafeCritical] get
      {
        this.ThrowIfDisposed();
        if (this.IsValidHandle & this.date == DateTime.MinValue)
        {
          long filetime = 0;
          if (Helpers.Succeeded(UnsafeNativeMethods.MediaPicture_GetDate(this.Handle, ref filetime)))
            this.date = !QuirksMode.ShouldPictureDateDoubleCorrectForLocalTime() ? DateTime.FromFileTimeUtc(filetime) : DateTime.FromFileTime(filetime);
        }
        return this.date;
      }
    }

    public Stream GetImage()
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
      uint maxValue = uint.MaxValue;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.MediaPicture_GetStream(this.Handle, thumbnail ? PictureStreamType.Thumb : PictureStreamType.Full, ref maxValue));
      return (Stream) new ImageStream(maxValue);
    }

    [SecuritySafeCritical]
    private void GetDimensions()
    {
      int dimensions = (int) UnsafeNativeMethods.MediaPicture_GetDimensions(this.Handle, ref this.width, ref this.height);
    }

    public static bool operator ==(Picture first, Picture second) => object.Equals((object) first, (object) second);

    public static bool operator !=(Picture first, Picture second) => !(first == second);

    [SecuritySafeCritical]
    public override bool Equals(object obj)
    {
      this.ThrowIfDisposed();
      bool equal = false;
      Picture picture = obj as Picture;
      if (picture != (Picture) null)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, picture.Handle, ref equal);
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
    public bool Equals(Picture other)
    {
      this.ThrowIfDisposed();
      bool equal = false;
      if (other != (Picture) null)
      {
        int num = (int) UnsafeNativeMethods.MediaItem_IsEqual(this.Handle, other.Handle, ref equal);
      }
      return equal;
    }
  }
}
