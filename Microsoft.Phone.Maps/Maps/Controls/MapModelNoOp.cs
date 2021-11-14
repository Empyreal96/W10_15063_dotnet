// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapModelNoOp
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapModelNoOp : IMapModel
  {
    private FakeTileHost tileHost;
    private MapPresentationContainer mapPresentationContainer;
    private ManipulationHandler inputHandler;
    private Dispatcher dispatcher;
    private List<MapModelNoOp.DispatcherQueueItem> dispatcherQueue = new List<MapModelNoOp.DispatcherQueueItem>();

    public MapModelNoOp(MapCallbacks mapCallbacks, Dispatcher dispatcher)
    {
      this.MapCallbacks = mapCallbacks;
      this.dispatcher = dispatcher;
      this.tileHost = new FakeTileHost();
      this.UniqueId = this.tileHost.Id;
      this.mapPresentationContainer = new MapPresentationContainer((FrameworkElement) this.tileHost);
      MapReverseCallbacksThunk.MapInstanceRegistry.Insert(this.UniqueId, (IMapModel) this);
      this.IsInRegistry = true;
      this.SetInputEvents();
    }

    ~MapModelNoOp()
    {
      if (!this.IsInRegistry)
        return;
      MapReverseCallbacksThunk.MapInstanceRegistry.Remove(this.UniqueId);
      this.IsInRegistry = false;
    }

    public int UniqueId { get; private set; }

    public Size ViewPortSize
    {
      get => this.tileHost.ContentSize;
      set => this.tileHost.ContentSize = value;
    }

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

    public MapPresentationContainer Presentation => this.mapPresentationContainer;

    public MapCallbacks MapCallbacks { get; set; }

    public bool IsInRegistry { get; private set; }

    public void InvokeProcessDispatchQueue() => this.dispatcher.BeginInvoke((Delegate) new MapModelNoOp.ProcessDispatcherQueue(this.ProcessQueue), (object[]) null);

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

    private void SetInputEvents()
    {
      this.inputHandler = new ManipulationHandler((UIElement) this.mapPresentationContainer);
      this.inputHandler.Tap += new EventHandler<GestureEventArgs>(this.OnTap);
      this.inputHandler.DoubleTap += new EventHandler<GestureEventArgs>(this.OnDoubleTap);
      this.inputHandler.TapAndHold += new EventHandler<GestureEventArgs>(this.OnTapAndHold);
      this.inputHandler.Pan += new EventHandler<GestureEventArgs>(this.OnPan);
      this.inputHandler.Pinch += new EventHandler<GestureEventArgs>(this.OnPinchStretch);
      this.inputHandler.Flick += new EventHandler<GestureEventArgs>(this.OnFlick);
      this.inputHandler.GestureEnded += new EventHandler<GestureEndedEventArgs>(this.OnGestureEnded);
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnTap(object sender, GestureEventArgs e)
    {
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnDoubleTap(object sender, GestureEventArgs e)
    {
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnTapAndHold(object sender, GestureEventArgs e)
    {
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnPan(object sender, GestureEventArgs e)
    {
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnPinchStretch(object sender, GestureEventArgs e)
    {
      ScaleGestureEventArgs gestureEventArgs = (ScaleGestureEventArgs) e;
      Convert.ToInt32(Math.Floor(gestureEventArgs.ScaleCumulativeDelta.X * 100.0));
      Point point = gestureEventArgs.ScaleCumulativeDelta;
      double x1 = point.X;
      point = gestureEventArgs.ScaleDelta;
      double x2 = point.X;
      Convert.ToInt32(Math.Floor(x1 / x2 * 100.0));
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnFlick(object sender, GestureEventArgs e)
    {
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void OnGestureEnded(object sender, GestureEndedEventArgs e)
    {
    }

    private void ProcessQueue()
    {
      foreach (Delegate dispatcher in this.dispatcherQueue)
        dispatcher.DynamicInvoke((object[]) null);
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void DispatcherQueueMapCenterChanged() => this.MapCallbacks.CenterChangedEventHandler(new GeoCoordinate());

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void DispatcherQueueMapResolved() => this.MapCallbacks.ResolveCompletedEventHandler();

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Test code, leaving it in in case we need it")]
    private void DispatcherQueueZoomLevelChanged() => this.MapCallbacks.ZoomLevelChangedEventHandler(0.0);

    private delegate void DispatcherQueueItem();

    private delegate void ProcessDispatcherQueue();
  }
}
