// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.LowLagPhotoSequenceCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LowLagPhotoSequenceCapture : ILowLagPhotoSequenceCapture
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();

    public extern event TypedEventHandler<LowLagPhotoSequenceCapture, PhotoCapturedEventArgs> PhotoCaptured;
  }
}
