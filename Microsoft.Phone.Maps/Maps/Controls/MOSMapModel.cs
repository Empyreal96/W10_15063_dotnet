// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MOSMapModel
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using MS.Internal;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MOSMapModel : IMapModel, IDisposable
  {
    private bool disposed;
    private AgMapControlManagedAdapter adapter;
    private TileHostV2 tileHost;
    private Size viewPortSize;
    private Dispatcher dispatcher;
    private Dictionary<IntPtr, MapElement> mapObjectTable = new Dictionary<IntPtr, MapElement>();

    public MOSMapModel(MapCallbacks mapCallbacks, Dispatcher dispatcher)
    {
      try
      {
        this.MapCallbacks = mapCallbacks;
        this.dispatcher = dispatcher;
        this.SetReverseCallbacks();
        TileHostInterfaceInterop.SetTileHostScaleFactor(Application.Current.Host.Content.ActualScaleFactor);
        this.tileHost = new TileHostV2();
        if (Shim.UseUnifiedStack())
          this.tileHost.SetNativeContentProvider("AgMapControlUnified.dll", "AgWebBrowserGetInterface2", "CAgSurfaceProviderAdapter2");
        else
          this.tileHost.SetNativeContentProvider("AgMapControlConverged.dll", "AgWebBrowserGetInterface2", "CAgSurfaceProviderAdapter2");
        double num = 100.0 / (double) Application.Current.Host.Content.ActualScaleFactor;
        ((UIElement) this.tileHost).RenderTransform = (Transform) new ScaleTransform()
        {
          ScaleX = num,
          ScaleY = num
        };
        this.UniqueId = this.tileHost.Id;
        this.Presentation = new MapPresentationContainer((FrameworkElement) this.tileHost);
        this.adapter = new AgMapControlManagedAdapter(this.UniqueId);
        this.adapter.ExternalInputId = this.Presentation.InputInstanceId;
        MapReverseCallbacksThunk.MapInstanceRegistry.Insert(this.UniqueId, (IMapModel) this);
        this.IsInRegistry = true;
        this.InvokeProcessDispatchQueue();
      }
      catch (UnauthorizedAccessException ex)
      {
        throw new UnauthorizedAccessException(Resources.RequireMapCapabilityException);
      }
    }

    ~MOSMapModel() => this.Dispose(false);

    public MapCallbacks MapCallbacks { get; set; }

    public int UniqueId { get; private set; }

    public bool IsInRegistry { get; private set; }

    public Size ViewPortSize
    {
      get => this.viewPortSize;
      set
      {
        this.viewPortSize = value;
        Size size = new Size(Math.Ceiling(DipHelper.ConvertDipToScreenPixel(value.Width)), Math.Ceiling(DipHelper.ConvertDipToScreenPixel(value.Height)));
        this.adapter.ViewPortSize = size;
        this.tileHost.ContentSize = size;
      }
    }

    public GeoCoordinate Center
    {
      get => this.adapter.Center;
      set => this.adapter.Center = value;
    }

    public Point TransformCenter
    {
      get => this.adapter.TransformCenter;
      set => this.adapter.TransformCenter = value;
    }

    public double ZoomLevel
    {
      get => (double) this.adapter.ZoomLevel;
      set => this.adapter.ZoomLevel = (float) value;
    }

    public double Heading
    {
      get => (double) this.adapter.Heading;
      set => this.adapter.Heading = (float) value;
    }

    public double Pitch
    {
      get => (double) this.adapter.Pitch;
      set => this.adapter.Pitch = (float) value;
    }

    public double ActualPitch => (double) this.adapter.ActualPitch;

    public MapCartographicMode CartographicMode
    {
      get => this.adapter.CartographicMode;
      set => this.adapter.CartographicMode = value;
    }

    public MapColorMode ColorMode
    {
      get => this.adapter.ColorMode;
      set => this.adapter.ColorMode = value;
    }

    public bool LandmarksEnabled
    {
      get => this.adapter.LandmarksEnabled;
      set => this.adapter.LandmarksEnabled = value;
    }

    public bool PedestrianFeaturesEnabled
    {
      get => this.adapter.PedestrianFeaturesEnabled;
      set => this.adapter.PedestrianFeaturesEnabled = value;
    }

    public bool WatermarkEnabled
    {
      get => this.adapter.WatermarkEnabled;
      set => this.adapter.WatermarkEnabled = value;
    }

    public MapPresentationContainer Presentation { get; private set; }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void InvokeProcessDispatchQueue() => this.dispatcher.BeginInvoke((Delegate) new MOSMapModel.ProcessDispatcherQueue(this.ProcessQueue), (object[]) null);

    public GeoCoordinate ConvertViewportPointToGeoCoordinate(Point viewportPoint) => this.adapter.PixelToGeo(new Point(DipHelper.ConvertDipToScreenPixel(viewportPoint.X), DipHelper.ConvertDipToScreenPixel(viewportPoint.Y)));

    public Point ConvertGeoCoordinateToViewportPoint(GeoCoordinate geocoordinate)
    {
      Point pixel = this.adapter.GeoToPixel(geocoordinate);
      return new Point(DipHelper.ConvertScreenToDipPixel(pixel.X), DipHelper.ConvertScreenToDipPixel(pixel.Y));
    }

    public void SetView(LocationRectangle boundingRectangle, MapAnimationKind animationKind) => this.adapter.SetView(boundingRectangle, animationKind);

    public void SetView(
      LocationRectangle boundingRectangle,
      Thickness desiredMargins,
      MapAnimationKind animationKind)
    {
      Thickness desiredMarginsInScreenPixel = new Thickness(DipHelper.ConvertDipToScreenPixel(desiredMargins.Left), DipHelper.ConvertDipToScreenPixel(desiredMargins.Top), DipHelper.ConvertDipToScreenPixel(desiredMargins.Right), DipHelper.ConvertDipToScreenPixel(desiredMargins.Bottom));
      this.adapter.SetView(boundingRectangle, desiredMarginsInScreenPixel, animationKind);
    }

    public void SetView(GeoCoordinate center, double zoomLevel, MapAnimationKind animationKind) => this.adapter.SetView(center, (float) zoomLevel, animationKind);

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      MapAnimationKind animationKind)
    {
      this.adapter.SetView(center, (float) zoomLevel, (float) heading, animationKind);
    }

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      double pitch,
      MapAnimationKind animationKind)
    {
      this.adapter.SetView(center, (float) zoomLevel, (float) heading, (float) pitch, animationKind);
    }

    public IList<MapElement> GetMapElementsAt(Point viewportPoint)
    {
      IntPtr[] nativeHandles = new IntPtr[this.mapObjectTable.Count];
      List<MapElement> mapElementList = new List<MapElement>(nativeHandles.Length);
      uint length = (uint) nativeHandles.Length;
      this.adapter.GetMapObjectsAt(new Point(DipHelper.ConvertDipToScreenPixel(viewportPoint.X), DipHelper.ConvertDipToScreenPixel(viewportPoint.Y)), nativeHandles, ref length);
      for (uint index = 0; index < length; ++index)
      {
        if (this.mapObjectTable.ContainsKey(nativeHandles[(int) index]))
        {
          MapElement mapElement = this.mapObjectTable[nativeHandles[(int) index]];
          if (mapElement.Visible)
            mapElementList.Add(mapElement);
        }
      }
      return (IList<MapElement>) mapElementList;
    }

    public void AddMapElement(MapElement mapElement)
    {
      this.mapObjectTable.Add(mapElement.Model.Handle, mapElement);
      this.adapter.AddMapObject((MapObjectAdapter) mapElement.Model.Backend);
    }

    public void RemoveMapElement(MapElement mapElement)
    {
      this.mapObjectTable.Remove(mapElement.Model.Handle);
      this.adapter.RemoveMapObject((MapObjectAdapter) mapElement.Model.Backend);
    }

    public void AddMapOverlay(IMapOverlayModel mapOverlayModel) => this.adapter.AddMapOverlay(mapOverlayModel);

    public void RemoveMapOverlay(IMapOverlayModel mapOverlayModel) => this.adapter.RemoveMapOverlay(mapOverlayModel);

    public void AddRoute(MapRoute mapRoute) => this.adapter.AddRoute(mapRoute);

    public bool RemoveRoute(MapRoute mapRoute) => this.adapter.RemoveRoute(mapRoute);

    public void AddTileSource(ITileSourceModel tileSource) => this.adapter.AddTileSource(((MOSTileSource) tileSource).NativeAdapter);

    public void RemoveTileSource(ITileSourceModel tileSource) => this.adapter.RemoveTileSource(((MOSTileSource) tileSource).NativeAdapter);

    public void CreateSnapshotAsync() => this.adapter.CreateSnapshotAsync();

    public void Invalidate() => this.adapter.Invalidate();

    public void OnLoaded() => this.adapter.OnLoaded();

    public void OnUnloaded() => this.adapter.OnUnloaded();

    protected void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing && this.adapter != null)
        {
          this.adapter.Dispose();
          this.adapter = (AgMapControlManagedAdapter) null;
        }
        if (this.IsInRegistry)
        {
          MapReverseCallbacksThunk.MapInstanceRegistry.Remove(this.UniqueId);
          this.IsInRegistry = false;
        }
      }
      this.disposed = true;
    }

    private void SetReverseCallbacks() => AgMapControlManagedAdapter.SetReverseCallbacks(MapReverseCallbacksThunk.InvokeProcessDispatchQueueEventHandler, MapReverseCallbacksThunk.MapCenterChangedEventHandler, MapReverseCallbacksThunk.MapTransformCenterChangedEventHandler, MapReverseCallbacksThunk.MapZoomLevelChangedEventHandler, MapReverseCallbacksThunk.MapHeadingChangedEventHandler, MapReverseCallbacksThunk.MapPitchChangedEventHandler, MapReverseCallbacksThunk.MapActualPitchChangedEventHandler, MapReverseCallbacksThunk.MapModeChangedEventHandler, MapReverseCallbacksThunk.MapColorModeChangedEventHandler, MapReverseCallbacksThunk.MapLandmarksEnabledChangedEventHandler, MapReverseCallbacksThunk.MapPedestrianFeaturesEnabledChangedEventHandler, MapReverseCallbacksThunk.MapResolvedEventHandler, MapReverseCallbacksThunk.MapViewChangingEventHandler, MapReverseCallbacksThunk.MapViewChangedEventHandler, MapReverseCallbacksThunk.TapEventHandler, MapReverseCallbacksThunk.DoubleTapEventHandler, MapReverseCallbacksThunk.TapAndHoldEventHandler, MapReverseCallbacksThunk.PanEventHandler, MapReverseCallbacksThunk.PinchStretchEventHandler, MapReverseCallbacksThunk.FlickEventHandler, MapReverseCallbacksThunk.SnapshotCreatedEventHandler);

    private void ProcessQueue() => this.adapter.ProcessDispatchQueue();

    private delegate void ProcessDispatcherQueue();
  }
}
