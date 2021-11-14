// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.DepthMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  public sealed class DepthMediaFrame : IDepthMediaFrame, IDepthMediaFrame2
  {
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    public extern VideoMediaFrame VideoMediaFrame { [MethodImpl] get; }

    public extern DepthMediaFrameFormat DepthFormat { [MethodImpl] get; }

    [MethodImpl]
    public extern DepthCorrelatedCoordinateMapper TryCreateCoordinateMapper(
      CameraIntrinsics cameraIntrinsics,
      SpatialCoordinateSystem coordinateSystem);

    public extern uint MaxReliableDepth { [MethodImpl] get; }

    public extern uint MinReliableDepth { [MethodImpl] get; }
  }
}
