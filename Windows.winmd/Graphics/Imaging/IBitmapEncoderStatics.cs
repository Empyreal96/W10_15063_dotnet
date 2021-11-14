// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [Guid(2806208167, 42212, 20153, 142, 64, 86, 77, 231, 225, 204, 178)]
  [ExclusiveTo(typeof (BitmapEncoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapEncoderStatics
  {
    Guid BmpEncoderId { get; }

    Guid JpegEncoderId { get; }

    Guid PngEncoderId { get; }

    Guid TiffEncoderId { get; }

    Guid GifEncoderId { get; }

    Guid JpegXREncoderId { get; }

    IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator();

    [Overload("CreateAsync")]
    [RemoteAsync]
    IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream);

    [Overload("CreateWithEncodingOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream,
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    [RemoteAsync]
    IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync(
      IRandomAccessStream stream,
      BitmapDecoder bitmapDecoder);

    [RemoteAsync]
    IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync(
      BitmapDecoder bitmapDecoder);
  }
}
