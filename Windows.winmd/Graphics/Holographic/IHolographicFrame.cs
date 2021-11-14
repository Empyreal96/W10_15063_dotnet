// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (HolographicFrame))]
  [Guid(3331886774, 43193, 12372, 166, 235, 214, 36, 182, 83, 99, 117)]
  internal interface IHolographicFrame
  {
    IVectorView<HolographicCamera> AddedCameras { get; }

    IVectorView<HolographicCamera> RemovedCameras { get; }

    HolographicCameraRenderingParameters GetRenderingParameters(
      HolographicCameraPose cameraPose);

    TimeSpan Duration { get; }

    HolographicFramePrediction CurrentPrediction { get; }

    void UpdateCurrentPrediction();

    [Overload("PresentUsingCurrentPrediction")]
    HolographicFramePresentResult PresentUsingCurrentPrediction();

    [Overload("PresentUsingCurrentPredictionWithBehavior")]
    HolographicFramePresentResult PresentUsingCurrentPrediction(
      HolographicFramePresentWaitBehavior waitBehavior);

    void WaitForFrameToFinish();
  }
}
