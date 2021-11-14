// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.LowLagMediaRecording
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LowLagMediaRecording : 
    ILowLagMediaRecording,
    ILowLagMediaRecording2,
    ILowLagMediaRecording3
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

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseAsync(MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResumeAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCapturePauseResult> PauseWithResultAsync(
      MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaCaptureStopResult> StopWithResultAsync();
  }
}
