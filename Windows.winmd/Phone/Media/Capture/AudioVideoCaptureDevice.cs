// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.AudioVideoCaptureDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [WebHostHidden]
  [Static(typeof (IAudioVideoCaptureDeviceStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class AudioVideoCaptureDevice : 
    IClosable,
    ICameraCaptureDevice,
    IAudioVideoCaptureDevice
  {
    [MethodImpl]
    public extern void Close();

    public extern CameraSensorLocation SensorLocation { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern uint SensorRotationInDegrees { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern Size PreviewResolution { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncAction SetPreviewResolutionAsync(Size value);

    public extern Size CaptureResolution { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncAction SetCaptureResolutionAsync(Size value);

    public extern event TypedEventHandler<ICameraCaptureDevice, object> PreviewFrameAvailable;

    public extern event TypedEventHandler<ICameraCaptureDevice, VendorSpecificDataEventArgs> VendorSpecificDataAvailable;

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    [return: Variant]
    public extern object GetProperty(Guid propertyId);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern void SetProperty(Guid propertyId, [Variant] object value);

    public extern IReference<Rect> FocusRegion { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncOperation<CameraFocusStatus> FocusAsync();

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncOperation<CameraFocusStatus> ResetFocusAsync();

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern void GetPreviewBufferArgb([Out] int[] pixels);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern void GetPreviewBufferY([Out] byte[] pixels);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern void GetPreviewBufferYCbCr([Out] byte[] pixels);

    public extern CameraCaptureAudioFormat AudioEncodingFormat { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern CameraCaptureVideoFormat VideoEncodingFormat { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] set; [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern event TypedEventHandler<AudioVideoCaptureDevice, CaptureFailedEventArgs> RecordingFailed;

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncAction StartRecordingToStreamAsync(IRandomAccessStream stream);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncAction StartRecordingToSinkAsync();

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public extern IAsyncAction StopRecordingAsync();

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<AudioVideoCaptureDevice> OpenAsync(
      CameraSensorLocation sensor,
      Size initialResolution);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<AudioVideoCaptureDevice> OpenForVideoOnlyAsync(
      CameraSensorLocation sensor,
      Size initialResolution);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IAsyncOperation<AudioVideoCaptureDevice> OpenForAudioOnlyAsync();

    public static extern IVectorView<CameraSensorLocation> AvailableSensorLocations { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IVectorView<Size> GetAvailablePreviewResolutions(
      CameraSensorLocation sensor);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern IVectorView<Size> GetAvailableCaptureResolutions(
      CameraSensorLocation sensor);

    public static extern IVectorView<CameraCaptureAudioFormat> SupportedAudioEncodingFormats { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public static extern IVectorView<CameraCaptureVideoFormat> SupportedVideoEncodingFormats { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    public static extern CameraCapturePropertyRange GetSupportedPropertyRange(
      CameraSensorLocation sensor,
      Guid propertyId);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [MethodImpl]
    [return: HasVariant]
    public static extern IVectorView<object> GetSupportedPropertyValues(
      CameraSensorLocation sensor,
      Guid propertyId);
  }
}
