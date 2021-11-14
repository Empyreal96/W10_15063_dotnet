// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapFrameWithSoftwareBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4264066202, 16908, 18787, 135, 173, 105, 20, 54, 224, 131, 131)]
  public interface IBitmapFrameWithSoftwareBitmap : IBitmapFrame
  {
    [Overload("GetSoftwareBitmapAsync")]
    [RemoteAsync]
    IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync();

    [Overload("GetSoftwareBitmapConvertedAsync")]
    [RemoteAsync]
    IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode);

    [RemoteAsync]
    [Overload("GetSoftwareBitmapTransformedAsync")]
    IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);
  }
}
