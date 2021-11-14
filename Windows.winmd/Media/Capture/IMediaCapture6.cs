// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture6
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(579422397, 19232, 19377, 159, 214, 165, 131, 33, 42, 16, 18)]
  [ExclusiveTo(typeof (MediaCapture))]
  internal interface IMediaCapture6
  {
    event TypedEventHandler<MediaCapture, MediaCaptureDeviceExclusiveControlStatusChangedEventArgs> CaptureDeviceExclusiveControlStatusChanged;

    [RemoteAsync]
    IAsyncOperation<MultiSourceMediaFrameReader> CreateMultiSourceFrameReaderAsync(
      IIterable<MediaFrameSource> inputSources);
  }
}
