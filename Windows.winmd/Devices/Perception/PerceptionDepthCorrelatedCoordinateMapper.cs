// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthCorrelatedCoordinateMapper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class PerceptionDepthCorrelatedCoordinateMapper : 
    IPerceptionDepthCorrelatedCoordinateMapper
  {
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Point MapPixelToTarget(
      Point sourcePixelCoordinate,
      PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void MapPixelsToTarget(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] results);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction MapRegionOfPixelsToTargetAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction MapAllPixelsToTargetAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);
  }
}
