// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapModelNoUI
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Collections.Generic;
using System.Device.Location;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapModelNoUI : IMapModel
  {
    private static int idSeed;
    private Dispatcher dispatcher;

    public MapModelNoUI(MapCallbacks mapCallbacks, Dispatcher dispatcher)
    {
      this.MapCallbacks = mapCallbacks;
      this.dispatcher = dispatcher;
      this.UniqueId = Interlocked.Add(ref MapModelNoUI.idSeed, 1);
      MapReverseCallbacksThunk.MapInstanceRegistry.Insert(this.UniqueId, (IMapModel) this);
      this.IsInRegistry = true;
    }

    ~MapModelNoUI()
    {
      if (!this.IsInRegistry)
        return;
      MapReverseCallbacksThunk.MapInstanceRegistry.Remove(this.UniqueId);
      this.IsInRegistry = false;
    }

    public int UniqueId { get; private set; }

    public Size ViewPortSize { get; set; }

    public GeoCoordinate Center { get; set; }

    public Point TransformCenter { get; set; }

    public double ZoomLevel { get; set; }

    public double Heading { get; set; }

    public double Pitch { get; set; }

    public double ActualPitch => 0.0;

    public MapCartographicMode CartographicMode { get; set; }

    public MapColorMode ColorMode { get; set; }

    public bool LandmarksEnabled { get; set; }

    public bool PedestrianFeaturesEnabled { get; set; }

    public bool WatermarkEnabled { get; set; }

    public MapPresentationContainer Presentation => (MapPresentationContainer) null;

    public MapCallbacks MapCallbacks { get; set; }

    public bool IsInRegistry { get; private set; }

    public void InvokeProcessDispatchQueue()
    {
    }

    public GeoCoordinate ConvertViewportPointToGeoCoordinate(Point viewportPoint) => new GeoCoordinate(0.0, 0.0);

    public Point ConvertGeoCoordinateToViewportPoint(GeoCoordinate geocoordinate) => new Point();

    public void SetView(LocationRectangle boundingRectangle, MapAnimationKind animationKind)
    {
    }

    public void SetView(
      LocationRectangle boundingRectangle,
      Thickness desiredMargins,
      MapAnimationKind animationKind)
    {
    }

    public void SetView(GeoCoordinate center, double zoomLevel, MapAnimationKind animationKind)
    {
    }

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      MapAnimationKind animationKind)
    {
    }

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      double pitch,
      MapAnimationKind animationKind)
    {
    }

    public void CreateSnapshotAsync()
    {
    }

    public void Invalidate()
    {
    }

    public void OnLoaded()
    {
    }

    public void OnUnloaded()
    {
    }

    public void AddRoute(MapRoute mapRoute)
    {
    }

    public bool RemoveRoute(MapRoute mapRoute) => true;

    public void AddMapElement(MapElement mapObject)
    {
    }

    public void RemoveMapElement(MapElement mapObject)
    {
    }

    public IList<MapElement> GetMapElementsAt(Point viewportPoint) => (IList<MapElement>) new List<MapElement>();

    public void AddTileSource(ITileSourceModel tileSource)
    {
    }

    public void RemoveTileSource(ITileSourceModel tileSource)
    {
    }

    public void AddMapOverlay(IMapOverlayModel overlayAnimationModel)
    {
    }

    public void RemoveMapOverlay(IMapOverlayModel overlayAnimationModel)
    {
    }
  }
}
