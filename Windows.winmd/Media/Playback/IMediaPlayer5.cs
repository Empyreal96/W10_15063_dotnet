// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(3487905789, 63594, 17478, 191, 77, 200, 231, 146, 183, 180, 179)]
  internal interface IMediaPlayer5
  {
    event TypedEventHandler<MediaPlayer, object> VideoFrameAvailable;

    bool IsVideoFrameServerEnabled { get; set; }

    [Overload("CopyFrameToVideoSurface")]
    void CopyFrameToVideoSurface(IDirect3DSurface destination);

    [Overload("CopyFrameToVideoSurfaceWithTargetRectangle")]
    void CopyFrameToVideoSurface(IDirect3DSurface destination, Rect targetRectangle);

    void CopyFrameToStereoscopicVideoSurfaces(
      IDirect3DSurface destinationLeftEye,
      IDirect3DSurface destinationRightEye);
  }
}
