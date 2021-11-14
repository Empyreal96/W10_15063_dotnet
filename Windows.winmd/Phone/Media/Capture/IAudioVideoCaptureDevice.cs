// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.IAudioVideoCaptureDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.Media.Capture
{
  [ExclusiveTo(typeof (AudioVideoCaptureDevice))]
  [WebHostHidden]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(175546700, 57737, 17075, 172, 215, 114, 95, 69, 143, 60, 72)]
  internal interface IAudioVideoCaptureDevice : ICameraCaptureDevice, IClosable
  {
    CameraCaptureAudioFormat AudioEncodingFormat { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] set; [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    CameraCaptureVideoFormat VideoEncodingFormat { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] set; [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    event TypedEventHandler<AudioVideoCaptureDevice, CaptureFailedEventArgs> RecordingFailed;

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction StartRecordingToStreamAsync(IRandomAccessStream stream);

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction StartRecordingToSinkAsync();

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction StopRecordingAsync();
  }
}
