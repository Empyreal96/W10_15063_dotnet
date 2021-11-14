// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCameraPose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicCameraPose : IHolographicCameraPose
  {
    public extern HolographicCamera HolographicCamera { [MethodImpl] get; }

    public extern Rect Viewport { [MethodImpl] get; }

    [MethodImpl]
    public extern IReference<HolographicStereoTransform> TryGetViewTransform(
      SpatialCoordinateSystem coordinateSystem);

    public extern HolographicStereoTransform ProjectionTransform { [MethodImpl] get; }

    [MethodImpl]
    public extern IReference<SpatialBoundingFrustum> TryGetCullingFrustum(
      SpatialCoordinateSystem coordinateSystem);

    [MethodImpl]
    public extern IReference<SpatialBoundingFrustum> TryGetVisibleFrustum(
      SpatialCoordinateSystem coordinateSystem);

    public extern double NearPlaneDistance { [MethodImpl] get; }

    public extern double FarPlaneDistance { [MethodImpl] get; }
  }
}
