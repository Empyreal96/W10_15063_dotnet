// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaFrameSource : IMediaFrameSource
  {
    public extern MediaFrameSourceInfo Info { [MethodImpl] get; }

    public extern MediaFrameSourceController Controller { [MethodImpl] get; }

    public extern IVectorView<MediaFrameFormat> SupportedFormats { [MethodImpl] get; }

    public extern MediaFrameFormat CurrentFormat { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetFormatAsync(MediaFrameFormat format);

    public extern event TypedEventHandler<MediaFrameSource, object> FormatChanged;

    [MethodImpl]
    public extern CameraIntrinsics TryGetCameraIntrinsics(MediaFrameFormat format);
  }
}
