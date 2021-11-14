// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.ImageStream
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.IO;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  internal class ImageStream : Stream
  {
    private object streamLock = new object();
    private uint handle = uint.MaxValue;
    private bool disposed;
    private ComStreamWrapper comStreamWrapper;

    public static ImageStream FromStream(Stream source) => new ImageStream(source);

    public static ImageStream FromColors(
      Color[] colors,
      int sourceWidth,
      int sourceHeight,
      XnaImageFormat format,
      int targetWidth,
      int targetHeight)
    {
      return new ImageStream(colors, sourceWidth, sourceHeight, format, targetWidth, targetHeight);
    }

    public ImageStream(uint kernelStream) => this.handle = kernelStream != uint.MaxValue ? kernelStream : throw new ArgumentException(nameof (kernelStream));

    private void ValidateWidthHeightFormat(
      int sourceWidth,
      int sourceHeight,
      int targetWidth,
      int targetHeight,
      XnaImageFormat format)
    {
      if (sourceWidth < 0)
        throw new ArgumentException(FrameworkResources.ResourcesMustBeGreaterThanZeroSize, nameof (sourceWidth));
      if (sourceHeight < 0)
        throw new ArgumentException(FrameworkResources.ResourcesMustBeGreaterThanZeroSize, nameof (sourceHeight));
      if (targetWidth < 0)
        throw new ArgumentException(FrameworkResources.ResourcesMustBeGreaterThanZeroSize, nameof (targetWidth));
      if (targetHeight < 0)
        throw new ArgumentException(FrameworkResources.ResourcesMustBeGreaterThanZeroSize, nameof (targetHeight));
      if (format < XnaImageFormat.Jpeg || format > XnaImageFormat.Png)
        throw new ArgumentOutOfRangeException(nameof (format));
    }

    private ImageStream(Stream source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      this.CreateKernelStreamFromStream(source);
    }

    private ImageStream(
      Color[] colors,
      int sourceWidth,
      int sourceHeight,
      XnaImageFormat format,
      int targetWidth,
      int targetHeight)
    {
      if (colors == null || colors.Length == 0)
        throw new ArgumentNullException("data");
      this.ValidateWidthHeightFormat(sourceWidth, sourceHeight, targetWidth, targetHeight, format);
      byte[] numArray = new byte[colors.Length * 4];
      MemoryStream memoryStream = new MemoryStream(numArray);
      foreach (Color color in colors)
        memoryStream.Write(BitConverter.GetBytes(color.PackedValue), 0, 4);
      this.EncodeBuffer(numArray, format, sourceWidth, sourceHeight, targetWidth, targetHeight);
      this.Seek(0L, SeekOrigin.Begin);
    }

    [SecuritySafeCritical]
    private unsafe void EncodeBuffer(
      byte[] data,
      XnaImageFormat format,
      int sourceWidth,
      int sourceHeight,
      int targetWidth,
      int targetHeight)
    {
      if (data == null || data.Length == 0)
        throw new ArgumentNullException(nameof (data));
      this.ValidateWidthHeightFormat(sourceWidth, sourceHeight, targetWidth, targetHeight, format);
      fixed (byte* buffer = data)
      {
        uint maxValue = uint.MaxValue;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.EncodeBufferToStream(format, buffer, data.Length, sourceWidth, sourceHeight, targetWidth, targetHeight, &maxValue));
        this.handle = maxValue;
      }
    }

    [SecuritySafeCritical]
    private unsafe void CreateKernelStreamFromStream(Stream source)
    {
      this.comStreamWrapper = source != null ? new ComStreamWrapper(source) : throw new ArgumentNullException(nameof (source));
      uint maxValue = uint.MaxValue;
      Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.CreateKernelStream(this.comStreamWrapper.ReadFuntionPtr, this.comStreamWrapper.WriteFuntionPtr, this.comStreamWrapper.SeekFuntionPtr, this.comStreamWrapper.LengthFuntionPtr, &maxValue));
      this.handle = maxValue;
    }

    ~ImageStream() => this.Dispose(false);

    [SecuritySafeCritical]
    protected override void Dispose(bool disposing)
    {
      if (this.handle != uint.MaxValue)
      {
        int num = (int) UnsafeNativeMethods.CloseKernelStream(this.handle);
        this.handle = uint.MaxValue;
      }
      this.disposed = true;
    }

    public bool IsDisposed => this.disposed;

    [SecuritySafeCritical]
    public override unsafe int Read(byte[] buffer, int offset, int count)
    {
      lock (this.streamLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        byte[] numArray1 = new byte[count];
        int count1 = 0;
        byte[] numArray2 = numArray1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        fixed (byte* buffer1 = &^(numArray1 == null || numArray2.Length == 0 ? (byte&) IntPtr.Zero : ref numArray2[0]))
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.ReadFromStream(this.handle, buffer1, count, &count1));
        Buffer.BlockCopy((Array) numArray1, 0, (Array) buffer, offset, count1);
        return count1;
      }
    }

    public override bool CanSeek => true;

    public override bool CanRead => true;

    public override bool CanWrite => false;

    public override unsafe long Length
    {
      [SecuritySafeCritical] get
      {
        lock (this.streamLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          long num = 0;
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.GetStreamLength(this.handle, &num));
          return num;
        }
      }
    }

    public override unsafe long Position
    {
      [SecuritySafeCritical] get
      {
        lock (this.streamLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          long num = 0;
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.SeekInStream(this.handle, 0L, 1, &num));
          return num;
        }
      }
      [SecuritySafeCritical] set
      {
        lock (this.streamLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          long num = 0;
          Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.SeekInStream(this.handle, value, 0, &num));
        }
      }
    }

    public override void Flush()
    {
      lock (this.streamLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        throw new NotSupportedException();
      }
    }

    [SecuritySafeCritical]
    public override unsafe long Seek(long offset, SeekOrigin origin)
    {
      lock (this.streamLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        long num = 0;
        Helpers.ThrowExceptionFromErrorCode(UnsafeNativeMethods.SeekInStream(this.handle, offset, (int) origin, &num));
        return num;
      }
    }

    public override void SetLength(long value)
    {
      lock (this.streamLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        throw new NotSupportedException();
      }
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      lock (this.streamLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        throw new NotSupportedException();
      }
    }

    internal uint Handle => this.handle;
  }
}
