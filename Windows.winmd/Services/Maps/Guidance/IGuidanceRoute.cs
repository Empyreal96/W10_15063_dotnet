// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceRoute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ExclusiveTo(typeof (GuidanceRoute))]
  [Guid(974410845, 32794, 16573, 162, 134, 175, 178, 1, 12, 206, 108)]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [WebHostHidden]
  internal interface IGuidanceRoute
  {
    TimeSpan Duration { get; }

    int Distance { get; }

    IVectorView<GuidanceManeuver> Maneuvers { get; }

    GeoboundingBox BoundingBox { get; }

    Geopath Path { get; }

    IVectorView<GuidanceRoadSegment> RoadSegments { get; }

    MapRoute ConvertToMapRoute();
  }
}
