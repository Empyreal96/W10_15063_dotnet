// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.IPhotoCaptureDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [Guid(2604786137, 56048, 19772, 181, 160, 200, 75, 77, 142, 199, 187)]
  [ExclusiveTo(typeof (PhotoCaptureDevice))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [WebHostHidden]
  internal interface IPhotoCaptureDeviceStatics
  {
    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncOperation<PhotoCaptureDevice> OpenAsync(
      CameraSensorLocation sensor,
      Size initialResolution);

    IVectorView<CameraSensorLocation> AvailableSensorLocations { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IVectorView<Size> GetAvailablePreviewResolutions(CameraSensorLocation sensor);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IVectorView<Size> GetAvailableCaptureResolutions(CameraSensorLocation sensor);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    bool IsFocusSupported(CameraSensorLocation sensor);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    bool IsFocusRegionSupported(CameraSensorLocation sensor);

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
