// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialBoundingVolumeStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialBoundingVolume))]
  [Guid(92836119, 46049, 14040, 176, 23, 86, 97, 129, 165, 177, 150)]
  internal interface ISpatialBoundingVolumeStatics
  {
    SpatialBoundingVolume FromBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingBox box);

    SpatialBoundingVolume FromOrientedBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingOrientedBox box);

    SpatialBoundingVolume FromSphere(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingSphere sphere);

    SpatialBoundingVolume FromFrustum(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingFrustum frustum);
  }
}
