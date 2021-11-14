// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthCorrelatedCoordinateMapper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ExclusiveTo(typeof (PerceptionDepthCorrelatedCoordinateMapper))]
  [Guid(1531813149, 46582, 18076, 184, 194, 185, 122, 69, 230, 134, 59)]
  [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionDepthCorrelatedCoordinateMapper
  {
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Point MapPixelToTarget(Point sourcePixelCoordinate, PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void MapPixelsToTarget(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] results);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction MapRegionOfPixelsToTargetAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction MapAllPixelsToTargetAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);
  }
}
