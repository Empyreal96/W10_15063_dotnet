// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceInfo))]
  [Guid(4176079847, 14775, 14690, 187, 3, 87, 245, 110, 31, 176, 161)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialSurfaceInfo
  {
    Guid Id { get; }

    global::Windows.Foundation.DateTime UpdateTime { get; }

    IReference<SpatialBoundingOrientedBox> TryGetBounds(
      SpatialCoordinateSystem coordinateSystem);

    [RemoteAsync]
    [Overload("TryComputeLatestMeshAsync")]
    IAsyncOperation<SpatialSurfaceMesh> TryComputeLatestMeshAsync(
      double maxTrianglesPerCubicMeter);

    [Overload("TryComputeLatestMeshWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<SpatialSurfaceMesh> TryComputeLatestMeshAsync(
      double maxTrianglesPerCubicMeter,
      SpatialSurfaceMeshOptions options);
  }
}
