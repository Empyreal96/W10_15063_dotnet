// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.AgMapControlManagedAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Device.Location;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  internal class AgMapControlManagedAdapter : IDisposable
  {
    private const int Success = 0;
    private static readonly Thickness zeroThickness = new Thickness(0.0, 0.0, 0.0, 0.0);
    private static bool reverseCallbacksInitialized;
    private bool disposed;
    private AgMapControlSafeHandle nativeAdapter;

    public AgMapControlManagedAdapter(int controlId)
    {
      this.nativeAdapter = Shim.AgMapControlAdapter_FindAdapter(controlId);
      if (this.nativeAdapter.IsInvalid)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.NativeMapAdapterException, (object) controlId));
    }

    ~AgMapControlManagedAdapter() => this.Dispose(false);

    public int Id => Shim.AgMapControlAdapter_GetControlId(this.nativeAdapter);

    public int ExternalInputId
    {
      set => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_SetExternalInputId(this.nativeAdapter, value));
    }

    public Size ViewPortSize
    {
      set => Shim.AgMapControlAdapter_SetViewportSize(this.nativeAdapter, checked ((int) value.Width), checked ((int) value.Height));
    }

    public GeoCoordinate Center
    {
      get
      {
        double latitude;
        double longitude;
        Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_GetCenter(this.nativeAdapter, out latitude, out longitude));
        return new GeoCoordinate(latitude, longitude);
      }
      set => Shim.AgMapControlAdapter_SetCenter(this.nativeAdapter, value.Latitude, value.Longitude);
    }

    public Point TransformCenter
    {
      get
      {
        double x;
        double y;
        Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_GetTransformCenter(this.nativeAdapter, out x, out y));
        return new Point(x, y);
      }
      set => Shim.AgMapControlAdapter_SetTransformCenter(this.nativeAdapter, value.X, value.Y);
    }

    public float ZoomLevel
    {
      get => Shim.AgMapControlAdapter_GetZoomLevel(this.nativeAdapter);
      set => Shim.AgMapControlAdapter_SetZoomLevel(this.nativeAdapter, value);
    }

    public float Heading
    {
      get => Shim.AgMapControlAdapter_GetHeading(this.nativeAdapter);
      set => Shim.AgMapControlAdapter_SetHeading(this.nativeAdapter, value);
    }

    public float Pitch
    {
      get
      {
        float tilt;
        Shim.AgMapControlAdapter_GetTilt(this.nativeAdapter, out tilt);
        return tilt;
      }
      set => Shim.AgMapControlAdapter_SetTilt(this.nativeAdapter, value);
    }

    public float ActualPitch
    {
      get
      {
        float tilt;
        Shim.AgMapControlAdapter_GetActualTilt(this.nativeAdapter, out tilt);
        return tilt;
      }
    }

    public MapCartographicMode CartographicMode
    {
      get
      {
        int mode;
        Shim.AgMapControlAdapter_GetMode(this.nativeAdapter, out mode);
        return Enum.IsDefined(typeof (MapCartographicMode), (object) mode) ? (MapCartographicMode) mode : throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.EnumMatchingExceptionFormat, (object) "MapCartographicMode"));
      }
      set => Shim.AgMapControlAdapter_SetMode(this.nativeAdapter, (int) value);
    }

    public MapColorMode ColorMode
    {
      get
      {
        int contrastMode;
        Shim.AgMapControlAdapter_GetContrastMode(this.nativeAdapter, out contrastMode);
        return Enum.IsDefined(typeof (MapColorMode), (object) contrastMode) ? (MapColorMode) contrastMode : throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.EnumMatchingExceptionFormat, (object) "MapColorMode"));
      }
      set => Shim.AgMapControlAdapter_SetContrastMode(this.nativeAdapter, (int) value);
    }

    public bool LandmarksEnabled
    {
      get => Shim.AgMapControlAdapter_GetLandmarksVisible(this.nativeAdapter);
      set => Shim.AgMapControlAdapter_SetLandmarksVisible(this.nativeAdapter, value);
    }

    public bool PedestrianFeaturesEnabled
    {
      get => Shim.AgMapControlAdapter_GetPedestrianFeaturesVisible(this.nativeAdapter);
      set => Shim.AgMapControlAdapter_SetPedestrianFeaturesVisible(this.nativeAdapter, value);
    }

    public bool WatermarkEnabled
    {
      get => Shim.AgMapControlAdapter_GetWatermarkVisible(this.nativeAdapter);
      set => Shim.AgMapControlAdapter_SetWatermarkVisible(this.nativeAdapter, value);
    }

    public static void SetReverseCallbacks(
      MapReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueCallback,
      MapReverseCallbackDelegates.CenterChangedCallback centerChangedCallback,
      MapReverseCallbackDelegates.TransformCenterChangedCallback transformCenterChangedCallback,
      MapReverseCallbackDelegates.ZoomLevelChangedCallback zoomLevelChangedCallback,
      MapReverseCallbackDelegates.HeadingChangedCallback headingChangedCallback,
      MapReverseCallbackDelegates.PitchChangedCallback pitchChangedCallback,
      MapReverseCallbackDelegates.ActualPitchChangedCallback actualPitchChangedCallback,
      MapReverseCallbackDelegates.CartographicModeChangedCallback modeChangedCallback,
      MapReverseCallbackDelegates.ColorModeChangedCallback colorModeChangedCallback,
      MapReverseCallbackDelegates.LandmarksEnabledChangedCallback landmarksEnabledChangedCallback,
      MapReverseCallbackDelegates.PedestrianFeaturesEnabledChangedCallback pedestrianFeaturesVisibleChangedCallback,
      MapReverseCallbackDelegates.ResolveCompletedCallback resolveCompletedCallback,
      MapReverseCallbackDelegates.ViewChangingCallback viewChangingCallback,
      MapReverseCallbackDelegates.ViewChangedCallback viewChangedCallback,
      MapReverseCallbackDelegates.TapCallback tapCallback,
      MapReverseCallbackDelegates.DoubleTapCallback doubleTapCallback,
      MapReverseCallbackDelegates.TapAndHoldCallback tapAndHoldCallback,
      MapReverseCallbackDelegates.PanCallback panCallback,
      MapReverseCallbackDelegates.PinchStretchCallback pinchStretchCallback,
      MapReverseCallbackDelegates.FlickCallback flickCallback,
      MapReverseCallbackDelegates.SnapshotCreatedCallback snapshotCreatedCallback)
    {
      if (AgMapControlManagedAdapter.reverseCallbacksInitialized)
        return;
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_SetMapReverseCallbacks(invokeProcessDispatchQueueCallback, centerChangedCallback, transformCenterChangedCallback, zoomLevelChangedCallback, headingChangedCallback, pitchChangedCallback, actualPitchChangedCallback, modeChangedCallback, colorModeChangedCallback, landmarksEnabledChangedCallback, pedestrianFeaturesVisibleChangedCallback, resolveCompletedCallback, viewChangingCallback, viewChangedCallback, tapCallback, doubleTapCallback, tapAndHoldCallback, panCallback, pinchStretchCallback, flickCallback, snapshotCreatedCallback));
      AgMapControlManagedAdapter.reverseCallbacksInitialized = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void ProcessDispatchQueue() => Shim.AgMapControlAdapter_ProcessDispatchQueue(this.Id);

    public GeoCoordinate PixelToGeo(Point pixelCoord)
    {
      MarshaledGeoCoordinates geoCoordinates;
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_PixelToGeo(this.nativeAdapter, checked ((int) pixelCoord.X), checked ((int) pixelCoord.Y), out geoCoordinates));
      return !geoCoordinates.IsValid ? (GeoCoordinate) null : MarshaledTypeConverter.ToGeoCoordinates(geoCoordinates);
    }

    public Point GeoToPixel(GeoCoordinate geoCoord)
    {
      double x;
      double y;
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_GeoToPixel(this.nativeAdapter, geoCoord.Latitude, geoCoord.Longitude, out x, out y));
      return new Point(x, y);
    }

    public void SetView(LocationRectangle boundingRectangle, MapAnimationKind animationKind) => this.SetView(boundingRectangle, AgMapControlManagedAdapter.zeroThickness, animationKind);

    public void SetView(
      LocationRectangle boundingRectangle,
      Thickness desiredMarginsInScreenPixel,
      MapAnimationKind animationKind)
    {
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_SetView_GeoRect(this.nativeAdapter, MarshaledTypeConverter.ToMarshaledBoundingRectangle(boundingRectangle), MarshaledTypeConverter.ToMarshaledMargins(desiredMarginsInScreenPixel), animationKind));
    }

    public void SetView(GeoCoordinate center, float zoomLevel, MapAnimationKind animationKind) => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_SetView_Geo(this.nativeAdapter, MarshaledTypeConverter.ToMarshaledGeoCoordinates(center), zoomLevel, animationKind));

    public void SetView(
      GeoCoordinate center,
      float zoomLevel,
      float heading,
      MapAnimationKind animationKind)
    {
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_SetView_GeoHeading(this.nativeAdapter, MarshaledTypeConverter.ToMarshaledGeoCoordinates(center), zoomLevel, heading, animationKind));
    }

    public void SetView(
      GeoCoordinate center,
      float zoomLevel,
      float heading,
      float pitch,
      MapAnimationKind animationKind)
    {
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_SetView_GeoHeadingPitch(this.nativeAdapter, MarshaledTypeConverter.ToMarshaledGeoCoordinates(center), zoomLevel, heading, pitch, animationKind));
    }

    public void GetMapObjectsAt(
      Point viewportPointInScreenPixel,
      IntPtr[] nativeHandles,
      ref uint nativeHandlesLength)
    {
      Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_GetMapObjectsAt(this.nativeAdapter, checked ((int) viewportPointInScreenPixel.X), checked ((int) viewportPointInScreenPixel.Y), nativeHandles, ref nativeHandlesLength));
    }

    public void AddMapObject(MapObjectAdapter mapObjectAdapter) => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_AddMapObject(this.nativeAdapter, mapObjectAdapter.NativeHandle));

    public void RemoveMapObject(MapObjectAdapter mapObjectAdapter) => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_RemoveMapObject(this.nativeAdapter, mapObjectAdapter.NativeHandle));

    public void AddMapOverlay(IMapOverlayModel mapOverlayModel)
    {
      if (mapOverlayModel.Handle == null || mapOverlayModel.Handle.IsInvalid)
      {
        AgMapOverlayModelSafeHandle mapOverlayModel1;
        Marshal.ThrowExceptionForHR(Shim.AgMapOverlayModelAdapter_CreateMapOverlayModel(this.nativeAdapter, mapOverlayModel.AnimationHandle, out mapOverlayModel1));
        mapOverlayModel.Handle = !mapOverlayModel1.IsInvalid ? (SafeHandle) mapOverlayModel1 : throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.CouldNotCreateMapOverlayModel));
      }
      Marshal.ThrowExceptionForHR(Shim.AgMapOverlayModelAdapter_AddMapOverlayModel(this.nativeAdapter, (AgMapOverlayModelSafeHandle) mapOverlayModel.Handle));
    }

    public void RemoveMapOverlay(IMapOverlayModel mapOverlayModel)
    {
      AgMapOverlayModelSafeHandle handle = (AgMapOverlayModelSafeHandle) mapOverlayModel.Handle;
      mapOverlayModel.Handle = (SafeHandle) null;
      Marshal.ThrowExceptionForHR(Shim.AgMapOverlayModelAdapter_RemoveMapOverlayModel(this.nativeAdapter, handle));
    }

    public void AddRoute(MapRoute route) => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_AddRoute(this.nativeAdapter, route.NativeHandle));

    public bool RemoveRoute(MapRoute route)
    {
      int errorCode = Shim.AgMapControlAdapter_RemoveRoute(this.nativeAdapter, route.NativeHandle);
      Marshal.ThrowExceptionForHR(errorCode);
      return errorCode == 0;
    }

    public void AddTileSource(AgTileSourceSafeHandle tileSourceNativeHandle) => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_AddTileSource(this.nativeAdapter, tileSourceNativeHandle));

    public void RemoveTileSource(AgTileSourceSafeHandle tileSourceNativeHandle) => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_RemoveTileSource(this.nativeAdapter, tileSourceNativeHandle));

    public void CreateSnapshotAsync() => Shim.AgMapControlAdapter_CreateSnapshot(this.nativeAdapter);

    public void Invalidate() => Shim.AgMapControlAdapter_Invalidate(this.nativeAdapter);

    public void OnLoaded() => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_OnLoaded(this.nativeAdapter));

    public void OnUnloaded() => Marshal.ThrowExceptionForHR(Shim.AgMapControlAdapter_OnUnloaded(this.nativeAdapter));

    protected void Dispose(bool disposing)
    {
      if (!this.disposed && disposing && (this.nativeAdapter != null && !this.nativeAdapter.IsInvalid))
      {
        this.nativeAdapter.Dispose();
        this.nativeAdapter = (AgMapControlSafeHandle) null;
      }
      this.disposed = true;
    }
  }
}
