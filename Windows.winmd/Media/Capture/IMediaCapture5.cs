// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media.Capture.Frames;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [Guid(3665329186, 15003, 18208, 167, 30, 151, 144, 10, 49, 110, 90)]
  [ExclusiveTo(typeof (MediaCapture))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaCapture5
  {
    [RemoteAsync]
    IAsyncAction RemoveEffectAsync(IMediaExtension effect);

    [RemoteAsync]
    IAsyncOperation<MediaCapturePauseResult> PauseRecordWithResultAsync(
      MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncOperation<MediaCaptureStopResult> StopRecordWithResultAsync();

    IMapView<string, MediaFrameSource> FrameSources { get; }

    [Overload("CreateFrameReaderAsync")]
    [RemoteAsync]
    IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource);

    [RemoteAsync]
    [Overload("CreateFrameReaderWithSubtypeAsync")]
    IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype);

    [Overload("CreateFrameReaderWithSubtypeAndSizeAsync")]
    [RemoteAsync]
    IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype,
      BitmapSize outputSize);
  }
}
