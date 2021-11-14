// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IDepthCorrelatedCoordinateMapper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.Media.Devices.Core
{
  [Guid(4183656955, 35568, 19632, 146, 109, 105, 104, 102, 229, 4, 106)]
  [ExclusiveTo(typeof (DepthCorrelatedCoordinateMapper))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDepthCorrelatedCoordinateMapper : IClosable
  {
    Vector3 UnprojectPoint(Point sourcePoint, SpatialCoordinateSystem targetCoordinateSystem);

    void UnprojectPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      [Out] Vector3[] results);

    Point MapPoint(
      Point sourcePoint,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics);

    void MapPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics,
      [Out] Point[] results);
  }
}
