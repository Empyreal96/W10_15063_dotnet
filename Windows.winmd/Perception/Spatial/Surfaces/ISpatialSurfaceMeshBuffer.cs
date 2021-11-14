// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMeshBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial.Surfaces
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2479839712, 34591, 13304, 152, 178, 3, 209, 1, 69, 143, 111)]
  [ExclusiveTo(typeof (SpatialSurfaceMeshBuffer))]
  internal interface ISpatialSurfaceMeshBuffer
  {
    DirectXPixelFormat Format { get; }

    uint Stride { get; }

    uint ElementCount { get; }

    IBuffer Data { get; }
  }
}
