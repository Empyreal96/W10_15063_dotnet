// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (ISpatialLocatorStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialLocator : ISpatialLocator
  {
    public extern SpatialLocatability Locatability { [MethodImpl] get; }

    public extern event TypedEventHandler<SpatialLocator, object> LocatabilityChanged;

    public extern event TypedEventHandler<SpatialLocator, SpatialLocatorPositionalTrackingDeactivatingEventArgs> PositionalTrackingDeactivating;

    [MethodImpl]
    public extern SpatialLocation TryLocateAtTimestamp(
      PerceptionTimestamp timestamp,
      SpatialCoordinateSystem coordinateSystem);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeading")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading();

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocation")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation();

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);

    [MethodImpl]
    public static extern SpatialLocator GetDefault();
  }
}
