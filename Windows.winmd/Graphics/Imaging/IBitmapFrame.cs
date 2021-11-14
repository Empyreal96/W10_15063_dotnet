// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1923389980, 32897, 17293, 145, 188, 148, 236, 252, 129, 133, 198)]
  public interface IBitmapFrame
  {
    [RemoteAsync]
    IAsyncOperation<ImageStream> GetThumbnailAsync();

    BitmapPropertiesView BitmapProperties { get; }

    BitmapPixelFormat BitmapPixelFormat { get; }

    BitmapAlphaMode BitmapAlphaMode { get; }

    double DpiX { get; }

    double DpiY { get; }

    uint PixelWidth { get; }

    uint PixelHeight { get; }

    uint OrientedPixelWidth { get; }

    uint OrientedPixelHeight { get; }

    [RemoteAsync]
    [Overload("GetPixelDataAsync")]
    IAsyncOperation<PixelDataProvider> GetPixelDataAsync();

    [Overload("GetPixelDataTransformedAsync")]
    [RemoteAsync]
    IAsyncOperation<PixelDataProvider> GetPixelDataAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);
  }
}
