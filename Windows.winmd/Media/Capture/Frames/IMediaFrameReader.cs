// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameReader))]
  [Guid(3838395285, 8232, 18669, 144, 176, 209, 193, 177, 98, 226, 76)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaFrameReader : IClosable
  {
    event TypedEventHandler<MediaFrameReader, MediaFrameArrivedEventArgs> FrameArrived;

    MediaFrameReference TryAcquireLatestFrame();

    [RemoteAsync]
    IAsyncOperation<MediaFrameReaderStartStatus> StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();
  }
}
