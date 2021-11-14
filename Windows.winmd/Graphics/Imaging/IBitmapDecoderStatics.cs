// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapDecoderStatics
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
  [ExclusiveTo(typeof (BitmapDecoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1133300518, 48367, 20117, 186, 214, 35, 168, 34, 229, 141, 1)]
  internal interface IBitmapDecoderStatics
  {
    Guid BmpDecoderId { get; }

    Guid JpegDecoderId { get; }

    Guid PngDecoderId { get; }

    Guid TiffDecoderId { get; }

    Guid GifDecoderId { get; }

    Guid JpegXRDecoderId { get; }

    Guid IcoDecoderId { get; }

    IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator();

    [RemoteAsync]
    [Overload("CreateAsync")]
    IAsyncOperation<BitmapDecoder> CreateAsync(
      IRandomAccessStream stream);

    [Overload("CreateWithIdAsync")]
    [RemoteAsync]
    IAsyncOperation<BitmapDecoder> CreateAsync(
      Guid decoderId,
      IRandomAccessStream stream);
  }
}
