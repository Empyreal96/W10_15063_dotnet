// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geopoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IGeopointFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Geopoint : IGeopoint, IGeoshape
  {
    [MethodImpl]
    public extern Geopoint(BasicGeoposition position);

    [MethodImpl]
    public extern Geopoint(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem);

    [MethodImpl]
    public extern Geopoint(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    public extern BasicGeoposition Position { [MethodImpl] get; }

    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    public extern uint SpatialReferenceId { [MethodImpl] get; }

    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }
  }
}
