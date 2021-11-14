// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(4131883301, 40460, 15286, 153, 126, 182, 78, 204, 162, 76, 244)]
  [ExclusiveTo(typeof (SpatialLocator))]
  internal interface ISpatialLocator
  {
    SpatialLocatability Locatability { get; }

    event TypedEventHandler<SpatialLocator, object> LocatabilityChanged;

    event TypedEventHandler<SpatialLocator, SpatialLocatorPositionalTrackingDeactivatingEventArgs> PositionalTrackingDeactivating;

    SpatialLocation TryLocateAtTimestamp(
      PerceptionTimestamp timestamp,
      SpatialCoordinateSystem coordinateSystem);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeading")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading();

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocation")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation();

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);
  }
}
