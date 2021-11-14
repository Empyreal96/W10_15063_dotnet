// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.PictureDecoder
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Devices;
using System;
using System.IO;
using System.Security;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone
{
  [SecuritySafeCritical]
  public static class PictureDecoder
  {
    [SecuritySafeCritical]
    private static WriteableBitmap DecodeJpegInternal(
      Stream source,
      int maxPixelWidth,
      int maxPixelHeight)
    {
      StreamHelper streamHelper = new StreamHelper(source);
      int width = 0;
      int height = 0;
      streamHelper.GetJpegBoundsWithLimit(maxPixelWidth, maxPixelHeight, out width, out height);
      WriteableBitmap writeableBitmap = new WriteableBitmap(width, height);
      streamHelper.SetPixelsNeededForAlloc(writeableBitmap.Pixels, width, height);
      streamHelper.DecodeJpegStreamIntoARGB();
      return writeableBitmap;
    }

    [SecuritySafeCritical]
    public static WriteableBitmap DecodeJpeg(
      Stream source,
      int maxPixelWidth,
      int maxPixelHeight)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (maxPixelWidth <= 0)
        throw new ArgumentOutOfRangeException(nameof (maxPixelWidth));
      if (maxPixelHeight <= 0)
        throw new ArgumentOutOfRangeException(nameof (maxPixelHeight));
      if (QuirksMode.ShouldDecodeJpegWithBothHeightAndWidth())
        return PictureDecoder.DecodeJpegInternal(source, maxPixelWidth, maxPixelHeight);
      Stream source1 = source;
      int num = maxPixelHeight;
      return PictureDecoder.DecodeJpegInternal(source1, num, num);
    }

    [SecuritySafeCritical]
    public static WriteableBitmap DecodeJpeg(Stream source) => source != null ? PictureDecoder.DecodeJpegInternal(source, 0, 0) : throw new ArgumentNullException(nameof (source));
  }
}
