// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraRenderingParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicCameraRenderingParameters))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2393648849, 23540, 19990, 130, 54, 174, 8, 0, 193, 29, 13)]
  internal interface IHolographicCameraRenderingParameters
  {
    [Overload("SetFocusPoint")]
    void SetFocusPoint(SpatialCoordinateSystem coordinateSystem, Vector3 position);

    [Overload("SetFocusPointWithNormal")]
    void SetFocusPoint(SpatialCoordinateSystem coordinateSystem, Vector3 position, Vector3 normal);

    [Overload("SetFocusPointWithNormalLinearVelocity")]
    void SetFocusPoint(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Vector3 normal,
      Vector3 linearVelocity);

    IDirect3DDevice Direct3D11Device { get; }

    IDirect3DSurface Direct3D11BackBuffer { get; }
  }
}
