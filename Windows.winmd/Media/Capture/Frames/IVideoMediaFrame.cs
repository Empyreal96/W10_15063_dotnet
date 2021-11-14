// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IVideoMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(14503115, 12989, 20449, 160, 19, 124, 193, 60, 245, 219, 207)]
  [ExclusiveTo(typeof (VideoMediaFrame))]
  internal interface IVideoMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    VideoMediaFrameFormat VideoFormat { get; }

    SoftwareBitmap SoftwareBitmap { get; }

    IDirect3DSurface Direct3DSurface { get; }

    CameraIntrinsics CameraIntrinsics { get; }

    InfraredMediaFrame InfraredMediaFrame { get; }

    DepthMediaFrame DepthMediaFrame { get; }

    VideoFrame GetVideoFrame();
  }
}
