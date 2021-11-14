// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteLeg
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapRouteLeg))]
  [Guid(2532881142, 23482, 19735, 157, 182, 26, 38, 63, 236, 116, 113)]
  [WebHostHidden]
  internal interface IMapRouteLeg
  {
    GeoboundingBox BoundingBox { get; }

    Geopath Path { get; }

    double LengthInMeters { get; }

    TimeSpan EstimatedDuration { get; }

    IVectorView<MapRouteManeuver> Maneuvers { get; }
  }
}
