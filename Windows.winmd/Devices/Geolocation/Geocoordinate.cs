// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geocoordinate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class Geocoordinate : 
    IGeocoordinate,
    IGeocoordinateWithPositionData,
    IGeocoordinateWithPoint,
    IGeocoordinateWithPositionSourceTimestamp
  {
    public extern double Latitude { [Deprecated("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern double Longitude { [Deprecated("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern IReference<double> Altitude { [Deprecated("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern double Accuracy { [MethodImpl] get; }

    public extern IReference<double> AltitudeAccuracy { [MethodImpl] get; }

    public extern IReference<double> Heading { [MethodImpl] get; }

    public extern IReference<double> Speed { [MethodImpl] get; }

    public extern DateTime Timestamp { [MethodImpl] get; }

    public extern PositionSource PositionSource { [MethodImpl] get; }

    public extern GeocoordinateSatelliteData SatelliteData { [MethodImpl] get; }

    public extern Geopoint Point { [MethodImpl] get; }

    public extern IReference<DateTime> PositionSourceTimestamp { [MethodImpl] get; }
  }
}
