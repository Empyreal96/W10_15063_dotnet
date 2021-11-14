// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IEnhancedWaypointFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (EnhancedWaypoint))]
  [Guid(2944828535, 41642, 18141, 182, 69, 35, 179, 27, 138, 166, 199)]
  internal interface IEnhancedWaypointFactory
  {
    EnhancedWaypoint Create(Geopoint point, WaypointKind kind);
  }
}
