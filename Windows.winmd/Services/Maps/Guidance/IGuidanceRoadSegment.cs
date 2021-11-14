// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceRoadSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [Guid(3005700262, 48760, 19555, 175, 231, 108, 41, 87, 71, 155, 62)]
  [ExclusiveTo(typeof (GuidanceRoadSegment))]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  internal interface IGuidanceRoadSegment
  {
    string RoadName { get; }

    string ShortRoadName { get; }

    double SpeedLimit { get; }

    TimeSpan TravelTime { get; }

    Geopath Path { get; }

    string Id { get; }

    bool IsHighway { get; }

    bool IsTunnel { get; }

    bool IsTollRoad { get; }
  }
}
