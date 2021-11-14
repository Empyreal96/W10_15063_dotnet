// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.LocationRectangle
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Device.Location;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Controls
{
  [TypeConverter(typeof (LocationRectangleConverter))]
  public class LocationRectangle : IFormattable, IEquatable<LocationRectangle>
  {
    private const double MaxLatitude = 90.0;
    private const double MinLatitude = -90.0;
    private const double MaxLongitude = 180.0;
    private const double MinLongitude = -180.0;
    private const double HalfLongitudeRange = 180.0;
    private const double FullLongitudeRange = 360.0;
    private GeoCoordinate center;
    private double halfHeight;
    private double halfWidth;

    public LocationRectangle() => this.center = new GeoCoordinate(0.0, 0.0);

    public LocationRectangle(GeoCoordinate center, double width, double height)
    {
      if (center == (GeoCoordinate) null)
        throw new ArgumentNullException(nameof (center));
      if (width < 0.0)
        throw new ArgumentOutOfRangeException(nameof (width), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.NegativeExceptionFormat, (object) nameof (width)));
      if (height < 0.0)
        throw new ArgumentOutOfRangeException(nameof (height), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.NegativeExceptionFormat, (object) nameof (height)));
      this.center = center;
      this.halfWidth = width / 2.0;
      this.halfHeight = height / 2.0;
    }

    public LocationRectangle(double north, double west, double south, double east) => this.Init(north, west, south, east);

    public LocationRectangle(GeoCoordinate northwest, GeoCoordinate southeast)
    {
      if (northwest == (GeoCoordinate) null)
        throw new ArgumentNullException(nameof (northwest));
      if (southeast == (GeoCoordinate) null)
        throw new ArgumentNullException(nameof (southeast));
      this.Init(northwest.Latitude, northwest.Longitude, southeast.Latitude, southeast.Longitude);
    }

    public double North
    {
      get => this.center.Latitude + this.halfHeight;
      set => this.Init(value, this.West, this.South, this.East);
    }

    public double West
    {
      get => LocationRectangle.NormalizeLongitude(this.center.Longitude - this.halfWidth);
      set => this.Init(this.North, value, this.South, this.East);
    }

    public double South
    {
      get => this.center.Latitude - this.halfHeight;
      set => this.Init(this.North, this.West, value, this.East);
    }

    public double East
    {
      get => LocationRectangle.NormalizeLongitude(this.center.Longitude + this.halfWidth);
      set => this.Init(this.North, this.West, this.South, value);
    }

    public GeoCoordinate Center => this.center;

    public double WidthInDegrees => this.halfWidth * 2.0;

    public double HeightInDegrees => this.halfHeight * 2.0;

    public GeoCoordinate Northwest
    {
      get => new GeoCoordinate(this.North, this.West);
      set
      {
        if (value == (GeoCoordinate) null)
          throw new ArgumentNullException(nameof (value));
        this.Init(value.Latitude, value.Longitude, this.South, this.East);
      }
    }

    public GeoCoordinate Northeast
    {
      get => new GeoCoordinate(this.North, this.East);
      set
      {
        if (value == (GeoCoordinate) null)
          throw new ArgumentNullException(nameof (value));
        this.Init(value.Latitude, this.West, this.South, value.Longitude);
      }
    }

    public GeoCoordinate Southwest
    {
      get => new GeoCoordinate(this.South, this.West);
      set
      {
        if (value == (GeoCoordinate) null)
          throw new ArgumentNullException(nameof (value));
        this.Init(this.North, value.Longitude, value.Latitude, this.East);
      }
    }

    public GeoCoordinate Southeast
    {
      get => new GeoCoordinate(this.South, this.East);
      set
      {
        if (value == (GeoCoordinate) null)
          throw new ArgumentNullException(nameof (value));
        this.Init(this.North, this.West, value.Latitude, value.Longitude);
      }
    }

    internal bool IsValid => this.North >= this.South;

    public static LocationRectangle CreateBoundingRectangle(
      params GeoCoordinate[] locations)
    {
      return LocationRectangle.CreateBoundingRectangle((IEnumerable<GeoCoordinate>) locations);
    }

    public static LocationRectangle CreateBoundingRectangle(
      IEnumerable<GeoCoordinate> locations)
    {
      MarshaledGeoCoordinates[] coordinatesArray = locations != null ? MarshaledTypeConverter.ToMarshaledGeoCoordinatesArray(locations) : throw new ArgumentNullException(nameof (locations));
      MarshaledBoundingRectangle boundingRectangle;
      Marshal.ThrowExceptionForHR(Shim.GeoRect_CalculateGeoRect(coordinatesArray, coordinatesArray.Length, out boundingRectangle));
      return MarshaledTypeConverter.ToLocationRectangle(boundingRectangle);
    }

    public virtual object Clone() => (object) new LocationRectangle()
    {
      center = new GeoCoordinate(this.center.Latitude, this.center.Longitude, this.center.Altitude),
      halfHeight = this.halfHeight,
      halfWidth = this.halfWidth
    };

    public bool Equals(LocationRectangle other) => other != null && this.center == other.center && this.halfWidth == other.halfWidth && this.halfHeight == other.halfHeight;

    public override bool Equals(object obj) => this.Equals(obj as LocationRectangle);

    public override int GetHashCode() => ((object) this.center).GetHashCode() ^ this.halfWidth.GetHashCode() ^ this.halfHeight.GetHashCode();

    public override string ToString() => this.ToString((string) null, (IFormatProvider) null);

    public string ToString(string format, IFormatProvider provider) => string.Format(provider, "{0:" + format + "} {1:" + format + "}", (object) this.Northwest, (object) this.Southeast);

    public string ToString(IFormatProvider provider) => this.ToString((string) null, provider);

    public bool Intersects(LocationRectangle locationRectangle)
    {
      if (locationRectangle == null)
        throw new ArgumentNullException(nameof (locationRectangle));
      double num1 = Math.Abs(this.center.Latitude - locationRectangle.center.Latitude);
      double num2 = Math.Abs(this.center.Longitude - locationRectangle.center.Longitude);
      if (num2 > 180.0)
        num2 = 360.0 - num2;
      double num3 = this.halfHeight + locationRectangle.halfHeight;
      return num1 <= num3 && num2 <= this.halfWidth + locationRectangle.halfWidth;
    }

    public LocationRectangle GetIntersection(LocationRectangle locationRectangle)
    {
      if (locationRectangle == null)
        throw new ArgumentNullException(nameof (locationRectangle));
      if (!this.Intersects(locationRectangle))
        return new LocationRectangle();
      double val1_1 = this.center.Longitude - this.halfWidth;
      double val2_1 = locationRectangle.center.Longitude - locationRectangle.halfWidth;
      double val1_2 = this.center.Longitude + this.halfWidth;
      double val2_2 = locationRectangle.center.Longitude + locationRectangle.halfWidth;
      if (Math.Abs(this.center.Longitude - locationRectangle.center.Longitude) > 180.0)
      {
        if (this.center.Longitude < locationRectangle.center.Longitude)
        {
          val1_1 += 360.0;
          val1_2 += 360.0;
        }
        else
        {
          val2_1 += 360.0;
          val2_2 += 360.0;
        }
      }
      double num1 = Math.Max(val1_1, val2_1);
      double num2 = Math.Min(val1_2, val2_2);
      double north = Math.Min(this.North, locationRectangle.North);
      double num3 = Math.Max(this.South, locationRectangle.South);
      double west = num1;
      double south = num3;
      double east = num2;
      return new LocationRectangle(north, west, south, east);
    }

    private static double NormalizeLongitude(double longitude) => longitude < -180.0 || longitude >= 180.0 ? ((longitude + 180.0) % 360.0 + 360.0) % 360.0 - 180.0 : longitude;

    private void Init(double north, double west, double south, double east)
    {
      if (south < -90.0 || south > 90.0)
        throw new ArgumentOutOfRangeException(nameof (south), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) nameof (south), (object) -90.0, (object) 90.0));
      if (north < -90.0 || north > 90.0)
        throw new ArgumentOutOfRangeException(nameof (north), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) nameof (north), (object) -90.0, (object) 90.0));
      if (west > east)
      {
        west = LocationRectangle.NormalizeLongitude(west);
        east = LocationRectangle.NormalizeLongitude(east);
        if (west > east)
          east += 360.0;
      }
      this.center = new GeoCoordinate((south + north) / 2.0, LocationRectangle.NormalizeLongitude((west + east) / 2.0));
      this.halfHeight = (north - south) / 2.0;
      this.halfWidth = (east - west) / 2.0;
    }
  }
}
