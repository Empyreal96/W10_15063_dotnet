// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoboundingBoxFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1308337545, 1041, 19132, 179, 181, 91, 188, 203, 87, 217, 140)]
  [ExclusiveTo(typeof (GeoboundingBox))]
  internal interface IGeoboundingBoxFactory
  {
    GeoboundingBox Create(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner);

    GeoboundingBox CreateWithAltitudeReference(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem);

    GeoboundingBox CreateWithAltitudeReferenceAndSpatialReference(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
