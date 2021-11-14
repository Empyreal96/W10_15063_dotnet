// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteFinder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Static(typeof (IMapRouteFinderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapRouteFinderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMapRouteFinderStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class MapRouteFinder
  {
    [Overload("GetDrivingRouteFromEnhancedWaypointsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints);

    [Overload("GetDrivingRouteFromEnhancedWaypointsWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints,
      MapRouteDrivingOptions options);

    [DefaultOverload]
    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteDrivingOptions options);

    [Overload("GetDrivingRouteAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    [Overload("GetDrivingRouteWithOptimizationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization);

    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationAndRestrictionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationRestrictionsAndHeadingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [Overload("GetDrivingRouteFromWaypointsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);

    [Overload("GetDrivingRouteFromWaypointsAndOptimizationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization);

    [Overload("GetDrivingRouteFromWaypointsOptimizationAndRestrictionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [Overload("GetDrivingRouteFromWaypointsOptimizationRestrictionsAndHeadingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetWalkingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetWalkingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);
  }
}
