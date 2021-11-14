// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMesh
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceMesh))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(277829593, 57101, 14672, 160, 253, 249, 114, 199, 124, 39, 180)]
  internal interface ISpatialSurfaceMesh
  {
    SpatialSurfaceInfo SurfaceInfo { get; }

    SpatialCoordinateSystem CoordinateSystem { get; }

    SpatialSurfaceMeshBuffer TriangleIndices { get; }

    SpatialSurfaceMeshBuffer VertexPositions { get; }

    Vector3 VertexPositionScale { get; }

    SpatialSurfaceMeshBuffer VertexNormals { get; }
  }
}
