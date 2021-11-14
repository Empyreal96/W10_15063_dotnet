// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocircleFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2950058783, 29361, 20349, 135, 204, 78, 212, 201, 132, 156, 5)]
  [ExclusiveTo(typeof (Geocircle))]
  internal interface IGeocircleFactory
  {
    Geocircle Create(BasicGeoposition position, double radius);

    Geocircle CreateWithAltitudeReferenceSystem(
      BasicGeoposition position,
      double radius,
      AltitudeReferenceSystem altitudeReferenceSystem);

    Geocircle CreateWithAltitudeReferenceSystemAndSpatialReferenceId(
      BasicGeoposition position,
      double radius,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
