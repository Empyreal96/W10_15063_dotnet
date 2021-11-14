// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.GeofenceMonitor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGeofenceMonitorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class GeofenceMonitor : IGeofenceMonitor
  {
    public extern GeofenceMonitorStatus Status { [MethodImpl] get; }

    public extern IVector<Geofence> Geofences { [MethodImpl] get; }

    public extern Geoposition LastKnownGeoposition { [MethodImpl] get; }

    public extern event TypedEventHandler<GeofenceMonitor, object> GeofenceStateChanged;

    [MethodImpl]
    public extern IVectorView<GeofenceStateChangeReport> ReadReports();

    public extern event TypedEventHandler<GeofenceMonitor, object> StatusChanged;

    public static extern GeofenceMonitor Current { [MethodImpl] get; }
  }
}
