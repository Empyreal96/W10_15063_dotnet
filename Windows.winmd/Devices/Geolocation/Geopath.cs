// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geopath
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IGeopathFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Geopath : IGeopath, IGeoshape
  {
    [MethodImpl]
    public extern Geopath(IIterable<BasicGeoposition> positions);

    [MethodImpl]
    public extern Geopath(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem);

    [MethodImpl]
    public extern Geopath(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    public extern IVectorView<BasicGeoposition> Positions { [MethodImpl] get; }

    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    public extern uint SpatialReferenceId { [MethodImpl] get; }

    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }
  }
}
