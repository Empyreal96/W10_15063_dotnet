// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceManeuver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GuidanceManeuver : IGuidanceManeuver
  {
    public extern Geopoint StartLocation { [MethodImpl] get; }

    public extern int DistanceFromRouteStart { [MethodImpl] get; }

    public extern int DistanceFromPreviousManeuver { [MethodImpl] get; }

    public extern string DepartureRoadName { [MethodImpl] get; }

    public extern string NextRoadName { [MethodImpl] get; }

    public extern string DepartureShortRoadName { [MethodImpl] get; }

    public extern string NextShortRoadName { [MethodImpl] get; }

    public extern GuidanceManeuverKind Kind { [MethodImpl] get; }

    public extern int StartAngle { [MethodImpl] get; }

    public extern int EndAngle { [MethodImpl] get; }

    public extern GuidanceRoadSignpost RoadSignpost { [MethodImpl] get; }

    public extern string InstructionText { [MethodImpl] get; }
  }
}
