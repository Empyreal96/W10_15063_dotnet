// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport
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
  public sealed class GeofenceStateChangeReport : IGeofenceStateChangeReport
  {
    public extern GeofenceState NewState { [MethodImpl] get; }

    public extern Geofence Geofence { [MethodImpl] get; }

    public extern Geoposition Geoposition { [MethodImpl] get; }

    public extern GeofenceRemovalReason RemovalReason { [MethodImpl] get; }
  }
}
