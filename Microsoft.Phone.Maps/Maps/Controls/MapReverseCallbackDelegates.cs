// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapReverseCallbackDelegates
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class MapReverseCallbackDelegates
  {
    public delegate void InvokeProcessDispatchQueueCallback(int mapModelId);

    public delegate void CenterChangedCallback(int mapModelId, double latitude, double longitude);

    public delegate void TransformCenterChangedCallback(int mapModelId, double x, double y);

    public delegate void ZoomLevelChangedCallback(int mapModelId, float zoomLevel);

    public delegate void HeadingChangedCallback(int mapModelId, float heading);

    public delegate void PitchChangedCallback(int mapModelId, float pitch);

    public delegate void ActualPitchChangedCallback(int mapModelId, float pitch);

    public delegate void CartographicModeChangedCallback(int mapModelId, int mode);

    public delegate void ColorModeChangedCallback(int mapModelId, int mode);

    public delegate void LandmarksEnabledChangedCallback(int mapModelId, bool visible);

    public delegate void PedestrianFeaturesEnabledChangedCallback(int mapModelId, bool visible);

    public delegate void ViewChangingCallback(int mapModelId);

    public delegate void ViewChangedCallback(int mapModelId, bool canceled);

    public delegate void ResolveCompletedCallback(int mapModelId);

    public delegate void TapCallback(int mapModelId, int pointX, int pointY);

    public delegate void DoubleTapCallback(int mapModelId, int pointX, int pointY);

    public delegate void TapAndHoldCallback(int mapModelId, int pointX, int pointY);

    public delegate void PanCallback(int mapModelId, int fromX, int fromY, int toX, int toY);

    public delegate void PinchStretchCallback(
      int mapModelId,
      int centerX,
      int centerY,
      float scale);

    public delegate void FlickCallback(
      int mapModelId,
      int horizontalVelocity,
      int verticalVelocity);

    public delegate void SnapshotCreatedCallback(
      int mapModelId,
      int hr,
      int width,
      int height,
      int stride,
      IntPtr data);
  }
}
