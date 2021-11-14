// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Surfaces
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [GCPressure(amount = GCPressureAmount.Medium)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialSurfaceMesh : ISpatialSurfaceMesh
  {
    public extern SpatialSurfaceInfo SurfaceInfo { [MethodImpl] get; }

    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    public extern SpatialSurfaceMeshBuffer TriangleIndices { [MethodImpl] get; }

    public extern SpatialSurfaceMeshBuffer VertexPositions { [MethodImpl] get; }

    public extern Vector3 VertexPositionScale { [MethodImpl] get; }

    public extern SpatialSurfaceMeshBuffer VertexNormals { [MethodImpl] get; }
  }
}
