// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraPose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [Guid(226328112, 4830, 17853, 145, 43, 199, 246, 86, 21, 153, 209)]
  [ExclusiveTo(typeof (HolographicCameraPose))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHolographicCameraPose
  {
    HolographicCamera HolographicCamera { get; }

    Rect Viewport { get; }

    IReference<HolographicStereoTransform> TryGetViewTransform(
      SpatialCoordinateSystem coordinateSystem);

    HolographicStereoTransform ProjectionTransform { get; }

    IReference<SpatialBoundingFrustum> TryGetCullingFrustum(
      SpatialCoordinateSystem coordinateSystem);

    IReference<SpatialBoundingFrustum> TryGetVisibleFrustum(
      SpatialCoordinateSystem coordinateSystem);

    double NearPlaneDistance { get; }

    double FarPlaneDistance { get; }
  }
}
