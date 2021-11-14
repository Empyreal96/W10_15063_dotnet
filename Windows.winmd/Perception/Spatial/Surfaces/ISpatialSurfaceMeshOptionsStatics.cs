// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMeshOptionsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceMeshOptions))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2603879103, 38785, 17669, 137, 53, 1, 53, 117, 202, 174, 94)]
  internal interface ISpatialSurfaceMeshOptionsStatics
  {
    IVectorView<DirectXPixelFormat> SupportedVertexPositionFormats { get; }

    IVectorView<DirectXPixelFormat> SupportedTriangleIndexFormats { get; }

    IVectorView<DirectXPixelFormat> SupportedVertexNormalFormats { get; }
  }
}
