// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateSatelliteData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(3274339545, 9736, 18252, 145, 44, 6, 221, 73, 15, 74, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GeocoordinateSatelliteData))]
  internal interface IGeocoordinateSatelliteData
  {
    IReference<double> PositionDilutionOfPrecision { get; }

    IReference<double> HorizontalDilutionOfPrecision { get; }

    IReference<double> VerticalDilutionOfPrecision { get; }
  }
}
