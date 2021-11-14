// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteManeuver
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
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapRouteManeuver : IMapRouteManeuver, IMapRouteManeuver2, IMapRouteManeuver3
  {
    public extern Geopoint StartingPoint { [MethodImpl] get; }

    public extern double LengthInMeters { [MethodImpl] get; }

    public extern string InstructionText { [MethodImpl] get; }

    public extern MapRouteManeuverKind Kind { [MethodImpl] get; }

    public extern string ExitNumber { [MethodImpl] get; }

    public extern MapManeuverNotices ManeuverNotices { [MethodImpl] get; }

    public extern double StartHeading { [MethodImpl] get; }

    public extern double EndHeading { [MethodImpl] get; }

    public extern string StreetName { [MethodImpl] get; }

    public extern IVectorView<ManeuverWarning> Warnings { [MethodImpl] get; }
  }
}
