// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapEncoder
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
  [Static(typeof (IBitmapEncoderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BitmapEncoder : IBitmapEncoder, IBitmapEncoderWithSoftwareBitmap
  {
    public extern BitmapCodecInformation EncoderInformation { [MethodImpl] get; }

    public extern BitmapProperties BitmapProperties { [MethodImpl] get; }

    public extern BitmapProperties BitmapContainerProperties { [MethodImpl] get; }

    public extern bool IsThumbnailGenerated { [MethodImpl] get; [MethodImpl] set; }

    public extern uint GeneratedThumbnailWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern uint GeneratedThumbnailHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern BitmapTransform BitmapTransform { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPixelData(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      uint width,
      uint height,
      double dpiX,
      double dpiY,
      [Range(0, 2147483647)] byte[] pixels);

    [RemoteAsync]
    [Overload("GoToNextFrameAsync")]
    [MethodImpl]
    public extern IAsyncAction GoToNextFrameAsync();

    [RemoteAsync]
    [Overload("GoToNextFrameWithEncodingOptionsAsync")]
    [MethodImpl]
    public extern IAsyncAction GoToNextFrameAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FlushAsync();

    [MethodImpl]
    public extern void SetSoftwareBitmap(SoftwareBitmap bitmap);

    public static extern Guid BmpEncoderId { [MethodImpl] get; }

    public static extern Guid JpegEncoderId { [MethodImpl] get; }

    public static extern Guid PngEncoderId { [MethodImpl] get; }

    public static extern Guid TiffEncoderId { [MethodImpl] get; }

    public static extern Guid GifEncoderId { [MethodImpl] get; }

    public static extern Guid JpegXREncoderId { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator();

    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream);

    [RemoteAsync]
    [Overload("CreateWithEncodingOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream,
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync(
      IRandomAccessStream stream,
      BitmapDecoder bitmapDecoder);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync(
      BitmapDecoder bitmapDecoder);
  }
}
