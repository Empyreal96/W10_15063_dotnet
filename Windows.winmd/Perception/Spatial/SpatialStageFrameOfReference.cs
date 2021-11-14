// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialStageFrameOfReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialStageFrameOfReferenceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpatialStageFrameOfReference : ISpatialStageFrameOfReference
  {
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    public extern SpatialMovementRange MovementRange { [MethodImpl] get; }

    public extern SpatialLookDirectionRange LookDirectionRange { [MethodImpl] get; }

    [MethodImpl]
    public extern SpatialCoordinateSystem GetCoordinateSystemAtCurrentLocation(
      SpatialLocator locator);

    [MethodImpl]
    public extern Vector3[] TryGetMovementBounds(SpatialCoordinateSystem coordinateSystem);

    public static extern SpatialStageFrameOfReference Current { [MethodImpl] get; }

    public static extern event EventHandler<object> CurrentChanged;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialStageFrameOfReference> RequestNewStageAsync();
  }
}
