// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopathFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(666806728, 51175, 17241, 155, 155, 252, 163, 224, 94, 245, 147)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geopath))]
  internal interface IGeopathFactory
  {
    Geopath Create(IIterable<BasicGeoposition> positions);

    Geopath CreateWithAltitudeReference(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem);

    Geopath CreateWithAltitudeReferenceAndSpatialReference(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
