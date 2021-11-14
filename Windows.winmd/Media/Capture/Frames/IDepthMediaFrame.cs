// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IDepthMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [Guid(1192451663, 34121, 17856, 146, 91, 128, 211, 94, 253, 177, 10)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (DepthMediaFrame))]
  internal interface IDepthMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    VideoMediaFrame VideoMediaFrame { get; }

    DepthMediaFrameFormat DepthFormat { get; }

    DepthCorrelatedCoordinateMapper TryCreateCoordinateMapper(
      CameraIntrinsics cameraIntrinsics,
      SpatialCoordinateSystem coordinateSystem);
  }
}
