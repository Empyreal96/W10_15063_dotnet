// Decompiled with JetBrains decompiler
// Type: System.Windows.Media.Imaging.Extensions
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Devices;
using System.IO;
using System.Security;

namespace System.Windows.Media.Imaging
{
  public static class Extensions
  {
    [SecuritySafeCritical]
    public static void LoadJpeg(this WriteableBitmap bitmap, Stream sourceStream)
    {
      if (bitmap == null)
        throw new ArgumentNullException(nameof (bitmap));
      if (sourceStream == null)
        throw new ArgumentNullException(nameof (sourceStream));
      new StreamHelper(sourceStream, bitmap.Pixels, bitmap.PixelWidth, bitmap.PixelHeight).DecodeJpegStreamIntoARGB();
    }

    [SecuritySafeCritical]
    public static void SaveJpeg(
      this WriteableBitmap bitmap,
      Stream targetStream,
      int targetWidth,
      int targetHeight,
      int orientation,
      int quality)
    {
      if (quality > 100)
        throw new ArgumentException(nameof (quality));
      if (targetWidth <= 0)
        throw new ArgumentException(nameof (targetWidth));
      if (targetHeight <= 0)
        throw new ArgumentException(nameof (targetHeight));
      if (bitmap == null)
        throw new ArgumentNullException(nameof (bitmap));
      if (targetStream == null)
        throw new ArgumentNullException(nameof (targetStream));
      if (!targetStream.CanWrite)
        throw new NotSupportedException();
      new StreamHelper(targetStream, bitmap.Pixels, bitmap.PixelWidth, bitmap.PixelHeight).EncodeARGBIntoJpegStream(targetWidth, targetHeight, orientation, quality);
    }
  }
}
