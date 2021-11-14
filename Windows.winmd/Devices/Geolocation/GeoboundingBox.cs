// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeoboundingBox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGeoboundingBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IGeoboundingBoxFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class GeoboundingBox : IGeoboundingBox, IGeoshape
  {
    [MethodImpl]
    public extern GeoboundingBox(BasicGeoposition northwestCorner, BasicGeoposition southeastCorner);

    [MethodImpl]
    public extern GeoboundingBox(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem);

    [MethodImpl]
    public extern GeoboundingBox(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    public extern BasicGeoposition NorthwestCorner { [MethodImpl] get; }

    public extern BasicGeoposition SoutheastCorner { [MethodImpl] get; }

    public extern BasicGeoposition Center { [MethodImpl] get; }

    public extern double MinAltitude { [MethodImpl] get; }

    public extern double MaxAltitude { [MethodImpl] get; }

    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    public extern uint SpatialReferenceId { [MethodImpl] get; }

    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }

    [Overload("TryCompute")]
    [MethodImpl]
    public static extern GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions);

    [Overload("TryComputeWithAltitudeReference")]
    [MethodImpl]
    public static extern GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem);

    [Overload("TryComputeWithAltitudeReferenceAndSpatialReference")]
    [MethodImpl]
    public static extern GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem,
      uint spatialReferenceId);
  }
}
