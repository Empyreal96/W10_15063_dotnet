// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapDecoder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBitmapDecoderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BitmapDecoder : IBitmapDecoder, IBitmapFrame, IBitmapFrameWithSoftwareBitmap
  {
    public extern BitmapPropertiesView BitmapContainerProperties { [MethodImpl] get; }

    public extern BitmapCodecInformation DecoderInformation { [MethodImpl] get; }

    public extern uint FrameCount { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetPreviewAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BitmapFrame> GetFrameAsync(
      uint frameIndex);

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

    [Overload("GetPixelDataTransformedAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);

    [Overload("GetSoftwareBitmapAsync")]
    [RemoteAsync]
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

    public static extern Guid BmpDecoderId { [MethodImpl] get; }

    public static extern Guid JpegDecoderId { [MethodImpl] get; }

    public static extern Guid PngDecoderId { [MethodImpl] get; }

    public static extern Guid TiffDecoderId { [MethodImpl] get; }

    public static extern Guid GifDecoderId { [MethodImpl] get; }

    public static extern Guid JpegXRDecoderId { [MethodImpl] get; }

    public static extern Guid IcoDecoderId { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator();

    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapDecoder> CreateAsync(
      IRandomAccessStream stream);

    [RemoteAsync]
    [Overload("CreateWithIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapDecoder> CreateAsync(
      Guid decoderId,
      IRandomAccessStream stream);
  }
}
