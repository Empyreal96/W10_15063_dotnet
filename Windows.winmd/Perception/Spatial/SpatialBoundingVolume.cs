// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialBoundingVolume
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialBoundingVolumeStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialBoundingVolume : ISpatialBoundingVolume
  {
    [MethodImpl]
    public static extern SpatialBoundingVolume FromBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingBox box);

    [MethodImpl]
    public static extern SpatialBoundingVolume FromOrientedBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingOrientedBox box);

    [MethodImpl]
    public static extern SpatialBoundingVolume FromSphere(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingSphere sphere);

    [MethodImpl]
    public static extern SpatialBoundingVolume FromFrustum(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingFrustum frustum);
  }
}
