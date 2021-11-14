// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofence
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [Guid(2617837603, 60856, 18400, 130, 69, 91, 246, 29, 50, 31, 45)]
  [ExclusiveTo(typeof (Geofence))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeofence
  {
    DateTime StartTime { get; }

    TimeSpan Duration { get; }

    TimeSpan DwellTime { get; }

    string Id { get; }

    MonitoredGeofenceStates MonitoredStates { get; }

    IGeoshape Geoshape { get; }

    bool SingleUse { get; }
  }
}
