// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceMonitorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ExclusiveTo(typeof (GeofenceMonitor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(768815055, 32373, 18585, 172, 227, 43, 208, 166, 92, 206, 6)]
  internal interface IGeofenceMonitorStatics
  {
    GeofenceMonitor Current { get; }
  }
}
