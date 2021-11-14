// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapReverseCallbacksThunk
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Device.Location;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Maps.Controls
{
  internal static class MapReverseCallbacksThunk
  {
    public static readonly InstanceRegistry<IMapModel> MapInstanceRegistry = new InstanceRegistry<IMapModel>();
    public static readonly MapReverseCallbackDelegates.InvokeProcessDispatchQueueCallback InvokeProcessDispatchQueueEventHandler = new MapReverseCallbackDelegates.InvokeProcessDispatchQueueCallback(MapReverseCallbacksThunk.InvokeProcessDispatchQueue);
    public static readonly MapReverseCallbackDelegates.CenterChangedCallback MapCenterChangedEventHandler = new MapReverseCallbackDelegates.CenterChangedCallback(MapReverseCallbacksThunk.OnCenterChanged);
    public static readonly MapReverseCallbackDelegates.TransformCenterChangedCallback MapTransformCenterChangedEventHandler = new MapReverseCallbackDelegates.TransformCenterChangedCallback(MapReverseCallbacksThunk.OnTransformCenterChanged);
    public static readonly MapReverseCallbackDelegates.ZoomLevelChangedCallback MapZoomLevelChangedEventHandler = new MapReverseCallbackDelegates.ZoomLevelChangedCallback(MapReverseCallbacksThunk.OnZoomLevelChanged);
    public static readonly MapReverseCallbackDelegates.HeadingChangedCallback MapHeadingChangedEventHandler = new MapReverseCallbackDelegates.HeadingChangedCallback(MapReverseCallbacksThunk.OnHeadingChanged);
    public static readonly MapReverseCallbackDelegates.PitchChangedCallback MapPitchChangedEventHandler = new MapReverseCallbackDelegates.PitchChangedCallback(MapReverseCallbacksThunk.OnPitchChanged);
    public static readonly MapReverseCallbackDelegates.ActualPitchChangedCallback MapActualPitchChangedEventHandler = new MapReverseCallbackDelegates.ActualPitchChangedCallback(MapReverseCallbacksThunk.OnActualPitchChanged);
    public static readonly MapReverseCallbackDelegates.CartographicModeChangedCallback MapModeChangedEventHandler = new MapReverseCallbackDelegates.CartographicModeChangedCallback(MapReverseCallbacksThunk.OnCartographicModeChanged);
    public static readonly MapReverseCallbackDelegates.ColorModeChangedCallback MapColorModeChangedEventHandler = new MapReverseCallbackDelegates.ColorModeChangedCallback(MapReverseCallbacksThunk.OnColorModeChanged);
    public static readonly MapReverseCallbackDelegates.LandmarksEnabledChangedCallback MapLandmarksEnabledChangedEventHandler = new MapReverseCallbackDelegates.LandmarksEnabledChangedCallback(MapReverseCallbacksThunk.OnLandmarksEnabledChanged);
    public static readonly MapReverseCallbackDelegates.PedestrianFeaturesEnabledChangedCallback MapPedestrianFeaturesEnabledChangedEventHandler = new MapReverseCallbackDelegates.PedestrianFeaturesEnabledChangedCallback(MapReverseCallbacksThunk.OnPedestrianFeaturesEnabledChanged);
    public static readonly MapReverseCallbackDelegates.ViewChangingCallback MapViewChangingEventHandler = new MapReverseCallbackDelegates.ViewChangingCallback(MapReverseCallbacksThunk.OnViewChanging);
    public static readonly MapReverseCallbackDelegates.ViewChangedCallback MapViewChangedEventHandler = new MapReverseCallbackDelegates.ViewChangedCallback(MapReverseCallbacksThunk.OnViewChanged);
    public static readonly MapReverseCallbackDelegates.ResolveCompletedCallback MapResolvedEventHandler = new MapReverseCallbackDelegates.ResolveCompletedCallback(MapReverseCallbacksThunk.OnResolveCompleted);
    public static readonly MapReverseCallbackDelegates.TapCallback TapEventHandler = new MapReverseCallbackDelegates.TapCallback(MapReverseCallbacksThunk.OnTap);
    public static readonly MapReverseCallbackDelegates.DoubleTapCallback DoubleTapEventHandler = new MapReverseCallbackDelegates.DoubleTapCallback(MapReverseCallbacksThunk.OnDoubleTap);
    public static readonly MapReverseCallbackDelegates.TapAndHoldCallback TapAndHoldEventHandler = new MapReverseCallbackDelegates.TapAndHoldCallback(MapReverseCallbacksThunk.OnTapAndHold);
    public static readonly MapReverseCallbackDelegates.PanCallback PanEventHandler = new MapReverseCallbackDelegates.PanCallback(MapReverseCallbacksThunk.OnPan);
    public static readonly MapReverseCallbackDelegates.PinchStretchCallback PinchStretchEventHandler = new MapReverseCallbackDelegates.PinchStretchCallback(MapReverseCallbacksThunk.OnPinchStretch);
    public static readonly MapReverseCallbackDelegates.FlickCallback FlickEventHandler = new MapReverseCallbackDelegates.FlickCallback(MapReverseCallbacksThunk.OnFlick);
    public static readonly MapReverseCallbackDelegates.SnapshotCreatedCallback SnapshotCreatedEventHandler = new MapReverseCallbackDelegates.SnapshotCreatedCallback(MapReverseCallbacksThunk.OnSnapshotCreated);

    [AllowReversePInvokeCalls]
    public static void OnTap(int mapModelId, int pointX, int pointY)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.TapEventHandler == null)
        return;
      mapModel.MapCallbacks.TapEventHandler(new Point((double) pointX, (double) pointY));
    }

    [AllowReversePInvokeCalls]
    public static void OnDoubleTap(int mapModelId, int pointX, int pointY)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.DoubleTapEventHandler == null)
        return;
      mapModel.MapCallbacks.DoubleTapEventHandler(new Point((double) pointX, (double) pointY));
    }

    [AllowReversePInvokeCalls]
    public static void OnTapAndHold(int mapModelId, int pointX, int pointY)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.TapAndHoldEventHandler == null)
        return;
      mapModel.MapCallbacks.TapAndHoldEventHandler(new Point((double) pointX, (double) pointY));
    }

    [AllowReversePInvokeCalls]
    public static void OnPan(int mapModelId, int fromX, int fromY, int toX, int toY)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.PanEventHandler == null)
        return;
      mapModel.MapCallbacks.PanEventHandler(new Point((double) fromX, (double) fromY), new Point((double) toX, (double) toY));
    }

    [AllowReversePInvokeCalls]
    public static void OnPinchStretch(int mapModelId, int centerX, int centerY, float scale)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.PinchStretchEventHandler == null)
        return;
      mapModel.MapCallbacks.PinchStretchEventHandler(new Point((double) centerX, (double) centerY), scale);
    }

    [AllowReversePInvokeCalls]
    public static void OnFlick(int mapModelId, int horizontalVelocity, int verticalVelocity)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.FlickEventHandler == null)
        return;
      mapModel.MapCallbacks.FlickEventHandler(new Point((double) horizontalVelocity, (double) verticalVelocity));
    }

    [AllowReversePInvokeCalls]
    public static void OnSnapshotCreated(
      int mapModelId,
      int hr,
      int width,
      int height,
      int stride,
      IntPtr data)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null)
        return;
      MapCallbackDelegates.SnapshotCreated createdEventHandler = mapModel.MapCallbacks.SnapshotCreatedEventHandler;
      if (createdEventHandler == null)
        return;
      if (hr >= 0 && data != IntPtr.Zero)
      {
        WriteableBitmap bitmap = new WriteableBitmap(width, height);
        for (int index = 0; index < height; ++index)
          Marshal.Copy(IntPtr.op_Addition(data, index * stride), bitmap.Pixels, index * width, width);
        createdEventHandler((Exception) null, bitmap);
      }
      else
      {
        Exception exceptionForHr = Marshal.GetExceptionForHR(hr);
        createdEventHandler(exceptionForHr, (WriteableBitmap) null);
      }
    }

    private static IMapModel GetMapModel(int mapModelId) => MapReverseCallbacksThunk.MapInstanceRegistry.FindInstance(mapModelId);

    [AllowReversePInvokeCalls]
    private static void InvokeProcessDispatchQueue(int mapModelId) => MapReverseCallbacksThunk.GetMapModel(mapModelId)?.InvokeProcessDispatchQueue();

    [AllowReversePInvokeCalls]
    private static void OnCenterChanged(int mapModelId, double latitude, double longitude)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.CenterChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.CenterChangedEventHandler(new GeoCoordinate(latitude, longitude));
    }

    [AllowReversePInvokeCalls]
    private static void OnTransformCenterChanged(int mapModelId, double x, double y)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.TransformCenterChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.TransformCenterChangedEventHandler(new Point(x, y));
    }

    [AllowReversePInvokeCalls]
    private static void OnZoomLevelChanged(int mapModelId, float zoomLevel)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.ZoomLevelChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.ZoomLevelChangedEventHandler((double) zoomLevel);
    }

    [AllowReversePInvokeCalls]
    private static void OnHeadingChanged(int mapModelId, float heading)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.HeadingChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.HeadingChangedEventHandler((double) heading);
    }

    [AllowReversePInvokeCalls]
    private static void OnPitchChanged(int mapModelId, float pitch)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.PitchChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.PitchChangedEventHandler((double) pitch);
    }

    [AllowReversePInvokeCalls]
    private static void OnActualPitchChanged(int mapModelId, float pitch)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.ActualPitchChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.ActualPitchChangedEventHandler((double) pitch);
    }

    [AllowReversePInvokeCalls]
    private static void OnCartographicModeChanged(int mapModelId, int mode)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.CartographicModeChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.CartographicModeChangedEventHandler((MapCartographicMode) mode);
    }

    [AllowReversePInvokeCalls]
    private static void OnColorModeChanged(int mapModelId, int mode)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.ColorModeChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.ColorModeChangedEventHandler((MapColorMode) mode);
    }

    [AllowReversePInvokeCalls]
    private static void OnLandmarksEnabledChanged(int mapModelId, bool visible)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.LandmarksEnabledChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.LandmarksEnabledChangedEventHandler(visible);
    }

    [AllowReversePInvokeCalls]
    private static void OnPedestrianFeaturesEnabledChanged(int mapModelId, bool visible)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.PedestrianFeaturesEnabledChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.PedestrianFeaturesEnabledChangedEventHandler(visible);
    }

    [AllowReversePInvokeCalls]
    private static void OnViewChanging(int mapModelId)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.ViewChangingEventHandler == null)
        return;
      mapModel.MapCallbacks.ViewChangingEventHandler();
    }

    [AllowReversePInvokeCalls]
    private static void OnViewChanged(int mapModelId, bool canceled)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.ViewChangedEventHandler == null)
        return;
      mapModel.MapCallbacks.ViewChangedEventHandler(canceled);
    }

    [AllowReversePInvokeCalls]
    private static void OnResolveCompleted(int mapModelId)
    {
      IMapModel mapModel = MapReverseCallbacksThunk.GetMapModel(mapModelId);
      if (mapModel == null || mapModel.MapCallbacks.ResolveCompletedEventHandler == null)
        return;
      mapModel.MapCallbacks.ResolveCompletedEventHandler();
    }
  }
}
