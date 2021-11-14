// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [Guid(3323657140, 64272, 18996, 172, 24, 202, 128, 217, 200, 231, 238)]
  [ExclusiveTo(typeof (MediaCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCapture
  {
    [Overload("InitializeAsync")]
    [RemoteAsync]
    IAsyncAction InitializeAsync();

    [Overload("InitializeWithSettingsAsync")]
    IAsyncAction InitializeAsync(
      MediaCaptureInitializationSettings mediaCaptureInitializationSettings);

    [RemoteAsync]
    IAsyncAction StartRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    [RemoteAsync]
    IAsyncAction StartRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    [Overload("StartRecordToCustomSinkAsync")]
    [RemoteAsync]
    IAsyncAction StartRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("StartRecordToCustomSinkIdAsync")]
    IAsyncAction StartRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    [RemoteAsync]
    IAsyncAction StopRecordAsync();

    [RemoteAsync]
    IAsyncAction CapturePhotoToStorageFileAsync(
      ImageEncodingProperties type,
      IStorageFile file);

    [RemoteAsync]
    IAsyncAction CapturePhotoToStreamAsync(
      ImageEncodingProperties type,
      IRandomAccessStream stream);

    [Deprecated("AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction AddEffectAsync(
      MediaStreamType mediaStreamType,
      string effectActivationID,
      IPropertySet effectSettings);

    [RemoteAsync]
    IAsyncAction ClearEffectsAsync(MediaStreamType mediaStreamType);

    void SetEncoderProperty(MediaStreamType mediaStreamType, Guid propertyId, object propertyValue);

    object GetEncoderProperty(MediaStreamType mediaStreamType, Guid propertyId);

    event MediaCaptureFailedEventHandler Failed;

    event RecordLimitationExceededEventHandler RecordLimitationExceeded;

    MediaCaptureSettings MediaCaptureSettings { get; }

    AudioDeviceController AudioDeviceController { get; }

    VideoDeviceController VideoDeviceController { get; }

    void SetPreviewMirroring(bool value);

    bool GetPreviewMirroring();

    void SetPreviewRotation(VideoRotation value);

    VideoRotation GetPreviewRotation();

    void SetRecordRotation(VideoRotation value);

    VideoRotation GetRecordRotation();
  }
}
