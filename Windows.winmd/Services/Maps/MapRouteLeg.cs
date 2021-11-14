// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteLeg
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapRouteLeg : IMapRouteLeg, IMapRouteLeg2
  {
    public extern GeoboundingBox BoundingBox { [MethodImpl] get; }

    public extern Geopath Path { [MethodImpl] get; }

    public extern double LengthInMeters { [MethodImpl] get; }

    public extern TimeSpan EstimatedDuration { [MethodImpl] get; }

    public extern IVectorView<MapRouteManeuver> Maneuvers { [MethodImpl] get; }

    public extern TimeSpan DurationWithoutTraffic { [MethodImpl] get; }

    public extern TrafficCongestion TrafficCongestion { [MethodImpl] get; }
  }
}
