// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialGestureRecognizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ISpatialGestureRecognizerFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialGestureRecognizer : ISpatialGestureRecognizer
  {
    [MethodImpl]
    public extern SpatialGestureRecognizer(SpatialGestureSettings settings);

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialRecognitionStartedEventArgs> RecognitionStarted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialRecognitionEndedEventArgs> RecognitionEnded;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialTappedEventArgs> Tapped;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldStartedEventArgs> HoldStarted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldCompletedEventArgs> HoldCompleted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldCanceledEventArgs> HoldCanceled;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationStartedEventArgs> ManipulationStarted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationUpdatedEventArgs> ManipulationUpdated;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationCompletedEventArgs> ManipulationCompleted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationCanceledEventArgs> ManipulationCanceled;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationStartedEventArgs> NavigationStarted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationUpdatedEventArgs> NavigationUpdated;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationCompletedEventArgs> NavigationCompleted;

    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationCanceledEventArgs> NavigationCanceled;

    [MethodImpl]
    public extern void CaptureInteraction(SpatialInteraction interaction);

    [MethodImpl]
    public extern void CancelPendingGestures();

    [MethodImpl]
    public extern bool TrySetGestureSettings(SpatialGestureSettings settings);

    public extern SpatialGestureSettings GestureSettings { [MethodImpl] get; }
  }
}
