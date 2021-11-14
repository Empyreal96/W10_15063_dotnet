// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3097871631, 7268, 19514, 129, 235, 31, 124, 21, 42, 251, 187)]
  [ExclusiveTo(typeof (MapRouteFinder))]
  internal interface IMapRouteFinderStatics
  {
    [Overload("GetDrivingRouteAsync")]
    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization);

    [Overload("GetDrivingRouteWithOptimizationAndRestrictionsAsync")]
    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationRestrictionsAndHeadingAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [Overload("GetDrivingRouteFromWaypointsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);

    [Overload("GetDrivingRouteFromWaypointsAndOptimizationAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization);

    [Overload("GetDrivingRouteFromWaypointsOptimizationAndRestrictionsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [Overload("GetDrivingRouteFromWaypointsOptimizationRestrictionsAndHeadingAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetWalkingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    IAsyncOperation<MapRouteFinderResult> GetWalkingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);
  }
}
