// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopointFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geopoint))]
  [Guid(3681258803, 30397, 20016, 138, 247, 168, 68, 220, 55, 183, 160)]
  internal interface IGeopointFactory
  {
    Geopoint Create(BasicGeoposition position);

    Geopoint CreateWithAltitudeReferenceSystem(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem);

    Geopoint CreateWithAltitudeReferenceSystemAndSpatialReferenceId(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
