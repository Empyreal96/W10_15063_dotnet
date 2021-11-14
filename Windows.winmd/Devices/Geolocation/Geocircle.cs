// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geocircle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IGeocircleFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class Geocircle : IGeocircle, IGeoshape
  {
    [MethodImpl]
    public extern Geocircle(BasicGeoposition position, double radius);

    [MethodImpl]
    public extern Geocircle(
      BasicGeoposition position,
      double radius,
      AltitudeReferenceSystem altitudeReferenceSystem);

    [MethodImpl]
    public extern Geocircle(
      BasicGeoposition position,
      double radius,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    public extern BasicGeoposition Center { [MethodImpl] get; }

    public extern double Radius { [MethodImpl] get; }

    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    public extern uint SpatialReferenceId { [MethodImpl] get; }

    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }
  }
}
