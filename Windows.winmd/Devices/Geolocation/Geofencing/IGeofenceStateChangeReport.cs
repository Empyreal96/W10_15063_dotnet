// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceStateChangeReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2586065944, 9316, 19593, 190, 5, 179, 255, 255, 91, 171, 197)]
  [ExclusiveTo(typeof (GeofenceStateChangeReport))]
  internal interface IGeofenceStateChangeReport
  {
    GeofenceState NewState { get; }

    Geofence Geofence { get; }

    Geoposition Geoposition { get; }

    GeofenceRemovalReason RemovalReason { get; }
  }
}
