// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMeshOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Perception.Spatial.Surfaces
{
  [Guid(3530923913, 13682, 15661, 161, 13, 95, 238, 147, 148, 170, 55)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialSurfaceMeshOptions))]
  internal interface ISpatialSurfaceMeshOptions
  {
    DirectXPixelFormat VertexPositionFormat { get; set; }

    DirectXPixelFormat TriangleIndexFormat { get; set; }

    DirectXPixelFormat VertexNormalFormat { get; set; }

    bool IncludeVertexNormals { get; set; }
  }
}
