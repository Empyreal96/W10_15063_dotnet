// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAdvancedPhotoCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2214570746, 26215, 17628, 151, 60, 166, 188, 229, 150, 170, 15)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AdvancedPhotoCapture))]
  internal interface IAdvancedPhotoCapture
  {
    [RemoteAsync]
    [Overload("CaptureAsync")]
    IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync();

    [RemoteAsync]
    [Overload("CaptureWithContextAsync")]
    IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync(
      object context);

    event TypedEventHandler<AdvancedPhotoCapture, OptionalReferencePhotoCapturedEventArgs> OptionalReferencePhotoCaptured;

    event TypedEventHandler<AdvancedPhotoCapture, object> AllPhotosCaptured;

    [RemoteAsync]
    IAsyncAction FinishAsync();
  }
}
