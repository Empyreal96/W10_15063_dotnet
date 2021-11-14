// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3134025686, 64264, 18759, 174, 162, 206, 20, 239, 240, 206, 19)]
  [ExclusiveTo(typeof (MediaCapture))]
  internal interface IMediaCapture4
  {
    IAsyncOperation<IMediaExtension> AddAudioEffectAsync(
      IAudioEffectDefinition definition);

    IAsyncOperation<IMediaExtension> AddVideoEffectAsync(
      IVideoEffectDefinition definition,
      MediaStreamType mediaStreamType);

    [RemoteAsync]
    IAsyncAction PauseRecordAsync(MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncAction ResumeRecordAsync();

    event TypedEventHandler<MediaCapture, object> CameraStreamStateChanged;

    CameraStreamState CameraStreamState { get; }

    [Overload("GetPreviewFrameAsync")]
    [RemoteAsync]
    IAsyncOperation<VideoFrame> GetPreviewFrameAsync();

    [Overload("GetPreviewFrameCopyAsync")]
    [RemoteAsync]
    IAsyncOperation<VideoFrame> GetPreviewFrameAsync(VideoFrame destination);

    event TypedEventHandler<MediaCapture, object> ThermalStatusChanged;

    MediaCaptureThermalStatus ThermalStatus { get; }

    IAsyncOperation<AdvancedPhotoCapture> PrepareAdvancedPhotoCaptureAsync(
      ImageEncodingProperties encodingProperties);
  }
}
