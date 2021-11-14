// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.IMapModel
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Collections.Generic;
using System.Device.Location;
using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  internal interface IMapModel
  {
    MapCallbacks MapCallbacks { get; set; }

    int UniqueId { get; }

    bool IsInRegistry { get; }

    Size ViewPortSize { get; set; }

    GeoCoordinate Center { get; set; }

    Point TransformCenter { get; set; }

    double ZoomLevel { get; set; }

    double Heading { get; set; }

    double Pitch { get; set; }

    double ActualPitch { get; }

    MapCartographicMode CartographicMode { get; set; }

    MapColorMode ColorMode { get; set; }

    bool LandmarksEnabled { get; set; }

    bool PedestrianFeaturesEnabled { get; set; }

    bool WatermarkEnabled { get; set; }

    MapPresentationContainer Presentation { get; }

    void InvokeProcessDispatchQueue();

    GeoCoordinate ConvertViewportPointToGeoCoordinate(Point viewportPoint);

    Point ConvertGeoCoordinateToViewportPoint(GeoCoordinate geoCoordinate);

    void SetView(LocationRectangle boundingRectangle, MapAnimationKind animationKind);

    void SetView(
      LocationRectangle boundingRectangle,
      Thickness desiredMargins,
      MapAnimationKind animationKind);

    void SetView(GeoCoordinate center, double zoomLevel, MapAnimationKind animationKind);

    void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      MapAnimationKind animationKind);

    void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      double pitch,
      MapAnimationKind animationKind);

    IList<MapElement> GetMapElementsAt(Point viewportPoint);

    void AddMapElement(MapElement mapObject);

    void RemoveMapElement(MapElement mapObject);

    void AddMapOverlay(IMapOverlayModel overlayAnimationModel);

    void RemoveMapOverlay(IMapOverlayModel overlayAnimationModel);

    void AddRoute(MapRoute mapRoute);

    bool RemoveRoute(MapRoute mapRoute);

    void AddTileSource(ITileSourceModel tileSource);

    void RemoveTileSource(ITileSourceModel tileSource);

    void CreateSnapshotAsync();

    void Invalidate();

    void OnLoaded();

    void OnUnloaded();
  }
}
