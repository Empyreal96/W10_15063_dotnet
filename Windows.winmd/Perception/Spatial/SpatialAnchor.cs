// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Static(typeof (ISpatialAnchorStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialAnchor : ISpatialAnchor, ISpatialAnchor2
  {
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    public extern SpatialCoordinateSystem RawCoordinateSystem { [MethodImpl] get; }

    public extern event TypedEventHandler<SpatialAnchor, SpatialAnchorRawCoordinateSystemAdjustedEventArgs> RawCoordinateSystemAdjusted;

    public extern bool RemovedByUser { [MethodImpl] get; }

    [Overload("TryCreateRelativeTo")]
    [MethodImpl]
    public static extern SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem);

    [Overload("TryCreateWithPositionRelativeTo")]
    [MethodImpl]
    public static extern SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position);

    [Overload("TryCreateWithPositionAndOrientationRelativeTo")]
    [MethodImpl]
    public static extern SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Quaternion orientation);
  }
}
