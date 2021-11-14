// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapSceneStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(65318252, 34540, 17625, 149, 151, 251, 117, 183, 222, 186, 10)]
  [ExclusiveTo(typeof (MapScene))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapSceneStatics
  {
    [Overload("CreateFromBoundingBox")]
    MapScene CreateFromBoundingBox(GeoboundingBox bounds);

    [Overload("CreateFromBoundingBoxWithHeadingAndPitch")]
    MapScene CreateFromBoundingBox(
      GeoboundingBox bounds,
      double headingInDegrees,
      double pitchInDegrees);

    MapScene CreateFromCamera(MapCamera camera);

    [Overload("CreateFromLocation")]
    MapScene CreateFromLocation(Geopoint location);

    [Overload("CreateFromLocationWithHeadingAndPitch")]
    MapScene CreateFromLocation(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocationAndRadius")]
    MapScene CreateFromLocationAndRadius(Geopoint location, double radiusInMeters);

    [Overload("CreateFromLocationAndRadiusWithHeadingAndPitch")]
    MapScene CreateFromLocationAndRadius(
      Geopoint location,
      double radiusInMeters,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocations")]
    MapScene CreateFromLocations(IIterable<Geopoint> locations);

    [Overload("CreateFromLocationsWithHeadingAndPitch")]
    MapScene CreateFromLocations(
      IIterable<Geopoint> locations,
      double headingInDegrees,
      double pitchInDegrees);
  }
}
