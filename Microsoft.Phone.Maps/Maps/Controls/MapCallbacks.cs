// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapCallbacks
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapCallbacks
  {
    public MapCallbackDelegates.CenterChanged CenterChangedEventHandler { get; set; }

    public MapCallbackDelegates.TransformCenterChanged TransformCenterChangedEventHandler { get; set; }

    public MapCallbackDelegates.ZoomLevelChanged ZoomLevelChangedEventHandler { get; set; }

    public MapCallbackDelegates.HeadingChanged HeadingChangedEventHandler { get; set; }

    public MapCallbackDelegates.PitchChanged PitchChangedEventHandler { get; set; }

    public MapCallbackDelegates.ActualPitchChanged ActualPitchChangedEventHandler { get; set; }

    public MapCallbackDelegates.CartographicModeChanged CartographicModeChangedEventHandler { get; set; }

    public MapCallbackDelegates.ColorModeChanged ColorModeChangedEventHandler { get; set; }

    public MapCallbackDelegates.LandmarksEnabledChanged LandmarksEnabledChangedEventHandler { get; set; }

    public MapCallbackDelegates.PedestrianFeaturesEnabledChanged PedestrianFeaturesEnabledChangedEventHandler { get; set; }

    public MapCallbackDelegates.ViewChanging ViewChangingEventHandler { get; set; }

    public MapCallbackDelegates.ViewChanged ViewChangedEventHandler { get; set; }

    public MapCallbackDelegates.ResolveCompleted ResolveCompletedEventHandler { get; set; }

    public MapCallbackDelegates.Tap TapEventHandler { get; set; }

    public MapCallbackDelegates.DoubleTap DoubleTapEventHandler { get; set; }

    public MapCallbackDelegates.TapAndHold TapAndHoldEventHandler { get; set; }

    public MapCallbackDelegates.Pan PanEventHandler { get; set; }

    public MapCallbackDelegates.PinchStretch PinchStretchEventHandler { get; set; }

    public MapCallbackDelegates.Flick FlickEventHandler { get; set; }

    public MapCallbackDelegates.SnapshotCreated SnapshotCreatedEventHandler { get; set; }
  }
}
