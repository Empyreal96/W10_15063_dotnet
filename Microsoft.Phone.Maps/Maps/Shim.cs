// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Shim
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Services;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps
{
  internal static class Shim
  {
    private static bool isUnified;
    private static bool isInited;

    public static bool UseUnifiedStack()
    {
      Shim.Init();
      return Shim.isUnified;
    }

    public static int AgMapPolygon_Create(out MapObjectSafeHandle nativeHandle)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_Create(out nativeHandle) : Unified.AgMapPolygon_Create(out nativeHandle);
    }

    public static int AgMapPolygon_SetPath(
      MapObjectSafeHandle nativeHandle,
      MarshaledGeoCoordinates[] coordinatesArray,
      int coordinatesArrayLength)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_SetPath(nativeHandle, coordinatesArray, coordinatesArrayLength) : Unified.AgMapPolygon_SetPath(nativeHandle, coordinatesArray, coordinatesArrayLength);
    }

    public static int AgMapPolygon_GetStrokeColor(MapObjectSafeHandle nativeHandle, out int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_GetStrokeColor(nativeHandle, out color) : Unified.AgMapPolygon_GetStrokeColor(nativeHandle, out color);
    }

    public static int AgMapPolygon_SetStrokeColor(MapObjectSafeHandle nativeHandle, int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_SetStrokeColor(nativeHandle, color) : Unified.AgMapPolygon_SetStrokeColor(nativeHandle, color);
    }

    public static int AgMapPolygon_GetFillColor(MapObjectSafeHandle nativeHandle, out int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_GetFillColor(nativeHandle, out color) : Unified.AgMapPolygon_GetFillColor(nativeHandle, out color);
    }

    public static int AgMapPolygon_SetFillColor(MapObjectSafeHandle nativeHandle, int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_SetFillColor(nativeHandle, color) : Unified.AgMapPolygon_SetFillColor(nativeHandle, color);
    }

    public static int AgMapPolygon_SetStrokeDashed(MapObjectSafeHandle nativeHandle, [MarshalAs(UnmanagedType.U1)] bool enabled)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_SetStrokeDashed(nativeHandle, enabled) : Unified.AgMapPolygon_SetStrokeDashed(nativeHandle, enabled);
    }

    public static int AgMapPolygon_GetStrokeThickness(
      MapObjectSafeHandle nativeHandle,
      out uint width)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_GetStrokeThickness(nativeHandle, out width) : Unified.AgMapPolygon_GetStrokeThickness(nativeHandle, out width);
    }

    public static int AgMapPolygon_SetStrokeThickness(MapObjectSafeHandle nativeHandle, uint width)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolygon_SetStrokeThickness(nativeHandle, width) : Unified.AgMapPolygon_SetStrokeThickness(nativeHandle, width);
    }

    public static void TileHostInterface_SetTileHostScaleFactor(int value)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.TileHostInterface_SetTileHostScaleFactor(value);
      else
        Converged.TileHostInterface_SetTileHostScaleFactor(value);
    }

    public static int MapsSettings_SetApplicationId([MarshalAs(UnmanagedType.LPWStr)] string applicationId)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.MapsSettings_SetApplicationId(applicationId) : Unified.MapsSettings_SetApplicationId(applicationId);
    }

    public static int MapsSettings_SetApplicationCode([MarshalAs(UnmanagedType.LPWStr)] string applicationCode)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.MapsSettings_SetApplicationCode(applicationCode) : Unified.MapsSettings_SetApplicationCode(applicationCode);
    }

    public static void AgEventLogger_d(int eventId, int data1)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgEventLogger_d(eventId, data1);
      else
        Converged.AgEventLogger_d(eventId, data1);
    }

    public static void AgEventLogger_dz(int eventId, int data1, string data2)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgEventLogger_dz(eventId, data1, data2);
      else
        Converged.AgEventLogger_dz(eventId, data1, data2);
    }

    public static int GeoRect_CalculateGeoRect(
      [MarshalAs(UnmanagedType.LPArray)] MarshaledGeoCoordinates[] coordinatesArray,
      int coordinatesArrayLength,
      out MarshaledBoundingRectangle boundingRectangle)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.GeoRect_CalculateGeoRect(coordinatesArray, coordinatesArrayLength, out boundingRectangle) : Unified.GeoRect_CalculateGeoRect(coordinatesArray, coordinatesArrayLength, out boundingRectangle);
    }

    public static int AgMapObject_GetZIndex(MapObjectSafeHandle nativeMapObject, out ulong zIndex)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapObject_GetZIndex(nativeMapObject, out zIndex) : Unified.AgMapObject_GetZIndex(nativeMapObject, out zIndex);
    }

    public static int AgMapObject_SetZIndex(MapObjectSafeHandle nativeMapObject, ulong zIndex)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapObject_SetZIndex(nativeMapObject, zIndex) : Unified.AgMapObject_SetZIndex(nativeMapObject, zIndex);
    }

    public static int AgMapObject_GetVisible(MapObjectSafeHandle nativeMapObject, [MarshalAs(UnmanagedType.U1)] out bool visible)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapObject_GetVisible(nativeMapObject, out visible) : Unified.AgMapObject_GetVisible(nativeMapObject, out visible);
    }

    public static int AgMapObject_SetVisible(MapObjectSafeHandle nativeMapObject, [MarshalAs(UnmanagedType.U1)] bool visible)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapObject_SetVisible(nativeMapObject, visible) : Unified.AgMapObject_SetVisible(nativeMapObject, visible);
    }

    public static int AgMapOverlayModelAdapter_SetCoordinate(
      AgMapOverlayModelSafeHandle mapNativeAdapter,
      double latitude,
      double longitude)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapOverlayModelAdapter_SetCoordinate(mapNativeAdapter, latitude, longitude) : Unified.AgMapOverlayModelAdapter_SetCoordinate(mapNativeAdapter, latitude, longitude);
    }

    public static int AgMapOverlayModelAdapter_SetCenter(
      AgMapOverlayModelSafeHandle mapNativeAdapter,
      int centerX,
      int centerY)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapOverlayModelAdapter_SetCenter(mapNativeAdapter, centerX, centerY) : Unified.AgMapOverlayModelAdapter_SetCenter(mapNativeAdapter, centerX, centerY);
    }

    public static int AgMapPolyline_Create(out MapObjectSafeHandle nativeHandle)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_Create(out nativeHandle) : Unified.AgMapPolyline_Create(out nativeHandle);
    }

    public static int AgMapPolyline_SetPath(
      MapObjectSafeHandle nativeHandle,
      MarshaledGeoCoordinates[] coordinatesArray,
      int coordinatesArrayLength)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_SetPath(nativeHandle, coordinatesArray, coordinatesArrayLength) : Unified.AgMapPolyline_SetPath(nativeHandle, coordinatesArray, coordinatesArrayLength);
    }

    public static int AgMapPolyline_GetStrokeColor(MapObjectSafeHandle nativeHandle, out int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_GetStrokeColor(nativeHandle, out color) : Unified.AgMapPolyline_GetStrokeColor(nativeHandle, out color);
    }

    public static int AgMapPolyline_SetStrokeColor(MapObjectSafeHandle nativeHandle, int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_SetStrokeColor(nativeHandle, color) : Unified.AgMapPolyline_SetStrokeColor(nativeHandle, color);
    }

    public static int AgMapPolyline_SetStrokeDashed(MapObjectSafeHandle nativeHandle, [MarshalAs(UnmanagedType.U1)] bool enabled)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_SetStrokeDashed(nativeHandle, enabled) : Unified.AgMapPolyline_SetStrokeDashed(nativeHandle, enabled);
    }

    public static int AgMapPolyline_GetStrokeThickness(
      MapObjectSafeHandle nativeHandle,
      out uint width)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_GetStrokeThickness(nativeHandle, out width) : Unified.AgMapPolyline_GetStrokeThickness(nativeHandle, out width);
    }

    public static int AgMapPolyline_SetStrokeThickness(MapObjectSafeHandle nativeHandle, uint width)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapPolyline_SetStrokeThickness(nativeHandle, width) : Unified.AgMapPolyline_SetStrokeThickness(nativeHandle, width);
    }

    public static int AgMapRoute_Create(
      RouteSafeHandle nativeRoute,
      out MapRouteSafeHandle nativeMapRoute)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_Create(nativeRoute, out nativeMapRoute) : Unified.AgMapRoute_Create(nativeRoute, out nativeMapRoute);
    }

    public static int AgMapRoute_GetRoute(
      MapRouteSafeHandle nativeMapRoute,
      out RouteSafeHandle nativeRoute)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_GetRoute(nativeMapRoute, out nativeRoute) : Unified.AgMapRoute_GetRoute(nativeMapRoute, out nativeRoute);
    }

    public static int AgMapRoute_SetRoute(
      MapRouteSafeHandle nativeMapRoute,
      RouteSafeHandle nativeRoute)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_SetRoute(nativeMapRoute, nativeRoute) : Unified.AgMapRoute_SetRoute(nativeMapRoute, nativeRoute);
    }

    public static int AgMapRoute_GetColor(MapRouteSafeHandle nativeMapRoute, out int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_GetColor(nativeMapRoute, out color) : Unified.AgMapRoute_GetColor(nativeMapRoute, out color);
    }

    public static int AgMapRoute_SetColor(MapRouteSafeHandle nativeMapRoute, int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_SetColor(nativeMapRoute, color) : Unified.AgMapRoute_SetColor(nativeMapRoute, color);
    }

    public static int AgMapRoute_GetDisplayOutline(
      MapRouteSafeHandle nativeMapRoute,
      [MarshalAs(UnmanagedType.U1)] out bool displayOutline)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_GetDisplayOutline(nativeMapRoute, out displayOutline) : Unified.AgMapRoute_GetDisplayOutline(nativeMapRoute, out displayOutline);
    }

    public static int AgMapRoute_SetDisplayOutline(
      MapRouteSafeHandle nativeMapRoute,
      [MarshalAs(UnmanagedType.U1)] bool displayOutline)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_SetDisplayOutline(nativeMapRoute, displayOutline) : Unified.AgMapRoute_SetDisplayOutline(nativeMapRoute, displayOutline);
    }

    public static int AgMapRoute_GetOutlineColor(MapRouteSafeHandle nativeMapRoute, out int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_GetOutlineColor(nativeMapRoute, out color) : Unified.AgMapRoute_GetOutlineColor(nativeMapRoute, out color);
    }

    public static int AgMapRoute_SetOutlineColor(MapRouteSafeHandle nativeMapRoute, int color)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_SetOutlineColor(nativeMapRoute, color) : Unified.AgMapRoute_SetOutlineColor(nativeMapRoute, color);
    }

    public static int AgMapRoute_GetViewType(MapRouteSafeHandle nativeMapRoute, out int viewType)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_GetViewType(nativeMapRoute, out viewType) : Unified.AgMapRoute_GetViewType(nativeMapRoute, out viewType);
    }

    public static int AgMapRoute_SetViewType(MapRouteSafeHandle nativeMapRoute, int viewType)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapRoute_SetViewType(nativeMapRoute, viewType) : Unified.AgMapRoute_SetViewType(nativeMapRoute, viewType);
    }

    public static int MapsSettings_GetDefaultCenter(out double latitude, out double longitude)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.MapsSettings_GetDefaultCenter(out latitude, out longitude) : Unified.MapsSettings_GetDefaultCenter(out latitude, out longitude);
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public static bool MapsSettings_IsMapsDisabled()
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.MapsSettings_IsMapsDisabled() : Unified.MapsSettings_IsMapsDisabled();
    }

    public static int MapsSettings_GetMosConnectivityStatus(out MosConnectivityStatus status)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.MapsSettings_GetMosConnectivityStatus(out status) : Unified.MapsSettings_GetMosConnectivityStatus(out status);
    }

    public static int MapsSettings_SetMosConnectivityStatus(MosConnectivityStatus status)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.MapsSettings_SetMosConnectivityStatus(status) : Unified.MapsSettings_SetMosConnectivityStatus(status);
    }

    public static int AgFinderAdapter_Create(out AgFinderSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_Create(out nativeAdapter) : Unified.AgFinderAdapter_Create(out nativeAdapter);
    }

    public static int AgFinderAdapter_GetInstanceId(AgFinderSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_GetInstanceId(nativeAdapter) : Unified.AgFinderAdapter_GetInstanceId(nativeAdapter);
    }

    public static void AgFinderAdapter_Geocode(
      AgFinderSafeHandle nativeAdapter,
      string searchString,
      MarshaledGeoCoordinates hintCoordinates,
      uint maxResults)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgFinderAdapter_Geocode(nativeAdapter, searchString, hintCoordinates, maxResults);
      else
        Converged.AgFinderAdapter_Geocode(nativeAdapter, searchString, hintCoordinates, maxResults);
    }

    public static void AgFinderAdapter_ReverseGeocode(
      AgFinderSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgFinderAdapter_ReverseGeocode(nativeAdapter, coordinates);
      else
        Converged.AgFinderAdapter_ReverseGeocode(nativeAdapter, coordinates);
    }

    public static void AgFinderAdapter_Cancel(AgFinderSafeHandle nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgFinderAdapter_Cancel(nativeAdapter);
      else
        Converged.AgFinderAdapter_Cancel(nativeAdapter);
    }

    public static QueryStatus AgFinderAdapter_GetStatus(AgFinderSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_GetStatus(nativeAdapter) : Unified.AgFinderAdapter_GetStatus(nativeAdapter);
    }

    public static int AgFinderAdapter_GetErrorCode(AgFinderSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_GetErrorCode(nativeAdapter) : Unified.AgFinderAdapter_GetErrorCode(nativeAdapter);
    }

    public static uint AgFinderAdapter_GetResultCount(AgFinderSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_GetResultCount(nativeAdapter) : Unified.AgFinderAdapter_GetResultCount(nativeAdapter);
    }

    public static int AgFinderAdapter_GetResult(
      AgFinderSafeHandle nativeAdapter,
      uint index,
      out MarshaledLocation location)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_GetResult(nativeAdapter, index, out location) : Unified.AgFinderAdapter_GetResult(nativeAdapter, index, out location);
    }

    public static void AgFinderAdapter_ProcessDispatchQueue(int id)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgFinderAdapter_ProcessDispatchQueue(id);
      else
        Converged.AgFinderAdapter_ProcessDispatchQueue(id);
    }

    public static int AgFinderAdapter_SetFinderReverseCallbacks(
      FinderReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueEventHandler,
      FinderReverseCallbackDelegates.StatusChangedCallback statusChangedEventHandler)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgFinderAdapter_SetFinderReverseCallbacks(invokeProcessDispatchQueueEventHandler, statusChangedEventHandler) : Unified.AgFinderAdapter_SetFinderReverseCallbacks(invokeProcessDispatchQueueEventHandler, statusChangedEventHandler);
    }

    public static AgMapControlSafeHandle AgMapControlAdapter_FindAdapter(
      int controlId)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_FindAdapter(controlId) : Unified.AgMapControlAdapter_FindAdapter(controlId);
    }

    public static int AgMapControlAdapter_GetControlId(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetControlId(nativeAdapter) : Unified.AgMapControlAdapter_GetControlId(nativeAdapter);
    }

    public static int AgMapControlAdapter_SetExternalInputId(
      AgMapControlSafeHandle nativeAdapter,
      int externalInputId)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetExternalInputId(nativeAdapter, externalInputId) : Unified.AgMapControlAdapter_SetExternalInputId(nativeAdapter, externalInputId);
    }

    public static void AgMapControlAdapter_SetViewportSize(
      AgMapControlSafeHandle nativeAdapter,
      int width,
      int height)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetViewportSize(nativeAdapter, width, height);
      else
        Converged.AgMapControlAdapter_SetViewportSize(nativeAdapter, width, height);
    }

    public static int AgMapControlAdapter_GetCenter(
      AgMapControlSafeHandle nativeAdapter,
      out double latitude,
      out double longitude)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetCenter(nativeAdapter, out latitude, out longitude) : Unified.AgMapControlAdapter_GetCenter(nativeAdapter, out latitude, out longitude);
    }

    public static void AgMapControlAdapter_SetCenter(
      AgMapControlSafeHandle nativeAdapter,
      double latitude,
      double longitude)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetCenter(nativeAdapter, latitude, longitude);
      else
        Converged.AgMapControlAdapter_SetCenter(nativeAdapter, latitude, longitude);
    }

    public static int AgMapControlAdapter_GetTransformCenter(
      AgMapControlSafeHandle nativeAdapter,
      out double x,
      out double y)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetTransformCenter(nativeAdapter, out x, out y) : Unified.AgMapControlAdapter_GetTransformCenter(nativeAdapter, out x, out y);
    }

    public static void AgMapControlAdapter_SetTransformCenter(
      AgMapControlSafeHandle nativeAdapter,
      double x,
      double y)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetTransformCenter(nativeAdapter, x, y);
      else
        Converged.AgMapControlAdapter_SetTransformCenter(nativeAdapter, x, y);
    }

    public static float AgMapControlAdapter_GetZoomLevel(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetZoomLevel(nativeAdapter) : Unified.AgMapControlAdapter_GetZoomLevel(nativeAdapter);
    }

    public static void AgMapControlAdapter_SetZoomLevel(
      AgMapControlSafeHandle nativeAdapter,
      float zoomLevel)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetZoomLevel(nativeAdapter, zoomLevel);
      else
        Converged.AgMapControlAdapter_SetZoomLevel(nativeAdapter, zoomLevel);
    }

    public static float AgMapControlAdapter_GetHeading(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetHeading(nativeAdapter) : Unified.AgMapControlAdapter_GetHeading(nativeAdapter);
    }

    public static void AgMapControlAdapter_SetHeading(
      AgMapControlSafeHandle nativeAdapter,
      float heading)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetHeading(nativeAdapter, heading);
      else
        Converged.AgMapControlAdapter_SetHeading(nativeAdapter, heading);
    }

    public static void AgMapControlAdapter_GetTilt(
      AgMapControlSafeHandle nativeAdapter,
      out float tilt)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_GetTilt(nativeAdapter, out tilt);
      else
        Converged.AgMapControlAdapter_GetTilt(nativeAdapter, out tilt);
    }

    public static void AgMapControlAdapter_SetTilt(AgMapControlSafeHandle nativeAdapter, float tilt)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetTilt(nativeAdapter, tilt);
      else
        Converged.AgMapControlAdapter_SetTilt(nativeAdapter, tilt);
    }

    public static void AgMapControlAdapter_GetActualTilt(
      AgMapControlSafeHandle nativeAdapter,
      out float tilt)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_GetActualTilt(nativeAdapter, out tilt);
      else
        Converged.AgMapControlAdapter_GetActualTilt(nativeAdapter, out tilt);
    }

    public static void AgMapControlAdapter_GetMode(
      AgMapControlSafeHandle nativeAdapter,
      out int mode)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_GetMode(nativeAdapter, out mode);
      else
        Converged.AgMapControlAdapter_GetMode(nativeAdapter, out mode);
    }

    public static void AgMapControlAdapter_SetMode(AgMapControlSafeHandle nativeAdapter, int mode)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetMode(nativeAdapter, mode);
      else
        Converged.AgMapControlAdapter_SetMode(nativeAdapter, mode);
    }

    public static void AgMapControlAdapter_GetContrastMode(
      AgMapControlSafeHandle nativeAdapter,
      out int contrastMode)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_GetContrastMode(nativeAdapter, out contrastMode);
      else
        Converged.AgMapControlAdapter_GetContrastMode(nativeAdapter, out contrastMode);
    }

    public static void AgMapControlAdapter_SetContrastMode(
      AgMapControlSafeHandle nativeAdapter,
      int contrastMode)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetContrastMode(nativeAdapter, contrastMode);
      else
        Converged.AgMapControlAdapter_SetContrastMode(nativeAdapter, contrastMode);
    }

    [return: MarshalAs(UnmanagedType.Bool)]
    public static bool AgMapControlAdapter_GetLandmarksVisible(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetLandmarksVisible(nativeAdapter) : Unified.AgMapControlAdapter_GetLandmarksVisible(nativeAdapter);
    }

    public static void AgMapControlAdapter_SetLandmarksVisible(
      AgMapControlSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.U1)] bool visible)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetLandmarksVisible(nativeAdapter, visible);
      else
        Converged.AgMapControlAdapter_SetLandmarksVisible(nativeAdapter, visible);
    }

    [return: MarshalAs(UnmanagedType.Bool)]
    public static bool AgMapControlAdapter_GetPedestrianFeaturesVisible(
      AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetPedestrianFeaturesVisible(nativeAdapter) : Unified.AgMapControlAdapter_GetPedestrianFeaturesVisible(nativeAdapter);
    }

    public static void AgMapControlAdapter_SetPedestrianFeaturesVisible(
      AgMapControlSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.U1)] bool visible)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_SetPedestrianFeaturesVisible(nativeAdapter, visible);
      else
        Converged.AgMapControlAdapter_SetPedestrianFeaturesVisible(nativeAdapter, visible);
    }

    [return: MarshalAs(UnmanagedType.Bool)]
    public static bool AgMapControlAdapter_GetWatermarkVisible(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetWatermarkVisible(nativeAdapter) : Unified.AgMapControlAdapter_GetWatermarkVisible(nativeAdapter);
    }

    [return: MarshalAs(UnmanagedType.Bool)]
    public static bool AgMapControlAdapter_SetWatermarkVisible(
      AgMapControlSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.U1)] bool visible)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetWatermarkVisible(nativeAdapter, visible) : Unified.AgMapControlAdapter_SetWatermarkVisible(nativeAdapter, visible);
    }

    public static void AgMapControlAdapter_ProcessDispatchQueue(int controlId)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_ProcessDispatchQueue(controlId);
      else
        Converged.AgMapControlAdapter_ProcessDispatchQueue(controlId);
    }

    public static int AgMapControlAdapter_SetMapReverseCallbacks(
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
      MapReverseCallbackDelegates.SnapshotCreatedCallback snapshotCreatedCallback)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetMapReverseCallbacks(invokeProcessDispatchQueueCallback, centerChangedCallback, transformCenterChangedCallback, zoomLevelChangedCallback, headingChangedCallback, pitchChangedCallback, actualPitchChangedCallback, cartographicModeChangedCallback, contrastModeChangedCallback, landmarksEnabledChangedCallback, pedestrianFeaturesVisibleChangedCallback, resolveCompletedCallback, viewChangingCallback, viewChangedCallback, tapCallback, doubleTapCallback, tapAndHoldCallback, panCallback, pinchStretchCallback, flickCallback, snapshotCreatedCallback) : Unified.AgMapControlAdapter_SetMapReverseCallbacks(invokeProcessDispatchQueueCallback, centerChangedCallback, transformCenterChangedCallback, zoomLevelChangedCallback, headingChangedCallback, pitchChangedCallback, actualPitchChangedCallback, cartographicModeChangedCallback, contrastModeChangedCallback, landmarksEnabledChangedCallback, pedestrianFeaturesVisibleChangedCallback, resolveCompletedCallback, viewChangingCallback, viewChangedCallback, tapCallback, doubleTapCallback, tapAndHoldCallback, panCallback, pinchStretchCallback, flickCallback, snapshotCreatedCallback);
    }

    public static int AgMapControlAdapter_PixelToGeo(
      AgMapControlSafeHandle nativeAdapter,
      int x,
      int y,
      out MarshaledGeoCoordinates geoCoordinates)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_PixelToGeo(nativeAdapter, x, y, out geoCoordinates) : Unified.AgMapControlAdapter_PixelToGeo(nativeAdapter, x, y, out geoCoordinates);
    }

    public static int AgMapControlAdapter_GeoToPixel(
      AgMapControlSafeHandle nativeAdapter,
      double latitude,
      double longitude,
      out double x,
      out double y)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GeoToPixel(nativeAdapter, latitude, longitude, out x, out y) : Unified.AgMapControlAdapter_GeoToPixel(nativeAdapter, latitude, longitude, out x, out y);
    }

    public static int AgMapControlAdapter_SetView_GeoRect(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledBoundingRectangle boundingRectangle,
      MarshaledMargins margins,
      MapAnimationKind animationKind)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetView_GeoRect(nativeAdapter, boundingRectangle, margins, animationKind) : Unified.AgMapControlAdapter_SetView_GeoRect(nativeAdapter, boundingRectangle, margins, animationKind);
    }

    public static int AgMapControlAdapter_SetView_Geo(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates,
      float zoomLevel,
      MapAnimationKind animationKind)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetView_Geo(nativeAdapter, coordinates, zoomLevel, animationKind) : Unified.AgMapControlAdapter_SetView_Geo(nativeAdapter, coordinates, zoomLevel, animationKind);
    }

    public static int AgMapControlAdapter_SetView_GeoHeading(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates,
      float zoomLevel,
      float heading,
      MapAnimationKind animationKind)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetView_GeoHeading(nativeAdapter, coordinates, zoomLevel, heading, animationKind) : Unified.AgMapControlAdapter_SetView_GeoHeading(nativeAdapter, coordinates, zoomLevel, heading, animationKind);
    }

    public static int AgMapControlAdapter_SetView_GeoHeadingPitch(
      AgMapControlSafeHandle nativeAdapter,
      MarshaledGeoCoordinates coordinates,
      float zoomLevel,
      float heading,
      float pitch,
      MapAnimationKind animationKind)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_SetView_GeoHeadingPitch(nativeAdapter, coordinates, zoomLevel, heading, pitch, animationKind) : Unified.AgMapControlAdapter_SetView_GeoHeadingPitch(nativeAdapter, coordinates, zoomLevel, heading, pitch, animationKind);
    }

    public static void AgMapControlAdapter_CreateSnapshot(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_CreateSnapshot(nativeAdapter);
      else
        Converged.AgMapControlAdapter_CreateSnapshot(nativeAdapter);
    }

    public static void AgMapControlAdapter_Invalidate(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapControlAdapter_Invalidate(nativeAdapter);
      else
        Converged.AgMapControlAdapter_Invalidate(nativeAdapter);
    }

    public static int AgMapControlAdapter_GetMapObjectsAt(
      AgMapControlSafeHandle nativeAdapter,
      int x,
      int y,
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] IntPtr[] nativeHandles,
      ref uint nativeHandlesLength)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_GetMapObjectsAt(nativeAdapter, x, y, nativeHandles, ref nativeHandlesLength) : Unified.AgMapControlAdapter_GetMapObjectsAt(nativeAdapter, x, y, nativeHandles, ref nativeHandlesLength);
    }

    public static int AgMapControlAdapter_AddMapObject(
      AgMapControlSafeHandle nativeAdapter,
      MapObjectSafeHandle nativeMapObject)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_AddMapObject(nativeAdapter, nativeMapObject) : Unified.AgMapControlAdapter_AddMapObject(nativeAdapter, nativeMapObject);
    }

    public static int AgMapControlAdapter_RemoveMapObject(
      AgMapControlSafeHandle nativeAdapter,
      MapObjectSafeHandle nativeMapObject)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_RemoveMapObject(nativeAdapter, nativeMapObject) : Unified.AgMapControlAdapter_RemoveMapObject(nativeAdapter, nativeMapObject);
    }

    public static int AgMapOverlayModelAdapter_CreateMapOverlayModel(
      AgMapControlSafeHandle mapNativeAdapter,
      SafeHandle externalAnimationHandle,
      out AgMapOverlayModelSafeHandle mapOverlayModel)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapOverlayModelAdapter_CreateMapOverlayModel(mapNativeAdapter, externalAnimationHandle, out mapOverlayModel) : Unified.AgMapOverlayModelAdapter_CreateMapOverlayModel(mapNativeAdapter, externalAnimationHandle, out mapOverlayModel);
    }

    public static int AgMapOverlayModelAdapter_AddMapOverlayModel(
      AgMapControlSafeHandle mapNativeAdapter,
      AgMapOverlayModelSafeHandle mapOverlayModel)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapOverlayModelAdapter_AddMapOverlayModel(mapNativeAdapter, mapOverlayModel) : Unified.AgMapOverlayModelAdapter_AddMapOverlayModel(mapNativeAdapter, mapOverlayModel);
    }

    public static int AgMapOverlayModelAdapter_RemoveMapOverlayModel(
      AgMapControlSafeHandle mapNativeAdapter,
      AgMapOverlayModelSafeHandle mapOverlayModel)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapOverlayModelAdapter_RemoveMapOverlayModel(mapNativeAdapter, mapOverlayModel) : Unified.AgMapOverlayModelAdapter_RemoveMapOverlayModel(mapNativeAdapter, mapOverlayModel);
    }

    public static int AgMapControlAdapter_AddRoute(
      AgMapControlSafeHandle nativeAdapter,
      MapRouteSafeHandle nativeMapRoute)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_AddRoute(nativeAdapter, nativeMapRoute) : Unified.AgMapControlAdapter_AddRoute(nativeAdapter, nativeMapRoute);
    }

    public static int AgMapControlAdapter_RemoveRoute(
      AgMapControlSafeHandle nativeAdapter,
      MapRouteSafeHandle nativeMapRoute)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_RemoveRoute(nativeAdapter, nativeMapRoute) : Unified.AgMapControlAdapter_RemoveRoute(nativeAdapter, nativeMapRoute);
    }

    public static int AgMapControlAdapter_AddTileSource(
      AgMapControlSafeHandle nativeAdapter,
      AgTileSourceSafeHandle tileSource)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_AddTileSource(nativeAdapter, tileSource) : Unified.AgMapControlAdapter_AddTileSource(nativeAdapter, tileSource);
    }

    public static int AgMapControlAdapter_RemoveTileSource(
      AgMapControlSafeHandle nativeAdapter,
      AgTileSourceSafeHandle tileSource)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_RemoveTileSource(nativeAdapter, tileSource) : Unified.AgMapControlAdapter_RemoveTileSource(nativeAdapter, tileSource);
    }

    public static int AgMapControlAdapter_OnLoaded(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_OnLoaded(nativeAdapter) : Unified.AgMapControlAdapter_OnLoaded(nativeAdapter);
    }

    public static int AgMapControlAdapter_OnUnloaded(AgMapControlSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgMapControlAdapter_OnUnloaded(nativeAdapter) : Unified.AgMapControlAdapter_OnUnloaded(nativeAdapter);
    }

    public static int AgRouterAdapter_Create(out AgRouterSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_Create(out nativeAdapter) : Unified.AgRouterAdapter_Create(out nativeAdapter);
    }

    public static int AgRouterAdapter_GetInstanceId(AgRouterSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_GetInstanceId(nativeAdapter) : Unified.AgRouterAdapter_GetInstanceId(nativeAdapter);
    }

    public static int AgRouterAdapter_CalculateRoute(
      AgRouterSafeHandle nativeAdapter,
      [MarshalAs(UnmanagedType.LPArray)] MarshaledGeoCoordinates[] waypoints,
      int waypointCount,
      uint travelMode,
      uint routeOptimization,
      int startHeadingInDegrees)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_CalculateRoute(nativeAdapter, waypoints, waypointCount, travelMode, routeOptimization, startHeadingInDegrees) : Unified.AgRouterAdapter_CalculateRoute(nativeAdapter, waypoints, waypointCount, travelMode, routeOptimization, startHeadingInDegrees);
    }

    public static void AgRouterAdapter_Cancel(AgRouterSafeHandle nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgRouterAdapter_Cancel(nativeAdapter);
      else
        Converged.AgRouterAdapter_Cancel(nativeAdapter);
    }

    public static QueryStatus AgRouterAdapter_GetStatus(AgRouterSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_GetStatus(nativeAdapter) : Unified.AgRouterAdapter_GetStatus(nativeAdapter);
    }

    public static int AgRouterAdapter_GetErrorCode(AgRouterSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_GetErrorCode(nativeAdapter) : Unified.AgRouterAdapter_GetErrorCode(nativeAdapter);
    }

    public static int AgRouterAdapter_GetRoute(
      RouteSafeHandle nativeRoute,
      out MarshaledRoute route)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_GetRoute(nativeRoute, out route) : Unified.AgRouterAdapter_GetRoute(nativeRoute, out route);
    }

    public static RouteSafeHandle AgRouterAdapter_GetRouteHandle(
      AgRouterSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_GetRouteHandle(nativeAdapter) : Unified.AgRouterAdapter_GetRouteHandle(nativeAdapter);
    }

    public static void AgRouterAdapter_ProcessDispatchQueue(int id)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgRouterAdapter_ProcessDispatchQueue(id);
      else
        Converged.AgRouterAdapter_ProcessDispatchQueue(id);
    }

    public static int AgRouterAdapter_SetRouterReverseCallbacks(
      RouterReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueEventHandler,
      RouterReverseCallbackDelegates.StatusChangedCallback statusChangedEventHandler)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgRouterAdapter_SetRouterReverseCallbacks(invokeProcessDispatchQueueEventHandler, statusChangedEventHandler) : Unified.AgRouterAdapter_SetRouterReverseCallbacks(invokeProcessDispatchQueueEventHandler, statusChangedEventHandler);
    }

    public static int AgTileSourceAdapter_Create(out AgTileSourceSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_Create(out nativeAdapter) : Unified.AgTileSourceAdapter_Create(out nativeAdapter);
    }

    public static int AgTileSourceAdapter_GetInstanceId(AgTileSourceSafeHandle nativeAdapter)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_GetInstanceId(nativeAdapter) : Unified.AgTileSourceAdapter_GetInstanceId(nativeAdapter);
    }

    public static int AgTileSourceAdapter_SetTileSourceReverseCallbacks(
      TileSourceReverseCallbackDelegates.GetUriCallback getUriCallback)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_SetTileSourceReverseCallbacks(getUriCallback) : Unified.AgTileSourceAdapter_SetTileSourceReverseCallbacks(getUriCallback);
    }

    public static int AgTileSourceAdapter_SetUri(IntPtr buffer, string uri)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_SetUri(buffer, uri) : Unified.AgTileSourceAdapter_SetUri(buffer, uri);
    }

    public static int AgTileSourceAdapter_GetZoomRange(
      AgTileSourceSafeHandle nativeAdapter,
      out int fromZoomLevel,
      out int toZoomLevel)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_GetZoomRange(nativeAdapter, out fromZoomLevel, out toZoomLevel) : Unified.AgTileSourceAdapter_GetZoomRange(nativeAdapter, out fromZoomLevel, out toZoomLevel);
    }

    public static int AgTileSourceAdapter_SetZoomRange(
      AgTileSourceSafeHandle nativeAdapter,
      int fromZoomLevel,
      int toZoomLevel)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_SetZoomRange(nativeAdapter, fromZoomLevel, toZoomLevel) : Unified.AgTileSourceAdapter_SetZoomRange(nativeAdapter, fromZoomLevel, toZoomLevel);
    }

    public static int AgTileSourceAdapter_GetBoundingRectangle(
      AgTileSourceSafeHandle nativeAdapter,
      out MarshaledBoundingRectangle boundingRectangle)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_GetBoundingRectangle(nativeAdapter, out boundingRectangle) : Unified.AgTileSourceAdapter_GetBoundingRectangle(nativeAdapter, out boundingRectangle);
    }

    public static int AgTileSourceAdapter_SetBoundingRectangle(
      AgTileSourceSafeHandle nativeAdapter,
      MarshaledBoundingRectangle boundingRectangle)
    {
      Shim.Init();
      return !Shim.isUnified ? Converged.AgTileSourceAdapter_SetBoundingRectangle(nativeAdapter, boundingRectangle) : Unified.AgTileSourceAdapter_SetBoundingRectangle(nativeAdapter, boundingRectangle);
    }

    public static void AgFinderAdapter_Destroy(IntPtr nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgFinderAdapter_Destroy(nativeAdapter);
      else
        Converged.AgFinderAdapter_Destroy(nativeAdapter);
    }

    public static void AgRouterAdapter_Destroy(IntPtr nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgRouterAdapter_Destroy(nativeAdapter);
      else
        Converged.AgRouterAdapter_Destroy(nativeAdapter);
    }

    public static void AgRouterAdapter_DestroyRoute(IntPtr nativeRoute)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgRouterAdapter_DestroyRoute(nativeRoute);
      else
        Converged.AgRouterAdapter_DestroyRoute(nativeRoute);
    }

    public static void AgMapObject_ReleaseMapObject(IntPtr nativeMapObject)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapObject_ReleaseMapObject(nativeMapObject);
      else
        Converged.AgMapObject_ReleaseMapObject(nativeMapObject);
    }

    public static void AgMapRoute_Destroy(IntPtr nativeMapObject)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapRoute_Destroy(nativeMapObject);
      else
        Converged.AgMapRoute_Destroy(nativeMapObject);
    }

    public static void AgTileSourceAdapter_Destroy(IntPtr nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgTileSourceAdapter_Destroy(nativeAdapter);
      else
        Converged.AgTileSourceAdapter_Destroy(nativeAdapter);
    }

    public static void AgMapOverlayModelAdapter_Destroy(IntPtr nativeAdapter)
    {
      Shim.Init();
      if (Shim.isUnified)
        Unified.AgMapOverlayModelAdapter_Destroy(nativeAdapter);
      else
        Converged.AgMapOverlayModelAdapter_Destroy(nativeAdapter);
    }

    private static void Init()
    {
      if (Shim.isInited)
        return;
      Shim.isUnified = !MapControlCore.UseMosStack();
      Shim.isInited = true;
    }
  }
}
