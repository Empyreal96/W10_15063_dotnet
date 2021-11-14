// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceMonitor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1276075896, 7199, 17953, 187, 189, 131, 59, 146, 36, 114, 38)]
  [ExclusiveTo(typeof (GeofenceMonitor))]
  internal interface IGeofenceMonitor
  {
    GeofenceMonitorStatus Status { get; }

    IVector<Geofence> Geofences { get; }

    Geoposition LastKnownGeoposition { get; }

    event TypedEventHandler<GeofenceMonitor, object> GeofenceStateChanged;

    IVectorView<GeofenceStateChangeReport> ReadReports();

    event TypedEventHandler<GeofenceMonitor, object> StatusChanged;
  }
}
