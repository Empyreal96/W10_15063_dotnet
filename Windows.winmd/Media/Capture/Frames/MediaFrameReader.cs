// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaFrameReader : IMediaFrameReader, IClosable
  {
    public extern event TypedEventHandler<MediaFrameReader, MediaFrameArrivedEventArgs> FrameArrived;

    [MethodImpl]
    public extern MediaFrameReference TryAcquireLatestFrame();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReaderStartStatus> StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [MethodImpl]
    public extern void Close();
  }
}
