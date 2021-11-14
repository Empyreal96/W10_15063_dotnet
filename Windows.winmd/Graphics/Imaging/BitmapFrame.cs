// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BitmapFrame : IBitmapFrame, IBitmapFrameWithSoftwareBitmap
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetThumbnailAsync();

    public extern BitmapPropertiesView BitmapProperties { [MethodImpl] get; }

    public extern BitmapPixelFormat BitmapPixelFormat { [MethodImpl] get; }

    public extern BitmapAlphaMode BitmapAlphaMode { [MethodImpl] get; }

    public extern double DpiX { [MethodImpl] get; }

    public extern double DpiY { [MethodImpl] get; }

    public extern uint PixelWidth { [MethodImpl] get; }

    public extern uint PixelHeight { [MethodImpl] get; }

    public extern uint OrientedPixelWidth { [MethodImpl] get; }

    public extern uint OrientedPixelHeight { [MethodImpl] get; }

    [Overload("GetPixelDataAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync();

    [RemoteAsync]
    [Overload("GetPixelDataTransformedAsync")]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);

    [RemoteAsync]
    [Overload("GetSoftwareBitmapAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync();

    [RemoteAsync]
    [Overload("GetSoftwareBitmapConvertedAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode);

    [Overload("GetSoftwareBitmapTransformedAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);
  }
}
