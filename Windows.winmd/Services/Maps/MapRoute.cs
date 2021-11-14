// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRoute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class MapRoute : IMapRoute, IMapRoute2, IMapRoute3
  {
    public extern GeoboundingBox BoundingBox { [MethodImpl] get; }

    public extern double LengthInMeters { [MethodImpl] get; }

    public extern TimeSpan EstimatedDuration { [MethodImpl] get; }

    public extern Geopath Path { [MethodImpl] get; }

    public extern IVectorView<MapRouteLeg> Legs { [MethodImpl] get; }

    public extern bool IsTrafficBased { [MethodImpl] get; }

    public extern MapRouteRestrictions ViolatedRestrictions { [MethodImpl] get; }

    public extern bool HasBlockedRoads { [MethodImpl] get; }

    public extern TimeSpan DurationWithoutTraffic { [MethodImpl] get; }

    public extern TrafficCongestion TrafficCongestion { [MethodImpl] get; }
  }
}
