// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialStageFrameOfReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2055877732, 44301, 17808, 171, 134, 51, 6, 43, 103, 73, 38)]
  [ExclusiveTo(typeof (SpatialStageFrameOfReference))]
  internal interface ISpatialStageFrameOfReference
  {
    SpatialCoordinateSystem CoordinateSystem { get; }

    SpatialMovementRange MovementRange { get; }

    SpatialLookDirectionRange LookDirectionRange { get; }

    SpatialCoordinateSystem GetCoordinateSystemAtCurrentLocation(
      SpatialLocator locator);

    Vector3[] TryGetMovementBounds(SpatialCoordinateSystem coordinateSystem);
  }
}
