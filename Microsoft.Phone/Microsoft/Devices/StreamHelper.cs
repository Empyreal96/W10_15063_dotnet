// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.StreamHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Devices
{
  [SecuritySafeCritical]
  internal class StreamHelper
  {
    private ReaderCallbackSig _readercb;
    private SeekCallbackSig _seekcb;
    private WriteCallbackSig _writecb;
    private int[] _pixels;
    private int _pixelWidth;
    private int _pixelHeight;
    private Stream _s;
    private byte[] _scratch = new byte[1024];

    public StreamHelper(Stream s, int[] pixels, int pixelWidth, int pixelHeight)
      : this(s)
    {
      this._pixels = pixels;
      this._pixelWidth = pixelWidth;
      this._pixelHeight = pixelHeight;
    }

    public StreamHelper(Stream s)
    {
      if (s.CanSeek)
        this._s = s;
      else
        this._s = this.CreateCachedStream(s);
    }

    private Stream CreateCachedStream(Stream s)
    {
      PhotoStream photoStream = new PhotoStream("tempFile" + Guid.NewGuid().ToString() + ".jpg");
      this.CopyStream(s, (Stream) photoStream);
      return (Stream) photoStream;
    }

    private void CopyStream(Stream source, Stream dest)
    {
      while (true)
      {
        int count = source.Read(this._scratch, 0, this._scratch.Length);
        if (count != 0)
          dest.Write(this._scratch, 0, count);
        else
          break;
      }
    }

    public void SetPixelsNeededForAlloc(int[] pixels, int width, int height)
    {
      this._pixels = pixels;
      this._pixelWidth = width;
      this._pixelHeight = height;
    }

    public void GetJpegBoundsWithLimit(
      int maxPixelWidth,
      int maxPixelHeight,
      out int width,
      out int height)
    {
      this._readercb = new ReaderCallbackSig(this.ReaderCallback);
      this._seekcb = new SeekCallbackSig(this.SeekCallBack);
      long position = this._s.Position;
      uint widthNeeded = 0;
      uint heightNeeded = 0;
      PhotosZuneNativeMethods.MediaApi_GetJpegBoundsWithLimit(this._readercb, this._seekcb, (ulong) this._s.Length, (uint) maxPixelWidth, (uint) maxPixelHeight, out widthNeeded, out heightNeeded);
      width = (int) widthNeeded;
      height = (int) heightNeeded;
      this._s.Seek(position, SeekOrigin.Begin);
    }

    public void DecodeJpegStreamIntoARGB()
    {
      this._readercb = new ReaderCallbackSig(this.ReaderCallback);
      this._seekcb = new SeekCallbackSig(this.SeekCallBack);
      PhotosZuneNativeMethods.MediaApi_DecodeJpegStreamIntoARGB(this._readercb, this._seekcb, (ulong) this._s.Length, (uint) checked (this._pixelWidth * 4 * this._pixelHeight), this._pixels, (uint) this._pixelWidth, (uint) this._pixelHeight);
      this._s.Seek(0L, SeekOrigin.End);
    }

    public void EncodeARGBIntoJpegStream(
      int targetWidth,
      int targetHeight,
      int orientation,
      int quality)
    {
      this._readercb = new ReaderCallbackSig(this.ReaderCallback);
      this._seekcb = new SeekCallbackSig(this.SeekCallBack);
      this._writecb = new WriteCallbackSig(this.WriteCallback);
      PhotosZuneNativeMethods.MediaApi_EncodeARGBIntoJpegStream(this._pixels, (uint) this._pixelWidth, (uint) this._pixelHeight, (uint) targetWidth, (uint) targetHeight, (uint) orientation, (uint) quality, (uint) checked (this._pixelWidth * 4 * this._pixelHeight), this._readercb, this._seekcb, this._writecb, (ulong) (uint) this._s.Length);
    }

    private uint MapExceptions(Exception e)
    {
      int num;
      switch (e)
      {
        case OutOfMemoryException _:
          num = -2147483646;
          break;
        case ArgumentNullException _:
        case ArgumentOutOfRangeException _:
          num = -2147024809;
          break;
        case NotSupportedException _:
          num = -2147467263;
          break;
        case IOException _:
          num = -2147024784;
          break;
        default:
          num = -2145058720;
          break;
      }
      return (uint) num;
    }

    [AllowReversePInvokeCalls]
    private uint SeekCallBack(long dlibMove, uint dwOrigin, ref ulong plibNewPosition)
    {
      try
      {
        SeekOrigin origin = (SeekOrigin) dwOrigin;
        plibNewPosition = (ulong) this._s.Seek(dlibMove, origin);
        return 0;
      }
      catch (Exception ex)
      {
        return this.MapExceptions(ex);
      }
    }

    [AllowReversePInvokeCalls]
    private uint ReaderCallback(IntPtr rgBytes, uint cb, out uint cbActual)
    {
      cbActual = 0U;
      uint val2 = cb;
      try
      {
        while (cbActual < cb)
        {
          int length = this._s.Read(this._scratch, 0, (int) Math.Min((uint) this._scratch.Length, val2));
          Marshal.Copy(this._scratch, 0, IntPtr.Add(rgBytes, (int) cbActual), length);
          val2 -= (uint) length;
          cbActual += (uint) length;
          if (length == 0)
            break;
        }
        return 0;
      }
      catch (Exception ex)
      {
        return this.MapExceptions(ex);
      }
    }

    [AllowReversePInvokeCalls]
    private uint WriteCallback(IntPtr rgBytes, uint cb, out uint cbActual)
    {
      cbActual = 0U;
      uint val2 = cb;
      try
      {
        while (cbActual < cb)
        {
          int num = (int) Math.Min((uint) this._scratch.Length, val2);
          Marshal.Copy(IntPtr.Add(rgBytes, (int) cbActual), this._scratch, 0, num);
          this._s.Write(this._scratch, 0, num);
          val2 -= (uint) num;
          cbActual += (uint) num;
        }
        return 0;
      }
      catch (Exception ex)
      {
        return this.MapExceptions(ex);
      }
    }
  }
}
