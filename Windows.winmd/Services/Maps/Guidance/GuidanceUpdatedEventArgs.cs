// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class GuidanceUpdatedEventArgs : IGuidanceUpdatedEventArgs
  {
    public extern GuidanceMode Mode { [MethodImpl] get; }

    public extern GuidanceManeuver NextManeuver { [MethodImpl] get; }

    public extern int NextManeuverDistance { [MethodImpl] get; }

    public extern GuidanceManeuver AfterNextManeuver { [MethodImpl] get; }

    public extern int AfterNextManeuverDistance { [MethodImpl] get; }

    public extern int DistanceToDestination { [MethodImpl] get; }

    public extern int ElapsedDistance { [MethodImpl] get; }

    public extern TimeSpan ElapsedTime { [MethodImpl] get; }

    public extern TimeSpan TimeToDestination { [MethodImpl] get; }

    public extern string RoadName { [MethodImpl] get; }

    public extern GuidanceRoute Route { [MethodImpl] get; }

    public extern GuidanceMapMatchedCoordinate CurrentLocation { [MethodImpl] get; }

    public extern bool IsNewManeuver { [MethodImpl] get; }

    public extern IVectorView<GuidanceLaneInfo> LaneInfo { [MethodImpl] get; }
  }
}
