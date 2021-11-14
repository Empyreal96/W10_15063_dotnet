// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geocoordinate))]
  [Guid(3995181994, 38762, 19568, 128, 61, 8, 62, 165, 91, 203, 196)]
  internal interface IGeocoordinate
  {
    double Latitude { [Deprecated("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    double Longitude { [Deprecated("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    IReference<double> Altitude { [Deprecated("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    double Accuracy { get; }

    IReference<double> AltitudeAccuracy { get; }

    IReference<double> Heading { get; }

    IReference<double> Speed { get; }

    DateTime Timestamp { get; }
  }
}
