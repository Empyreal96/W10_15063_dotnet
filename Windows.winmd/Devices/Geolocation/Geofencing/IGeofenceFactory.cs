// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ExclusiveTo(typeof (Geofence))]
  [Guid(2216649291, 12895, 19344, 188, 167, 43, 128, 34, 169, 55, 150)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeofenceFactory
  {
    Geofence Create(string id, IGeoshape geoshape);

    Geofence CreateWithMonitorStates(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse);

    Geofence CreateWithMonitorStatesAndDwellTime(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime);

    Geofence CreateWithMonitorStatesDwellTimeStartTimeAndDuration(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime,
      DateTime startTime,
      TimeSpan duration);
  }
}
