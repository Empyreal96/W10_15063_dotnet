// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MultiSourceMediaFrameReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class MultiSourceMediaFrameReader : IMultiSourceMediaFrameReader, IClosable
  {
    public extern event TypedEventHandler<MultiSourceMediaFrameReader, MultiSourceMediaFrameArrivedEventArgs> FrameArrived;

    [MethodImpl]
    public extern MultiSourceMediaFrameReference TryAcquireLatestFrame();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MultiSourceMediaFrameReaderStartStatus> StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [MethodImpl]
    public extern void Close();
  }
}
