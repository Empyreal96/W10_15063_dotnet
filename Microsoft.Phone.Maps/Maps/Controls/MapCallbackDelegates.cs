// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapCallbackDelegates
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Device.Location;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class MapCallbackDelegates
  {
    public delegate void CenterChanged(GeoCoordinate center);

    public delegate void TransformCenterChanged(Point point);

    public delegate void ZoomLevelChanged(double zoomLevel);

    public delegate void HeadingChanged(double heading);

    public delegate void PitchChanged(double pitch);

    public delegate void ActualPitchChanged(double pitch);

    public delegate void CartographicModeChanged(MapCartographicMode mode);

    public delegate void ColorModeChanged(MapColorMode mode);

    public delegate void LandmarksEnabledChanged(bool visible);

    public delegate void PedestrianFeaturesEnabledChanged(bool visible);

    public delegate void ViewChanging();

    public delegate void ViewChanged(bool canceled);

    public delegate void ResolveCompleted();

    public delegate void Tap(Point point);

    public delegate void DoubleTap(Point point);

    public delegate void TapAndHold(Point point);

    public delegate void Pan(Point from, Point to);

    public delegate void PinchStretch(Point center, float scale);

    public delegate void Flick(Point velocity);

    public delegate void SnapshotCreated(Exception error, WriteableBitmap bitmap);
  }
}
