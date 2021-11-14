// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionDepthCorrelatedCameraIntrinsics : 
    IPerceptionDepthCorrelatedCameraIntrinsics
  {
    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Vector3 UnprojectPixelAtCorrelatedDepth(
      Point pixelCoordinate,
      PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void UnprojectPixelsAtCorrelatedDepth(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction UnprojectRegionPixelsAtCorrelatedDepthAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction UnprojectAllPixelsAtCorrelatedDepthAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);
  }
}
