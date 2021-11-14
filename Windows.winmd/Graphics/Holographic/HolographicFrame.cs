// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicFrame : IHolographicFrame
  {
    public extern IVectorView<HolographicCamera> AddedCameras { [MethodImpl] get; }

    public extern IVectorView<HolographicCamera> RemovedCameras { [MethodImpl] get; }

    [MethodImpl]
    public extern HolographicCameraRenderingParameters GetRenderingParameters(
      HolographicCameraPose cameraPose);

    public extern TimeSpan Duration { [MethodImpl] get; }

    public extern HolographicFramePrediction CurrentPrediction { [MethodImpl] get; }

    [MethodImpl]
    public extern void UpdateCurrentPrediction();

    [Overload("PresentUsingCurrentPrediction")]
    [MethodImpl]
    public extern HolographicFramePresentResult PresentUsingCurrentPrediction();

    [Overload("PresentUsingCurrentPredictionWithBehavior")]
    [MethodImpl]
    public extern HolographicFramePresentResult PresentUsingCurrentPrediction(
      HolographicFramePresentWaitBehavior waitBehavior);

    [MethodImpl]
    public extern void WaitForFrameToFinish();
  }
}
