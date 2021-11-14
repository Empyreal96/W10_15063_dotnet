// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceRoadSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  public sealed class GuidanceRoadSegment : IGuidanceRoadSegment
  {
    public extern string RoadName { [MethodImpl] get; }

    public extern string ShortRoadName { [MethodImpl] get; }

    public extern double SpeedLimit { [MethodImpl] get; }

    public extern TimeSpan TravelTime { [MethodImpl] get; }

    public extern Geopath Path { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern bool IsHighway { [MethodImpl] get; }

    public extern bool IsTunnel { [MethodImpl] get; }

    public extern bool IsTollRoad { [MethodImpl] get; }
  }
}
