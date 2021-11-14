// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Unified
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Services;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps
{
  internal class Unified
  {
    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapPolygon_Create(out MapObjectSafeHandle nativeHandle);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_SetPath(
      MapObjectSafeHandle nativeHandle,
      [MarshalAs(UnmanagedType.LPArray)] MarshaledGeoCoordinates[] coordinatesArray,
      int coordinatesArrayLength);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_GetStrokeColor(
      MapObjectSafeHandle nativeHandle,
      out int color);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_SetStrokeColor(
      MapObjectSafeHandle nativeHandle,
      int color);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_GetFillColor(
      MapObjectSafeHandle nativeHandle,
      out int color);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_SetFillColor(MapObjectSafeHandle nativeHandle, int color);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_SetStrokeDashed(
      MapObjectSafeHandle nativeHandle,
      [MarshalAs(UnmanagedType.U1)] bool enabled);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_GetStrokeThickness(
      MapObjectSafeHandle nativeHandle,
      out uint width);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolygon_SetStrokeThickness(
      MapObjectSafeHandle nativeHandle,
      uint width);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void TileHostInterface_SetTileHostScaleFactor(int value);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MapsSettings_SetApplicationId([MarshalAs(UnmanagedType.LPWStr)] string applicationId);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MapsSettings_SetApplicationCode([MarshalAs(UnmanagedType.LPWStr)] string applicationCode);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgEventLogger_d(int eventId, int data1);

    [DllImport("AgMapControlUnified.dll", CharSet = CharSet.Unicode)]
    public static extern void AgEventLogger_dz(int eventId, int data1, string data2);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int GeoRect_CalculateGeoRect(
      [MarshalAs(UnmanagedType.LPArray)] MarshaledGeoCoordinates[] coordinatesArray,
      int coordinatesArrayLength,
      out MarshaledBoundingRectangle boundingRectangle);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapObject_GetZIndex(
      MapObjectSafeHandle nativeMapObject,
      out ulong zIndex);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapObject_SetZIndex(
      MapObjectSafeHandle nativeMapObject,
      ulong zIndex);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapObject_GetVisible(
      MapObjectSafeHandle nativeMapObject,
      [MarshalAs(UnmanagedType.U1)] out bool visible);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapObject_SetVisible(
      MapObjectSafeHandle nativeMapObject,
      [MarshalAs(UnmanagedType.U1)] bool visible);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapOverlayModelAdapter_SetCoordinate(
      AgMapOverlayModelSafeHandle mapNativeAdapter,
      double latitude,
      double longitude);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapOverlayModelAdapter_SetCenter(
      AgMapOverlayModelSafeHandle mapNativeAdapter,
      int centerX,
      int centerY);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapPolyline_Create(out MapObjectSafeHandle nativeHandle);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolyline_SetPath(
      MapObjectSafeHandle nativeHandle,
      [MarshalAs(UnmanagedType.LPArray)] MarshaledGeoCoordinates[] coordinatesArray,
      int coordinatesArrayLength);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolyline_GetStrokeColor(
      MapObjectSafeHandle nativeHandle,
      out int color);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolyline_SetStrokeColor(
      MapObjectSafeHandle nativeHandle,
      int color);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolyline_SetStrokeDashed(
      MapObjectSafeHandle nativeHandle,
      [MarshalAs(UnmanagedType.U1)] bool enabled);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolyline_GetStrokeThickness(
      MapObjectSafeHandle nativeHandle,
      out uint width);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapPolyline_SetStrokeThickness(
      MapObjectSafeHandle nativeHandle,
      uint width);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_Create(
      RouteSafeHandle nativeRoute,
      out MapRouteSafeHandle nativeMapRoute);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_GetRoute(
      MapRouteSafeHandle nativeMapRoute,
      out RouteSafeHandle nativeRoute);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_SetRoute(
      MapRouteSafeHandle nativeMapRoute,
      RouteSafeHandle nativeRoute);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_GetColor(MapRouteSafeHandle nativeMapRoute, out int color);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_SetColor(MapRouteSafeHandle nativeMapRoute, int color);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_GetDisplayOutline(
      MapRouteSafeHandle nativeMapRoute,
      [MarshalAs(UnmanagedType.U1)] out bool displayOutline);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_SetDisplayOutline(
      MapRouteSafeHandle nativeMapRoute,
      [MarshalAs(UnmanagedType.U1)] bool displayOutline);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_GetOutlineColor(
      MapRouteSafeHandle nativeMapRoute,
      out int color);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_SetOutlineColor(
      MapRouteSafeHandle nativeMapRoute,
      int color);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_GetViewType(
      MapRouteSafeHandle nativeMapRoute,
      out int viewType);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapRoute_SetViewType(MapRouteSafeHandle nativeMapRoute, int viewType);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MapsSettings_GetDefaultCenter(
      out double latitude,
      out double longitude);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    [return: MarshalAs(UnmanagedType.U1)]
    public static extern bool MapsSettings_IsMapsDisabled();

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MapsSettings_GetMosConnectivityStatus(out MosConnectivityStatus status);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int MapsSettings_SetMosConnectivityStatus(MosConnectivityStatus status);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgFinderAdapter_Create(out AgFinderSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgFinderAdapter_GetInstanceId(AgFinderSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll", CharSet = CharSet.Unicode)]
    public static extern void AgFinderAdapter_Geocode(
      AgFinderSafeHandle nativeAdapter,
      string searchString,
      MarshaledGeoCoordinates hintCoordinates,
      uint maxResults);

    [DllImport("AgMapControlUnified.dll", CharSet = CharSet.Unicode)]
    public static extern void AgFinderAdapter_ReverseGeocode(
      AgFinderSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgFinderAdapter_Cancel(AgFinderSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern QueryStatus AgFinderAdapter_GetStatus(
      AgFinderSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgFinderAdapter_GetErrorCode(AgFinderSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern uint AgFinderAdapter_GetResultCount(AgFinderSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgFinderAdapter_GetResult(
      AgFinderSafeHandle nativeAdapter,
      uint index,
      out MarshaledLocation location);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgFinderAdapter_ProcessDispatchQueue(int id);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgFinderAdapter_SetFinderReverseCallbacks(
      FinderReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueEventHandler,
      FinderReverseCallbackDelegates.StatusChangedCallback statusChangedEventHandler);

    [DllImport("AgMapControlUnified.dll")]
    public static extern AgMapControlSafeHandle AgMapControlAdapter_FindAdapter(
      int controlId);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapControlAdapter_GetControlId(AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapControlAdapter_SetExternalInputId(
      AgMapControlSafeHandle nativeAdapter,
      int externalInputId);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgMapControlAdapter_SetViewportSize(
      AgMapControlSafeHandle nativeAdapter,
      int width,
      int height);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_GetCenter(
      AgMapControlSafeHandle nativeAdapter,
      out double latitude,
      out double longitude);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgMapControlAdapter_SetCenter(
      AgMapControlSafeHandle nativeAdapter,
      double latitude,
      double longitude);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_GetTransformCenter(
      AgMapControlSafeHandle nativeAdapter,
      out double x,
      out double y);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgMapControlAdapter_SetTransformCenter(
      AgMapControlSafeHandle nativeAdapter,
      double x,
      double y);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern float AgMapControlAdapter_GetZoomLevel(AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgMapControlAdapter_SetZoomLevel(
      AgMapControlSafeHandle nativeAdapter,
      float zoomLevel);

    [DllImport("AgMapControlUnified.dll")]
    public static extern float AgMapControlAdapter_GetHeading(AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_SetHeading(
      AgMapControlSafeHandle nativeAdapter,
      float heading);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_GetTilt(
      AgMapControlSafeHandle nativeAdapter,
      out float tilt);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_SetTilt(
      AgMapControlSafeHandle nativeAdapter,
      float tilt);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_GetActualTilt(
      AgMapControlSafeHandle nativeAdapter,
      out float tilt);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_GetMode(
      AgMapControlSafeHandle nativeAdapter,
      out int mode);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_SetMode(
      AgMapControlSafeHandle nativeAdapter,
      int mode);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_GetContrastMode(
      AgMapControlSafeHandle nativeAdapter,
      out int contrastMode);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_SetContrastMode(
      AgMapControlSafeHandle nativeAdapter,
      int contrastMode);

    [DllImport("AgMapControlUnified.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AgMapControlAdapter_GetLandmarksVisible(
      AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_SetLandmarksVisible(
      AgMapControlSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.U1)] bool visible);

    [DllImport("AgMapControlUnified.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AgMapControlAdapter_GetPedestrianFeaturesVisible(
      AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_SetPedestrianFeaturesVisible(
      AgMapControlSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.U1)] bool visible);

    [DllImport("AgMapControlUnified.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AgMapControlAdapter_GetWatermarkVisible(
      AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AgMapControlAdapter_SetWatermarkVisible(
      AgMapControlSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.U1)] bool visible);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgMapControlAdapter_ProcessDispatchQueue(int controlId);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_SetMapReverseCallbacks(
      MapReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueCallback,
      MapReverseCallbackDelegates.CenterChangedCallback centerChangedCallback,
      MapReverseCallbackDelegates.TransformCenterChangedCallback transformCenterChangedCallback,
      MapReverseCallbackDelegates.ZoomLevelChangedCallback zoomLevelChangedCallback,
      MapReverseCallbackDelegates.HeadingChangedCallback headingChangedCallback,
      MapReverseCallbackDelegates.PitchChangedCallback pitchChangedCallback,
      MapReverseCallbackDelegates.ActualPitchChangedCallback actualPitchChangedCallback,
      MapReverseCallbackDelegates.CartographicModeChangedCallback cartographicModeChangedCallback,
      MapReverseCallbackDelegates.ColorModeChangedCallback contrastModeChangedCallback,
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
      MapReverseCallbackDelegates.SnapshotCreatedCallback snapshotCreatedCallback);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_PixelToGeo(
      AgMapControlSafeHandle nativeAdapter,
      int x,
      int y,
      out MarshaledGeoCoordinates geoCoordinates);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_GeoToPixel(
      AgMapControlSafeHandle nativeAdapter,
      double latitude,
      double longitude,
      out double x,
      out double y);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_SetView_GeoRect(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledBoundingRectangle boundingRectangle,
      MarshaledMargins margins,
      MapAnimationKind animationKind);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_SetView_Geo(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates,
      float zoomLevel,
      MapAnimationKind animationKind);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_SetView_GeoHeading(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates,
      float zoomLevel,
      float heading,
      MapAnimationKind animationKind);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_SetView_GeoHeadingPitch(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates,
      float zoomLevel,
      float heading,
      float pitch,
      MapAnimationKind animationKind);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_CreateSnapshot(
      AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapControlAdapter_Invalidate(AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_GetMapObjectsAt(
      AgMapControlSafeHandle nativeAdapter,
      int x,
      int y,
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] nativeHandles,
      ref uint nativeHandlesLength);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_AddMapObject(
      AgMapControlSafeHandle nativeAdapter,
      MapObjectSafeHandle nativeMapObject);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_RemoveMapObject(
      AgMapControlSafeHandle nativeAdapter,
      MapObjectSafeHandle nativeMapObject);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapOverlayModelAdapter_CreateMapOverlayModel(
      AgMapControlSafeHandle mapNativeAdapter,
      SafeHandle externalAnimationHandle,
      out AgMapOverlayModelSafeHandle mapOverlayModel);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapOverlayModelAdapter_AddMapOverlayModel(
      AgMapControlSafeHandle mapNativeAdapter,
      AgMapOverlayModelSafeHandle mapOverlayModel);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgMapOverlayModelAdapter_RemoveMapOverlayModel(
      AgMapControlSafeHandle mapNativeAdapter,
      AgMapOverlayModelSafeHandle mapOverlayModel);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_AddRoute(
      AgMapControlSafeHandle nativeAdapter,
      MapRouteSafeHandle nativeMapRoute);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_RemoveRoute(
      AgMapControlSafeHandle nativeAdapter,
      MapRouteSafeHandle nativeMapRoute);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_AddTileSource(
      AgMapControlSafeHandle nativeAdapter,
      AgTileSourceSafeHandle tileSource);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_RemoveTileSource(
      AgMapControlSafeHandle nativeAdapter,
      AgTileSourceSafeHandle tileSource);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_OnLoaded(AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgMapControlAdapter_OnUnloaded(AgMapControlSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgRouterAdapter_Create(out AgRouterSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgRouterAdapter_GetInstanceId(AgRouterSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgRouterAdapter_CalculateRoute(
      AgRouterSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.LPArray)] MarshaledGeoCoordinates[] waypoints,
      int waypointCount,
      uint travelMode,
      uint routeOptimization,
      int startHeadingInDegrees);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgRouterAdapter_Cancel(AgRouterSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern QueryStatus AgRouterAdapter_GetStatus(
      AgRouterSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgRouterAdapter_GetErrorCode(AgRouterSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgRouterAdapter_GetRoute(
      RouteSafeHandle nativeRoute,
      out MarshaledRoute route);

    [DllImport("AgMapControlUnified.dll")]
    public static extern RouteSafeHandle AgRouterAdapter_GetRouteHandle(
      AgRouterSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void AgRouterAdapter_ProcessDispatchQueue(int id);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgRouterAdapter_SetRouterReverseCallbacks(
      RouterReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueEventHandler,
      RouterReverseCallbackDelegates.StatusChangedCallback statusChangedEventHandler);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgTileSourceAdapter_Create(out AgTileSourceSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgTileSourceAdapter_GetInstanceId(AgTileSourceSafeHandle nativeAdapter);

    [DllImport("AgMapControlUnified.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int AgTileSourceAdapter_SetTileSourceReverseCallbacks(
      TileSourceReverseCallbackDelegates.GetUriCallback getUriCallback);

    [DllImport("AgMapControlUnified.dll", CharSet = CharSet.Unicode)]
    public static extern int AgTileSourceAdapter_SetUri(IntPtr buffer, string uri);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgTileSourceAdapter_GetZoomRange(
      AgTileSourceSafeHandle nativeAdapter,
      out int fromZoomLevel,
      out int toZoomLevel);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgTileSourceAdapter_SetZoomRange(
      AgTileSourceSafeHandle nativeAdapter,
      int fromZoomLevel,
      int toZoomLevel);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgTileSourceAdapter_GetBoundingRectangle(
      AgTileSourceSafeHandle nativeAdapter,
      out MarshaledBoundingRectangle boundingRectangle);

    [DllImport("AgMapControlUnified.dll")]
    public static extern int AgTileSourceAdapter_SetBoundingRectangle(
      AgTileSourceSafeHandle nativeAdapter,
      MarshaledBoundingRectangle boundingRectangle);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgFinderAdapter_Destroy(IntPtr nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgRouterAdapter_Destroy(IntPtr nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgRouterAdapter_DestroyRoute(IntPtr nativeRoute);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapObject_ReleaseMapObject(IntPtr nativeMapObject);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapRoute_Destroy(IntPtr nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgTileSourceAdapter_Destroy(IntPtr nativeAdapter);

    [DllImport("AgMapControlUnified.dll")]
    public static extern void AgMapOverlayModelAdapter_Destroy(IntPtr nativeAdapter);
  }
}
