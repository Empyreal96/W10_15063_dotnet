// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteManeuver
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRouteManeuver))]
  [Guid(3982235632, 42667, 19813, 160, 134, 250, 138, 126, 52, 13, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteManeuver
  {
    Geopoint StartingPoint { get; }

    double LengthInMeters { get; }

    string InstructionText { get; }

    MapRouteManeuverKind Kind { get; }

    string ExitNumber { get; }

    MapManeuverNotices ManeuverNotices { get; }
  }
}
