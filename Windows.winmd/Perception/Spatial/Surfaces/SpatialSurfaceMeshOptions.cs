// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Perception.Spatial.Surfaces
{
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISpatialSurfaceMeshOptionsStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialSurfaceMeshOptions : ISpatialSurfaceMeshOptions
  {
    [MethodImpl]
    public extern SpatialSurfaceMeshOptions();

    public extern DirectXPixelFormat VertexPositionFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern DirectXPixelFormat TriangleIndexFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern DirectXPixelFormat VertexNormalFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IncludeVertexNormals { [MethodImpl] get; [MethodImpl] set; }

    public static extern IVectorView<DirectXPixelFormat> SupportedVertexPositionFormats { [MethodImpl] get; }

    public static extern IVectorView<DirectXPixelFormat> SupportedTriangleIndexFormats { [MethodImpl] get; }

    public static extern IVectorView<DirectXPixelFormat> SupportedVertexNormalFormats { [MethodImpl] get; }
  }
}
