// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.IAudioVideoCaptureDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AudioVideoCaptureDevice))]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(4184585050, 34689, 17783, 183, 58, 23, 4, 22, 79, 57, 68)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IAudioVideoCaptureDeviceStatics
  {
    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<AudioVideoCaptureDevice> OpenAsync(
      CameraSensorLocation sensor,
      Size initialResolution);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<AudioVideoCaptureDevice> OpenForVideoOnlyAsync(
      CameraSensorLocation sensor,
      Size initialResolution);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<AudioVideoCaptureDevice> OpenForAudioOnlyAsync();

    IVectorView<CameraSensorLocation> AvailableSensorLocations { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IVectorView<Size> GetAvailablePreviewResolutions(CameraSensorLocation sensor);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IVectorView<Size> GetAvailableCaptureResolutions(CameraSensorLocation sensor);

    IVectorView<CameraCaptureAudioFormat> SupportedAudioEncodingFormats { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    IVectorView<CameraCaptureVideoFormat> SupportedVideoEncodingFormats { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    CameraCapturePropertyRange GetSupportedPropertyRange(
      CameraSensorLocation sensor,
      Guid propertyId);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    [return: HasVariant]
    IVectorView<object> GetSupportedPropertyValues(
      CameraSensorLocation sensor,
      Guid propertyId);
  }
}
