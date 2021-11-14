// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(3586422255, 19299, 14316, 152, 185, 159, 198, 82, 185, 210, 242)]
  [ExclusiveTo(typeof (SpatialInteractionSourceState))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialInteractionSourceState
  {
    SpatialInteractionSource Source { get; }

    SpatialInteractionSourceProperties Properties { get; }

    bool IsPressed { get; }

    PerceptionTimestamp Timestamp { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);
  }
}
