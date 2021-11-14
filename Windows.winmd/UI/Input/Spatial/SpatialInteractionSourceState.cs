// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialInteractionSourceState : 
    ISpatialInteractionSourceState,
    ISpatialInteractionSourceState2
  {
    public extern SpatialInteractionSource Source { [MethodImpl] get; }

    public extern SpatialInteractionSourceProperties Properties { [MethodImpl] get; }

    public extern bool IsPressed { [MethodImpl] get; }

    public extern PerceptionTimestamp Timestamp { [MethodImpl] get; }

    [MethodImpl]
    public extern SpatialPointerPose TryGetPointerPose(
      SpatialCoordinateSystem coordinateSystem);

    public extern bool IsSelectPressed { [MethodImpl] get; }

    public extern bool IsMenuPressed { [MethodImpl] get; }

    public extern bool IsGrasped { [MethodImpl] get; }

    public extern double SelectPressedValue { [MethodImpl] get; }

    public extern SpatialInteractionControllerProperties ControllerProperties { [MethodImpl] get; }
  }
}
