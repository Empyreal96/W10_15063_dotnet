// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialAnchor))]
  [Guid(2844952130, 372, 12572, 174, 121, 14, 81, 7, 102, 159, 22)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialAnchorStatics
  {
    [Overload("TryCreateRelativeTo")]
    SpatialAnchor TryCreateRelativeTo(SpatialCoordinateSystem coordinateSystem);

    [Overload("TryCreateWithPositionRelativeTo")]
    SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position);

    [Overload("TryCreateWithPositionAndOrientationRelativeTo")]
    SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Quaternion orientation);
  }
}
