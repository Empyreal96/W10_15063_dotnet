// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.ICameraCaptureSequence
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [ExclusiveTo(typeof (CameraCaptureSequence))]
  [WebHostHidden]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(2407272220, 59236, 19682, 190, 180, 89, 76, 155, 19, 55, 231)]
  internal interface ICameraCaptureSequence
  {
    IVectorView<CameraCaptureFrame> Frames { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }

    event TypedEventHandler<CameraCaptureSequence, FrameAcquiredEventArgs> FrameAcquired;

    event TypedEventHandler<CameraCaptureSequence, object> BuffersAvailable;

    [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
    IAsyncAction StartCaptureAsync();
  }
}
