// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagMediaRecording3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1546890002, 18679, 18394, 180, 30, 144, 136, 10, 95, 224, 236)]
  [ExclusiveTo(typeof (LowLagMediaRecording))]
  internal interface ILowLagMediaRecording3
  {
    [RemoteAsync]
    IAsyncOperation<MediaCapturePauseResult> PauseWithResultAsync(
      MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncOperation<MediaCaptureStopResult> StopWithResultAsync();
  }
}
