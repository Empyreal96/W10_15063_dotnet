// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  public sealed class DepthCorrelatedCoordinateMapper : IDepthCorrelatedCoordinateMapper, IClosable
  {
    [MethodImpl]
    public extern Vector3 UnprojectPoint(
      Point sourcePoint,
      SpatialCoordinateSystem targetCoordinateSystem);

    [MethodImpl]
    public extern void UnprojectPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      [Out] Vector3[] results);

    [MethodImpl]
    public extern Point MapPoint(
      Point sourcePoint,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics);

    [MethodImpl]
    public extern void MapPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics,
      [Out] Point[] results);

    [MethodImpl]
    public extern void Close();
  }
}
