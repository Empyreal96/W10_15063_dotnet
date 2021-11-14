// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthCorrelatedCameraIntrinsics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception
{
  [ExclusiveTo(typeof (PerceptionDepthCorrelatedCameraIntrinsics))]
  [Guid(1699269121, 34526, 23521, 101, 130, 128, 127, 207, 76, 149, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionDepthCorrelatedCameraIntrinsics
  {
    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Vector3 UnprojectPixelAtCorrelatedDepth(
      Point pixelCoordinate,
      PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnprojectPixelsAtCorrelatedDepth(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UnprojectRegionPixelsAtCorrelatedDepthAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UnprojectAllPixelsAtCorrelatedDepthAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);
  }
}
