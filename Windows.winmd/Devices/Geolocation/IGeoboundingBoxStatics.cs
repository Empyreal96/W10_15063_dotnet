// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoboundingBoxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(1740113672, 58906, 19664, 132, 27, 147, 35, 55, 146, 181, 202)]
  [ExclusiveTo(typeof (GeoboundingBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeoboundingBoxStatics
  {
    [Overload("TryCompute")]
    GeoboundingBox TryCompute(IIterable<BasicGeoposition> positions);

    [Overload("TryComputeWithAltitudeReference")]
    GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem);

    [Overload("TryComputeWithAltitudeReferenceAndSpatialReference")]
    GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem,
      uint spatialReferenceId);
  }
}
