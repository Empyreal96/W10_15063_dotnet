// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.AdvancedPhotoCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdvancedPhotoCapture : IAdvancedPhotoCapture
  {
    [Overload("CaptureAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync();

    [Overload("CaptureWithContextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync(
      object context);

    public extern event TypedEventHandler<AdvancedPhotoCapture, OptionalReferencePhotoCapturedEventArgs> OptionalReferencePhotoCaptured;

    public extern event TypedEventHandler<AdvancedPhotoCapture, object> AllPhotosCaptured;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();
  }
}
