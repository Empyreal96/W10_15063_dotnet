// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media.Capture.Core;
using Windows.Media.Capture.Frames;
using Windows.Media.Devices;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [Static(typeof (IMediaCaptureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class MediaCapture : 
    IMediaCapture,
    IMediaCaptureVideoPreview,
    IMediaCapture2,
    IClosable,
    IMediaCapture3,
    IMediaCapture4,
    IMediaCapture5,
    IMediaCapture6
  {
    [MethodImpl]
    public extern MediaCapture();

    [RemoteAsync]
    [Overload("InitializeAsync")]
    [MethodImpl]
    public extern IAsyncAction InitializeAsync();

    [Overload("InitializeWithSettingsAsync")]
    [MethodImpl]
    public extern IAsyncAction InitializeAsync(
      MediaCaptureInitializationSettings mediaCaptureInitializationSettings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    [RemoteAsync]
    [Overload("StartRecordToCustomSinkAsync")]
    [MethodImpl]
    public extern IAsyncAction StartRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("StartRecordToCustomSinkIdAsync")]
    [MethodImpl]
    public extern IAsyncAction StartRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopRecordAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CapturePhotoToStorageFileAsync(
      ImageEncodingProperties type,
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CapturePhotoToStreamAsync(
      ImageEncodingProperties type,
      IRandomAccessStream stream);

    [Deprecated("AddEffectAsync might not be available in future versions of Windows. Starting with Windows Threshold, use AddAudioEffectAsync and AddVideoEffectAsync instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction AddEffectAsync(
      MediaStreamType mediaStreamType,
      string effectActivationID,
      IPropertySet effectSettings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearEffectsAsync(MediaStreamType mediaStreamType);

    [MethodImpl]
    public extern void SetEncoderProperty(
      MediaStreamType mediaStreamType,
      Guid propertyId,
      object propertyValue);

    [MethodImpl]
    public extern object GetEncoderProperty(MediaStreamType mediaStreamType, Guid propertyId);

    public extern event MediaCaptureFailedEventHandler Failed;

    public extern event RecordLimitationExceededEventHandler RecordLimitationExceeded;

    public extern MediaCaptureSettings MediaCaptureSettings { [MethodImpl] get; }

    public extern AudioDeviceController AudioDeviceController { [MethodImpl] get; }

    public extern VideoDeviceController VideoDeviceController { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPreviewMirroring(bool value);

    [MethodImpl]
    public extern bool GetPreviewMirroring();

    [MethodImpl]
    public extern void SetPreviewRotation(VideoRotation value);

    [MethodImpl]
    public extern VideoRotation GetPreviewRotation();

    [MethodImpl]
    public extern void SetRecordRotation(VideoRotation value);

    [MethodImpl]
    public extern VideoRotation GetRecordRotation();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartPreviewAsync();

    [Overload("StartPreviewToCustomSinkAsync")]
    [MethodImpl]
    public extern IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("StartPreviewToCustomSinkIdAsync")]
    [MethodImpl]
    public extern IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopPreviewAsync();

    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStorageFileAsync(
      MediaEncodingProfile encodingProfile,
      IStorageFile file);

    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToStreamAsync(
      MediaEncodingProfile encodingProfile,
      IRandomAccessStream stream);

    [Overload("PrepareLowLagRecordToCustomSinkAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("PrepareLowLagRecordToCustomSinkIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    [MethodImpl]
    public extern IAsyncOperation<LowLagPhotoCapture> PrepareLowLagPhotoCaptureAsync(
      ImageEncodingProperties type);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LowLagPhotoSequenceCapture> PrepareLowLagPhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    [MethodImpl]
    public extern IAsyncAction SetEncodingPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties,
      MediaPropertySet encoderProperties);

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VariablePhotoSequenceCapture> PrepareVariablePhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    public extern event TypedEventHandler<MediaCapture, MediaCaptureFocusChangedEventArgs> FocusChanged;

    public extern event TypedEventHandler<MediaCapture, PhotoConfirmationCapturedEventArgs> PhotoConfirmationCaptured;

    [MethodImpl]
    public extern IAsyncOperation<IMediaExtension> AddAudioEffectAsync(
      IAudioEffectDefinition definition);

    [MethodImpl]
    public extern IAsyncOperation<IMediaExtension> AddVideoEffectAsync(
      IVideoEffectDefinition definition,
      MediaStreamType mediaStreamType);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseRecordAsync(MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResumeRecordAsync();

    public extern event TypedEventHandler<MediaCapture, object> CameraStreamStateChanged;

    public extern CameraStreamState CameraStreamState { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("GetPreviewFrameAsync")]
    [MethodImpl]
    public extern IAsyncOperation<VideoFrame> GetPreviewFrameAsync();

    [Overload("GetPreviewFrameCopyAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VideoFrame> GetPreviewFrameAsync(
      VideoFrame destination);

    public extern event TypedEventHandler<MediaCapture, object> ThermalStatusChanged;

    public extern MediaCaptureThermalStatus ThermalStatus { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<AdvancedPhotoCapture> PrepareAdvancedPhotoCaptureAsync(
      ImageEncodingProperties encodingProperties);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveEffectAsync(IMediaExtension effect);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCapturePauseResult> PauseRecordWithResultAsync(
      MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCaptureStopResult> StopRecordWithResultAsync();

    public extern IMapView<string, MediaFrameSource> FrameSources { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("CreateFrameReaderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource);

    [Overload("CreateFrameReaderWithSubtypeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype);

    [Overload("CreateFrameReaderWithSubtypeAndSizeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype,
      BitmapSize outputSize);

    public extern event TypedEventHandler<MediaCapture, MediaCaptureDeviceExclusiveControlStatusChangedEventArgs> CaptureDeviceExclusiveControlStatusChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MultiSourceMediaFrameReader> CreateMultiSourceFrameReaderAsync(
      IIterable<MediaFrameSource> inputSources);

    [MethodImpl]
    public static extern bool IsVideoProfileSupported(string videoDeviceId);

    [MethodImpl]
    public static extern IVectorView<MediaCaptureVideoProfile> FindAllVideoProfiles(
      string videoDeviceId);

    [MethodImpl]
    public static extern IVectorView<MediaCaptureVideoProfile> FindConcurrentProfiles(
      string videoDeviceId);

    [MethodImpl]
    public static extern IVectorView<MediaCaptureVideoProfile> FindKnownVideoProfiles(
      string videoDeviceId,
      KnownVideoProfile name);
  }
}
