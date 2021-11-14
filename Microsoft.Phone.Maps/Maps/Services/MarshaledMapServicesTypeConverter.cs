// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MarshaledMapServicesTypeConverter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System;
using System.Collections.Generic;
using System.Device.Location;

namespace Microsoft.Phone.Maps.Services
{
  internal static class MarshaledMapServicesTypeConverter
  {
    public static MapAddress ToAddress(MarshaledAddress marshaledAddress) => new MapAddress()
    {
      BuildingName = marshaledAddress.BuildingName,
      BuildingFloor = marshaledAddress.BuildingFloor,
      BuildingRoom = marshaledAddress.BuildingRoom,
      BuildingZone = marshaledAddress.BuildingZone,
      HouseNumber = marshaledAddress.HouseNumber,
      Street = marshaledAddress.Street,
      Neighborhood = marshaledAddress.Neighborhood,
      Township = marshaledAddress.Township,
      District = marshaledAddress.District,
      City = marshaledAddress.City,
      County = marshaledAddress.County,
      Province = marshaledAddress.Province,
      State = marshaledAddress.State,
      StateCode = marshaledAddress.StateCode,
      Country = marshaledAddress.Country,
      CountryCode = marshaledAddress.CountryCode,
      PostalCode = marshaledAddress.PostalCode,
      Continent = marshaledAddress.Continent
    };

    public static MarshaledAddress ToMarshaledAddress(MapAddress address) => new MarshaledAddress()
    {
      BuildingName = address.BuildingName,
      BuildingFloor = address.BuildingFloor,
      BuildingRoom = address.BuildingRoom,
      BuildingZone = address.BuildingZone,
      HouseNumber = address.HouseNumber,
      Street = address.Street,
      Neighborhood = address.Neighborhood,
      Township = address.Township,
      District = address.District,
      City = address.City,
      County = address.County,
      Province = address.Province,
      State = address.State,
      StateCode = address.StateCode,
      Country = address.Country,
      CountryCode = address.CountryCode,
      PostalCode = address.PostalCode,
      Continent = address.Continent
    };

    public static LocationInformation ToLocationInformation(
      MarshaledLocationInformation marshaledLocationInformation)
    {
      return new LocationInformation()
      {
        Name = marshaledLocationInformation.Name,
        Description = marshaledLocationInformation.Description,
        Address = MarshaledMapServicesTypeConverter.ToAddress(marshaledLocationInformation.Address)
      };
    }

    public static MarshaledLocationInformation ToMarshaledLocationInformation(
      LocationInformation locationInformation)
    {
      return new MarshaledLocationInformation()
      {
        Name = locationInformation.Name,
        Description = locationInformation.Description,
        Address = MarshaledMapServicesTypeConverter.ToMarshaledAddress(locationInformation.Address)
      };
    }

    public static MapLocation ToLocation(MarshaledLocation marshaledLocation) => new MapLocation()
    {
      GeoCoordinate = MarshaledTypeConverter.ToGeoCoordinates(marshaledLocation.Coordinates),
      BoundingBox = MarshaledTypeConverter.ToLocationRectangle(marshaledLocation.BoundingBox),
      Information = MarshaledMapServicesTypeConverter.ToLocationInformation(marshaledLocation.Information)
    };

    public static MarshaledLocation ToMarshaledLocation(MapLocation location) => new MarshaledLocation()
    {
      Coordinates = MarshaledTypeConverter.ToMarshaledGeoCoordinates(location.GeoCoordinate),
      BoundingBox = MarshaledTypeConverter.ToMarshaledBoundingRectangle(location.BoundingBox),
      Information = MarshaledMapServicesTypeConverter.ToMarshaledLocationInformation(location.Information)
    };

    public static Route ToRoute(
      MarshaledRoute marshaledRoute,
      RouteSafeHandle nativeRouteHandle)
    {
      Route route = new Route();
      route.NativeHandle = nativeRouteHandle;
      route.LengthInMeters = (int) marshaledRoute.RoutePath.LengthInMeters;
      route.EstimatedDuration = TimeSpan.FromSeconds((double) marshaledRoute.RoutePath.DurationInSeconds);
      route.BoundingBox = MarshaledTypeConverter.ToLocationRectangle(marshaledRoute.RoutePath.BoundingBox);
      List<GeoCoordinate> geoCoordinateList = new List<GeoCoordinate>((int) marshaledRoute.RoutePath.GeometryCoordinatesCount);
      for (uint index = 0; index < marshaledRoute.RoutePath.GeometryCoordinatesCount; ++index)
      {
        GeoCoordinate geoCoordinates = MarshaledTypeConverter.ToGeoCoordinates(marshaledRoute.RoutePath.GetGeometryCoordinates(index));
        geoCoordinateList.Add(geoCoordinates);
      }
      route.Geometry = geoCoordinateList.AsReadOnly();
      List<RouteLeg> routeLegList = new List<RouteLeg>((int) marshaledRoute.LegCount);
      for (uint index = 0; index < marshaledRoute.LegCount; ++index)
      {
        RouteLeg routeLeg = MarshaledMapServicesTypeConverter.ToRouteLeg(marshaledRoute.GetLeg(index));
        routeLegList.Add(routeLeg);
      }
      route.Legs = routeLegList.AsReadOnly();
      return route;
    }

    public static RouteLeg ToRouteLeg(MarshaledRouteLeg marshaledLeg)
    {
      RouteLeg routeLeg = new RouteLeg();
      routeLeg.LengthInMeters = (int) marshaledLeg.RoutePath.LengthInMeters;
      routeLeg.EstimatedDuration = TimeSpan.FromSeconds((double) marshaledLeg.RoutePath.DurationInSeconds);
      routeLeg.BoundingBox = MarshaledTypeConverter.ToLocationRectangle(marshaledLeg.RoutePath.BoundingBox);
      List<GeoCoordinate> geoCoordinateList = new List<GeoCoordinate>((int) marshaledLeg.RoutePath.GeometryCoordinatesCount);
      for (uint index = 0; index < marshaledLeg.RoutePath.GeometryCoordinatesCount; ++index)
      {
        GeoCoordinate geoCoordinates = MarshaledTypeConverter.ToGeoCoordinates(marshaledLeg.RoutePath.GetGeometryCoordinates(index));
        geoCoordinateList.Add(geoCoordinates);
      }
      routeLeg.Geometry = geoCoordinateList.AsReadOnly();
      List<RouteManeuver> routeManeuverList = new List<RouteManeuver>((int) marshaledLeg.ManeuverCount);
      for (uint index = 0; index < marshaledLeg.ManeuverCount; ++index)
      {
        RouteManeuver routeManeuver = MarshaledMapServicesTypeConverter.ToRouteManeuver(marshaledLeg.GetManeuver(index));
        routeManeuverList.Add(routeManeuver);
      }
      routeLeg.Maneuvers = routeManeuverList.AsReadOnly();
      return routeLeg;
    }

    public static RouteManeuver ToRouteManeuver(
      MarshaledRouteManeuver marshaledManeuver)
    {
      RouteManeuver routeManeuver;
      if (marshaledManeuver.ManeuverType == RouteManeuverInstructionKind.TrafficCircleLeft || marshaledManeuver.ManeuverType == RouteManeuverInstructionKind.TrafficCircleRight)
        routeManeuver = (RouteManeuver) new TrafficCircleRouteManeuver()
        {
          ExitNumber = (int) marshaledManeuver.TrafficCircleExitNumber
        };
      else
        routeManeuver = new RouteManeuver();
      routeManeuver.StartGeoCoordinate = MarshaledTypeConverter.ToGeoCoordinates(marshaledManeuver.StartCoordinates);
      routeManeuver.LengthInMeters = (int) marshaledManeuver.DistanceInMetersToNextManeuver;
      routeManeuver.InstructionText = marshaledManeuver.GetInstructionText();
      routeManeuver.InstructionKind = marshaledManeuver.ManeuverType;
      return routeManeuver;
    }
  }
}
