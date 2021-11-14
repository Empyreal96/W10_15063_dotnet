// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MarshaledTypeConverter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class MarshaledTypeConverter
  {
    public static MarshaledGeoCoordinates ToMarshaledGeoCoordinates(
      GeoCoordinate coordinates)
    {
      return new MarshaledGeoCoordinates(coordinates.Latitude, coordinates.Longitude, true);
    }

    public static MarshaledGeoCoordinates ToMarshaledGeoCoordinates(
      double latitude,
      double longtitude)
    {
      return new MarshaledGeoCoordinates(latitude, longtitude, true);
    }

    public static MarshaledGeoCoordinates[] ToMarshaledGeoCoordinatesArray(
      IEnumerable<GeoCoordinate> coordinates)
    {
      return ((IEnumerable<MarshaledGeoCoordinates>) Enumerable.Select<GeoCoordinate, MarshaledGeoCoordinates>((IEnumerable<M0>) coordinates, (Func<M0, M1>) (x => MarshaledTypeConverter.ToMarshaledGeoCoordinates(x)))).ToArray<MarshaledGeoCoordinates>();
    }

    public static MarshaledMargins ToMarshaledMargins(Thickness thickness) => new MarshaledMargins(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom);

    public static MarshaledBoundingRectangle ToMarshaledBoundingRectangle(
      LocationRectangle rect)
    {
      double num = rect.WidthInDegrees / 2.0;
      return new MarshaledBoundingRectangle(MarshaledTypeConverter.ToMarshaledGeoCoordinates(rect.North, rect.Center.Longitude - num), MarshaledTypeConverter.ToMarshaledGeoCoordinates(rect.South, rect.Center.Longitude + num), true);
    }

    public static GeoCoordinate ToGeoCoordinates(MarshaledGeoCoordinates coordinates) => new GeoCoordinate(coordinates.Latitude, coordinates.Longitude);

    public static LocationRectangle ToLocationRectangle(
      MarshaledBoundingRectangle rect)
    {
      return !rect.IsValid ? (LocationRectangle) null : new LocationRectangle(MarshaledTypeConverter.ToGeoCoordinates(rect.Northwest), MarshaledTypeConverter.ToGeoCoordinates(rect.Southeast));
    }
  }
}
