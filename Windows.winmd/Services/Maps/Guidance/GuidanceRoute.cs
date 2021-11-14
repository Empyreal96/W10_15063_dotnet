// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceRoute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [Static(typeof (IGuidanceRouteStatics), 65536, "Windows.Services.Maps.GuidanceContract")]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GuidanceRoute : IGuidanceRoute
  {
    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern int Distance { [MethodImpl] get; }

    public extern IVectorView<GuidanceManeuver> Maneuvers { [MethodImpl] get; }

    public extern GeoboundingBox BoundingBox { [MethodImpl] get; }

    public extern Geopath Path { [MethodImpl] get; }

    public extern IVectorView<GuidanceRoadSegment> RoadSegments { [MethodImpl] get; }

    [MethodImpl]
    public extern MapRoute ConvertToMapRoute();

    [MethodImpl]
    public static extern bool CanCreateFromMapRoute(MapRoute mapRoute);

    [MethodImpl]
    public static extern GuidanceRoute TryCreateFromMapRoute(MapRoute mapRoute);
  }
}
