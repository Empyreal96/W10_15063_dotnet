// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialGestureRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialGestureRecognizer))]
  [Guid(1902140364, 3125, 18035, 173, 189, 204, 4, 202, 166, 239, 69)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialGestureRecognizer
  {
    event TypedEventHandler<SpatialGestureRecognizer, SpatialRecognitionStartedEventArgs> RecognitionStarted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialRecognitionEndedEventArgs> RecognitionEnded;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialTappedEventArgs> Tapped;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldStartedEventArgs> HoldStarted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldCompletedEventArgs> HoldCompleted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldCanceledEventArgs> HoldCanceled;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationStartedEventArgs> ManipulationStarted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationUpdatedEventArgs> ManipulationUpdated;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationCompletedEventArgs> ManipulationCompleted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationCanceledEventArgs> ManipulationCanceled;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationStartedEventArgs> NavigationStarted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationUpdatedEventArgs> NavigationUpdated;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationCompletedEventArgs> NavigationCompleted;

    event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationCanceledEventArgs> NavigationCanceled;

    void CaptureInteraction(SpatialInteraction interaction);

    void CancelPendingGestures();

    bool TrySetGestureSettings(SpatialGestureSettings settings);

    SpatialGestureSettings GestureSettings { get; }
  }
}
