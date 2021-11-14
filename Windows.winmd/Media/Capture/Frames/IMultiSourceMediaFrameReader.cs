// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMultiSourceMediaFrameReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(2366915586, 63331, 18573, 152, 242, 180, 55, 188, 240, 117, 231)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MultiSourceMediaFrameReader))]
  internal interface IMultiSourceMediaFrameReader : IClosable
  {
    event TypedEventHandler<MultiSourceMediaFrameReader, MultiSourceMediaFrameArrivedEventArgs> FrameArrived;

    MultiSourceMediaFrameReference TryAcquireLatestFrame();

    [RemoteAsync]
    IAsyncOperation<MultiSourceMediaFrameReaderStartStatus> StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();
  }
}
