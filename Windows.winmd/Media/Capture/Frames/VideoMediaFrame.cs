// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.VideoMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VideoMediaFrame : IVideoMediaFrame
  {
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    public extern VideoMediaFrameFormat VideoFormat { [MethodImpl] get; }

    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] get; }

    public extern IDirect3DSurface Direct3DSurface { [MethodImpl] get; }

    public extern CameraIntrinsics CameraIntrinsics { [MethodImpl] get; }

    public extern InfraredMediaFrame InfraredMediaFrame { [MethodImpl] get; }

    public extern DepthMediaFrame DepthMediaFrame { [MethodImpl] get; }

    [MethodImpl]
    public extern VideoFrame GetVideoFrame();
  }
}
