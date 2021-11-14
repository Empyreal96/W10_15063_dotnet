// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCameraRenderingParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicCameraRenderingParameters : 
    IHolographicCameraRenderingParameters,
    IHolographicCameraRenderingParameters2
  {
    [Overload("SetFocusPoint")]
    [MethodImpl]
    public extern void SetFocusPoint(SpatialCoordinateSystem coordinateSystem, Vector3 position);

    [Overload("SetFocusPointWithNormal")]
    [MethodImpl]
    public extern void SetFocusPoint(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Vector3 normal);

    [Overload("SetFocusPointWithNormalLinearVelocity")]
    [MethodImpl]
    public extern void SetFocusPoint(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Vector3 normal,
      Vector3 linearVelocity);

    public extern IDirect3DDevice Direct3D11Device { [MethodImpl] get; }

    public extern IDirect3DSurface Direct3D11BackBuffer { [MethodImpl] get; }

    public extern HolographicReprojectionMode ReprojectionMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void CommitDirect3D11DepthBuffer(IDirect3DSurface value);
  }
}
