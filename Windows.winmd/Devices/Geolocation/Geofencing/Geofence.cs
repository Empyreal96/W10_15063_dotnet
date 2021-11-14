// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.Geofence
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IGeofenceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Geofence : IGeofence
  {
    [MethodImpl]
    public extern Geofence(string id, IGeoshape geoshape);

    [MethodImpl]
    public extern Geofence(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse);

    [MethodImpl]
    public extern Geofence(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime);

    [MethodImpl]
    public extern Geofence(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime,
      DateTime startTime,
      TimeSpan duration);

    public extern DateTime StartTime { [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern TimeSpan DwellTime { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern MonitoredGeofenceStates MonitoredStates { [MethodImpl] get; }

    public extern IGeoshape Geoshape { [MethodImpl] get; }

    public extern bool SingleUse { [MethodImpl] get; }
  }
}
