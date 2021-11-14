// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MapRouteFinder))]
  [Guid(4127818036, 22803, 4582, 139, 119, 134, 243, 12, 168, 147, 211)]
  [WebHostHidden]
  internal interface IMapRouteFinderStatics3
  {
    [Overload("GetDrivingRouteFromEnhancedWaypointsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints);

    [Overload("GetDrivingRouteFromEnhancedWaypointsWithOptionsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints,
      MapRouteDrivingOptions options);
  }
}
