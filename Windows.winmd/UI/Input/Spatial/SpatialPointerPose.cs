// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialPointerPose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.People;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISpatialPointerPoseStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialPointerPose : ISpatialPointerPose, ISpatialPointerPose2
  {
    public extern PerceptionTimestamp Timestamp { [MethodImpl] get; }

    public extern HeadPose Head { [MethodImpl] get; }

    [MethodImpl]
    public extern SpatialPointerInteractionSourcePose TryGetInteractionSourcePose(
      SpatialInteractionSource source);

    [MethodImpl]
    public static extern SpatialPointerPose TryGetAtTimestamp(
      SpatialCoordinateSystem coordinateSystem,
      PerceptionTimestamp timestamp);
  }
}
