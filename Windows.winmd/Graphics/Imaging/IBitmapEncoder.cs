// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapEncoder))]
  [Guid(734292195, 57848, 19284, 149, 232, 50, 145, 149, 81, 206, 98)]
  internal interface IBitmapEncoder
  {
    BitmapCodecInformation EncoderInformation { get; }

    BitmapProperties BitmapProperties { get; }

    BitmapProperties BitmapContainerProperties { get; }

    bool IsThumbnailGenerated { get; set; }

    uint GeneratedThumbnailWidth { get; set; }

    uint GeneratedThumbnailHeight { get; set; }

    BitmapTransform BitmapTransform { get; }

    void SetPixelData(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      uint width,
      uint height,
      double dpiX,
      double dpiY,
      [Range(0, 2147483647)] byte[] pixels);

    [Overload("GoToNextFrameAsync")]
    [RemoteAsync]
    IAsyncAction GoToNextFrameAsync();

    [Overload("GoToNextFrameWithEncodingOptionsAsync")]
    [RemoteAsync]
    IAsyncAction GoToNextFrameAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    [RemoteAsync]
    IAsyncAction FlushAsync();
  }
}
