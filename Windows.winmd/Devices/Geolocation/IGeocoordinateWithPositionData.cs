// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateWithPositionData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(2514891966, 56278, 16556, 184, 242, 166, 92, 3, 64, 217, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geocoordinate))]
  internal interface IGeocoordinateWithPositionData : IGeocoordinate
  {
    PositionSource PositionSource { get; }

    GeocoordinateSatelliteData SatelliteData { get; }
  }
}
