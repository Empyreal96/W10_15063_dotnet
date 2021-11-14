// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerPoseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(2723516841, 44193, 16096, 152, 22, 120, 92, 251, 46, 63, 184)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialPointerPose))]
  internal interface ISpatialPointerPoseStatics
  {
    SpatialPointerPose TryGetAtTimestamp(
      SpatialCoordinateSystem coordinateSystem,
      PerceptionTimestamp timestamp);
  }
}
