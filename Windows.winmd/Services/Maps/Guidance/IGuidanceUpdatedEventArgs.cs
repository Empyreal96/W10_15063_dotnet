// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Guid(4255913483, 40589, 19939, 169, 250, 176, 99, 33, 209, 141, 185)]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [ExclusiveTo(typeof (GuidanceUpdatedEventArgs))]
  [WebHostHidden]
  internal interface IGuidanceUpdatedEventArgs
  {
    GuidanceMode Mode { get; }

    GuidanceManeuver NextManeuver { get; }

    int NextManeuverDistance { get; }

    GuidanceManeuver AfterNextManeuver { get; }

    int AfterNextManeuverDistance { get; }

    int DistanceToDestination { get; }

    int ElapsedDistance { get; }

    TimeSpan ElapsedTime { get; }

    TimeSpan TimeToDestination { get; }

    string RoadName { get; }

    GuidanceRoute Route { get; }

    GuidanceMapMatchedCoordinate CurrentLocation { get; }

    bool IsNewManeuver { get; }

    IVectorView<GuidanceLaneInfo> LaneInfo { get; }
  }
}
