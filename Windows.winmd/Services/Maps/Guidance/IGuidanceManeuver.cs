// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceManeuver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GuidanceManeuver))]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [Guid(4228461164, 60617, 18728, 162, 161, 114, 50, 185, 155, 148, 161)]
  internal interface IGuidanceManeuver
  {
    Geopoint StartLocation { get; }

    int DistanceFromRouteStart { get; }

    int DistanceFromPreviousManeuver { get; }

    string DepartureRoadName { get; }

    string NextRoadName { get; }

    string DepartureShortRoadName { get; }

    string NextShortRoadName { get; }

    GuidanceManeuverKind Kind { get; }

    int StartAngle { get; }

    int EndAngle { get; }

    GuidanceRoadSignpost RoadSignpost { get; }

    string InstructionText { get; }
  }
}
