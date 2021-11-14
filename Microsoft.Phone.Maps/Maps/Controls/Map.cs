// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.Map
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Automation.Peers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Controls
{
  [TemplatePart(Name = "PresentationContainer", Type = typeof (Border))]
  public sealed class Map : Control
  {
    public static readonly DependencyProperty CenterProperty = DependencyProperty.Register(nameof (Center), typeof (GeoCoordinate), typeof (Map), new PropertyMetadata((object) MapsSettings.DefaultCenter, new PropertyChangedCallback(Map.OnCenterChanged)));
    public static readonly DependencyProperty TransformCenterProperty = DependencyProperty.Register(nameof (TransformCenter), typeof (Point), typeof (Map), new PropertyMetadata((object) new Point(0.5, 0.5), new PropertyChangedCallback(Map.OnTransformCenterChanged)));
    public static readonly DependencyProperty ZoomLevelProperty = DependencyProperty.Register(nameof (ZoomLevel), typeof (double), typeof (Map), new PropertyMetadata((object) 2.0, new PropertyChangedCallback(Map.OnZoomLevelChanged)));
    public static readonly DependencyProperty HeadingProperty = DependencyProperty.Register(nameof (Heading), typeof (double), typeof (Map), new PropertyMetadata((object) 0.0, new PropertyChangedCallback(Map.OnHeadingChanged)));
    public static readonly DependencyProperty PitchProperty = DependencyProperty.Register(nameof (Pitch), typeof (double), typeof (Map), new PropertyMetadata((object) 0.0, new PropertyChangedCallback(Map.OnPitchChanged)));
    public static readonly DependencyProperty ActualPitchProperty = DependencyProperty.RegisterReadOnly(nameof (ActualPitch), typeof (double), typeof (Map), new PropertyMetadata((object) 0.0));
    public static readonly DependencyProperty CartographicModeProperty = DependencyProperty.Register(nameof (CartographicMode), typeof (MapCartographicMode), typeof (Map), new PropertyMetadata((object) MapCartographicMode.Road, new PropertyChangedCallback(Map.OnCartographicModeChanged)));
    public static readonly DependencyProperty ColorModeProperty = DependencyProperty.Register(nameof (ColorMode), typeof (MapColorMode), typeof (Map), new PropertyMetadata((object) MapColorMode.Light, new PropertyChangedCallback(Map.OnColorModeChanged)));
    public static readonly DependencyProperty LandmarksEnabledProperty = DependencyProperty.Register(nameof (LandmarksEnabled), typeof (bool), typeof (Map), new PropertyMetadata((object) false, new PropertyChangedCallback(Map.OnLandmarksEnabledChanged)));
    public static readonly DependencyProperty PedestrianFeaturesEnabledProperty = DependencyProperty.Register(nameof (PedestrianFeaturesEnabled), typeof (bool), typeof (Map), new PropertyMetadata((object) false, new PropertyChangedCallback(Map.OnPedestrianFeaturesEnabledChanged)));
    public static readonly DependencyProperty WatermarkModeProperty = DependencyProperty.Register(nameof (WatermarkMode), typeof (MapWatermarkMode), typeof (Map), new PropertyMetadata((object) MapWatermarkMode.Default, new PropertyChangedCallback(Map.OnWatermarkModeChanged)));
    private const MapAnimationKind DefaultAnimationKind = MapAnimationKind.Parabolic;
    private const double DefaultZoomLevel = 2.0;
    private const double DefaultHeading = 0.0;
    private const double DefaultPitch = 0.0;
    private const MapCartographicMode DefaultCartographicMode = MapCartographicMode.Road;
    private const MapColorMode DefaultColorMode = MapColorMode.Light;
    private const bool DefaultLandmarksEnabled = false;
    private const bool DefaultPedestrianFeaturesEnabled = false;
    private const MapWatermarkMode DefaultWatermarkMode = MapWatermarkMode.Default;
    private const double MinZoomLevel = 1.0;
    private const double MaxZoomLevel = 20.0;
    private const double MaxHeading = 360.0;
    private const double MinPitch = 0.0;
    private const double MaxPitch = 75.0;
    private const double MinTransformCenter = 0.0;
    private const double MaxTransformCenter = 1.0;
    private static readonly Point DefaultTransformCenter = new Point(0.5, 0.5);
    private readonly MapElementCollectionManager mapElementCollectionManager;
    private readonly RootLayerManager rootLayerManager;
    private readonly RootMapLayer rootLayer;
    private readonly TileSourceCollectionManager tileSourceCollectionManager;
    private readonly Collection<MapElement> mapElements;
    private readonly Collection<MapLayer> layers;
    private readonly Collection<TileSource> tileSources;
    private readonly MapLifetime lifeTime;
    private bool isInReverseCallback;
    private bool shouldIgnoreDependencyPropertyChangedCallback;
    private Border presentationContainer;

    public int UniqueId
    {
      get
      {
        this.CheckThread();
        return this.lifeTime.MapModel.UniqueId;
      }
    }

    [TypeConverter(typeof (GeoCoordinateConverter))]
    public GeoCoordinate Center
    {
      get => (GeoCoordinate) this.GetValue(Map.CenterProperty);
      set => this.SetValue(Map.CenterProperty, (object) value);
    }

    [TypeConverter(typeof (MapPointConverter))]
    public Point TransformCenter
    {
      get => (Point) this.GetValue(Map.TransformCenterProperty);
      set => this.SetValue(Map.TransformCenterProperty, value);
    }

    public double ZoomLevel
    {
      get => (double) this.GetValue(Map.ZoomLevelProperty);
      set => this.SetValue(Map.ZoomLevelProperty, value);
    }

    public double Heading
    {
      get => (double) this.GetValue(Map.HeadingProperty);
      set => this.SetValue(Map.HeadingProperty, value);
    }

    public double Pitch
    {
      get => (double) this.GetValue(Map.PitchProperty);
      set => this.SetValue(Map.PitchProperty, value);
    }

    public double ActualPitch
    {
      get => (double) this.GetValue(Map.ActualPitchProperty);
      private set => this.SetValueInternal(Map.ActualPitchProperty, (object) value, true);
    }

    public MapCartographicMode CartographicMode
    {
      get => (MapCartographicMode) this.GetValue(Map.CartographicModeProperty);
      set => this.SetValue(Map.CartographicModeProperty, (Enum) value);
    }

    public MapColorMode ColorMode
    {
      get => (MapColorMode) this.GetValue(Map.ColorModeProperty);
      set => this.SetValue(Map.ColorModeProperty, (Enum) value);
    }

    public bool LandmarksEnabled
    {
      get => (bool) this.GetValue(Map.LandmarksEnabledProperty);
      set => this.SetValue(Map.LandmarksEnabledProperty, value);
    }

    public bool PedestrianFeaturesEnabled
    {
      get => (bool) this.GetValue(Map.PedestrianFeaturesEnabledProperty);
      set => this.SetValue(Map.PedestrianFeaturesEnabledProperty, value);
    }

    public MapWatermarkMode WatermarkMode
    {
      get => (MapWatermarkMode) this.GetValue(Map.WatermarkModeProperty);
      set => this.SetValue(Map.WatermarkModeProperty, (Enum) value);
    }

    public Collection<MapLayer> Layers
    {
      get
      {
        this.CheckThread();
        return this.layers;
      }
    }

    public Collection<MapElement> MapElements
    {
      get
      {
        this.CheckThread();
        return this.mapElements;
      }
    }

    public Collection<TileSource> TileSources
    {
      get
      {
        this.CheckThread();
        return this.tileSources;
      }
    }

    public GeoCoordinate ConvertViewportPointToGeoCoordinate(Point viewportPoint)
    {
      this.CheckThread();
      if (this.FlowDirection == FlowDirection.RightToLeft)
        viewportPoint.X = this.ActualWidth - viewportPoint.X;
      return this.lifeTime.MapModel.ConvertViewportPointToGeoCoordinate(viewportPoint);
    }

    public Point ConvertGeoCoordinateToViewportPoint(GeoCoordinate geoCoordinate)
    {
      if ((GeoCoordinate) null == geoCoordinate)
        throw new ArgumentNullException(nameof (geoCoordinate));
      this.CheckThread();
      Point viewportPoint = this.lifeTime.MapModel.ConvertGeoCoordinateToViewportPoint(geoCoordinate);
      if (this.FlowDirection == FlowDirection.RightToLeft)
        viewportPoint.X = this.ActualWidth - viewportPoint.X;
      return viewportPoint;
    }

    public void SetView(LocationRectangle boundingRectangle)
    {
      if (boundingRectangle == null)
        throw new ArgumentNullException(nameof (boundingRectangle));
      if (!boundingRectangle.IsValid)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LocationRectangleInvalidException), nameof (boundingRectangle));
      this.SetView(boundingRectangle, MapAnimationKind.Parabolic);
    }

    public void SetView(LocationRectangle boundingRectangle, MapAnimationKind animationKind)
    {
      if (boundingRectangle == null)
        throw new ArgumentNullException(nameof (boundingRectangle));
      if (!boundingRectangle.IsValid)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LocationRectangleInvalidException), nameof (boundingRectangle));
      if (!Enum.IsDefined(typeof (MapAnimationKind), (object) animationKind))
        throw new ArgumentOutOfRangeException(nameof (animationKind), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) animationKind));
      this.CheckThread();
      this.lifeTime.MapModel.SetView(boundingRectangle, animationKind);
    }

    public void SetView(LocationRectangle boundingRectangle, Thickness desiredMargins)
    {
      if (boundingRectangle == null)
        throw new ArgumentNullException(nameof (boundingRectangle));
      if (!boundingRectangle.IsValid)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LocationRectangleInvalidException), nameof (boundingRectangle));
      this.SetView(boundingRectangle, desiredMargins, MapAnimationKind.Parabolic);
    }

    public void SetView(
      LocationRectangle boundingRectangle,
      Thickness desiredMargins,
      MapAnimationKind animationKind)
    {
      if (boundingRectangle == null)
        throw new ArgumentNullException(nameof (boundingRectangle));
      if (!boundingRectangle.IsValid)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LocationRectangleInvalidException), nameof (boundingRectangle));
      if (!Enum.IsDefined(typeof (MapAnimationKind), (object) animationKind))
        throw new ArgumentOutOfRangeException(nameof (animationKind), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) animationKind));
      this.CheckThread();
      this.lifeTime.MapModel.SetView(boundingRectangle, desiredMargins, animationKind);
    }

    public void SetView(GeoCoordinate center, double zoomLevel) => this.SetView(center, zoomLevel, MapAnimationKind.Parabolic);

    public void SetView(GeoCoordinate center, double zoomLevel, MapAnimationKind animationKind)
    {
      if ((GeoCoordinate) null == center)
        throw new ArgumentNullException(nameof (center));
      if (!Map.IsZoomLevelValid(zoomLevel))
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "ZoomLevel", (object) 1.0, (object) 20.0), "ZoomLevel");
      if (!Enum.IsDefined(typeof (MapAnimationKind), (object) animationKind))
        throw new ArgumentOutOfRangeException(nameof (animationKind), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) animationKind));
      this.CheckThread();
      this.lifeTime.MapModel.SetView(center, zoomLevel, animationKind);
    }

    public void SetView(GeoCoordinate center, double zoomLevel, double heading) => this.SetView(center, zoomLevel, heading, MapAnimationKind.Parabolic);

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      MapAnimationKind animationKind)
    {
      if ((GeoCoordinate) null == center)
        throw new ArgumentNullException(nameof (center));
      if (!Map.IsZoomLevelValid(zoomLevel))
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "ZoomLevel", (object) 1.0, (object) 20.0), "ZoomLevel");
      if (!Enum.IsDefined(typeof (MapAnimationKind), (object) animationKind))
        throw new ArgumentOutOfRangeException(nameof (animationKind), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) animationKind));
      this.CheckThread();
      this.lifeTime.MapModel.SetView(center, zoomLevel, Map.NormalizeHeading(heading), animationKind);
    }

    public void SetView(GeoCoordinate center, double zoomLevel, double heading, double pitch) => this.SetView(center, zoomLevel, heading, pitch, MapAnimationKind.Parabolic);

    public void SetView(
      GeoCoordinate center,
      double zoomLevel,
      double heading,
      double pitch,
      MapAnimationKind animationKind)
    {
      if ((GeoCoordinate) null == center)
        throw new ArgumentNullException(nameof (center));
      if (!Map.IsZoomLevelValid(zoomLevel))
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "ZoomLevel", (object) 1.0, (object) 20.0), "ZoomLevel");
      if (!Map.IsPitchValid(pitch))
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "Pitch", (object) 0.0, (object) 75.0), "Pitch");
      if (!Enum.IsDefined(typeof (MapAnimationKind), (object) animationKind))
        throw new ArgumentOutOfRangeException(nameof (animationKind), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) animationKind));
      this.CheckThread();
      this.lifeTime.MapModel.SetView(center, zoomLevel, Map.NormalizeHeading(heading), pitch, animationKind);
    }

    public IList<MapElement> GetMapElementsAt(Point viewportPoint)
    {
      this.CheckThread();
      if (this.FlowDirection == FlowDirection.RightToLeft)
        viewportPoint.X = this.ActualWidth - viewportPoint.X;
      return this.lifeTime.MapModel.GetMapElementsAt(viewportPoint);
    }

    public void AddRoute(MapRoute mapRoute)
    {
      if (mapRoute == null)
        throw new ArgumentNullException(nameof (mapRoute));
      this.CheckThread();
      this.lifeTime.MapModel.AddRoute(mapRoute);
    }

    public bool RemoveRoute(MapRoute mapRoute)
    {
      if (mapRoute == null)
        throw new ArgumentNullException(nameof (mapRoute));
      this.CheckThread();
      return this.lifeTime.MapModel.RemoveRoute(mapRoute);
    }

    internal void CreateSnapshotAsync() => this.lifeTime.MapModel.CreateSnapshotAsync();

    internal void Invalidate() => this.lifeTime.MapModel.Invalidate();

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) new MapAutomationPeer(this);

    [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Justification = "ArgumentNullException will be thrown when the caller sets a null Center")]
    private static void OnCenterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      if (e.NewValue == null)
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentNullException("Center");
      }
      if (map.isInReverseCallback)
        return;
      GeoCoordinate newValue = (GeoCoordinate) e.NewValue;
      if (newValue.IsUnknown)
        return;
      map.lifeTime.MapModel.Center = newValue;
    }

    private static void OnTransformCenterChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      Point newValue = (Point) e.NewValue;
      if (!Map.IsTransformCenterValid(newValue))
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "TransformCenter", (object) 0.0, (object) 1.0), "TransformCenter");
      }
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.TransformCenter = newValue;
    }

    private static void OnZoomLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      double newValue = (double) e.NewValue;
      if (map.isInReverseCallback)
        return;
      if (!Map.IsZoomLevelValid(newValue))
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "ZoomLevel", (object) 1.0, (object) 20.0), "ZoomLevel");
      }
      map.lifeTime.MapModel.ZoomLevel = newValue;
    }

    private static void OnHeadingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback || map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.Heading = Map.NormalizeHeading((double) e.NewValue);
    }

    private static void OnPitchChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      double newValue = (double) e.NewValue;
      if (!Map.IsPitchValid(newValue))
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "Pitch", (object) 0.0, (object) 75.0), "Pitch");
      }
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.Pitch = newValue;
    }

    private static void OnCartographicModeChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      if (!Enum.IsDefined(typeof (MapCartographicMode), (object) (MapCartographicMode) e.NewValue))
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentOutOfRangeException("CartographicMode", string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) (int) e.NewValue));
      }
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.CartographicMode = (MapCartographicMode) e.NewValue;
    }

    private static void OnColorModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      if (!Enum.IsDefined(typeof (MapColorMode), (object) (MapColorMode) e.NewValue))
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentOutOfRangeException("ColorMode", string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) (int) e.NewValue));
      }
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.ColorMode = (MapColorMode) e.NewValue;
    }

    private static void OnLandmarksEnabledChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.LandmarksEnabled = (bool) e.NewValue;
    }

    private static void OnPedestrianFeaturesEnabledChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.PedestrianFeaturesEnabled = (bool) e.NewValue;
    }

    private static void OnWatermarkModeChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Map map = (Map) d;
      if (map.shouldIgnoreDependencyPropertyChangedCallback)
        return;
      if (!Enum.IsDefined(typeof (MapWatermarkMode), (object) (MapWatermarkMode) e.NewValue))
      {
        map.shouldIgnoreDependencyPropertyChangedCallback = true;
        map.SetValue(e.Property, e.OldValue);
        map.shouldIgnoreDependencyPropertyChangedCallback = false;
        throw new ArgumentOutOfRangeException("WatermarkMode", string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) (int) e.NewValue));
      }
      if (map.isInReverseCallback)
        return;
      map.lifeTime.MapModel.WatermarkEnabled = (MapWatermarkMode) e.NewValue == MapWatermarkMode.On;
    }

    private static bool IsZoomLevelValid(double zoomLevel) => zoomLevel >= 1.0 && zoomLevel <= 20.0;

    private static double NormalizeHeading(double heading)
    {
      double num = heading % 360.0;
      if (num < 0.0)
        num += 360.0;
      return num;
    }

    private static bool IsPitchValid(double pitch) => pitch >= 0.0 && pitch <= 75.0;

    private static bool IsTransformCenterValid(Point transformCenter) => transformCenter.X >= 0.0 && transformCenter.X <= 1.0 && transformCenter.Y >= 0.0 && transformCenter.Y <= 1.0;

    private void CheckThread()
    {
      if (!this.Dispatcher.CheckAccess())
        throw new UnauthorizedAccessException(Resources.ThreadAccessException);
    }

    public event EventHandler<MapCenterChangedEventArgs> CenterChanged;

    public event EventHandler<MapTransformCenterChangedEventArgs> TransformCenterChanged;

    public event EventHandler<MapZoomLevelChangedEventArgs> ZoomLevelChanged;

    public event EventHandler<MapHeadingChangedEventArgs> HeadingChanged;

    public event EventHandler<MapPitchChangedEventArgs> PitchChanged;

    public event EventHandler<MapCartographicModeChangedEventArgs> CartographicModeChanged;

    public event EventHandler<MapColorModeChangedEventArgs> ColorModeChanged;

    public event EventHandler<MapLandmarksEnabledChangedEventArgs> LandmarksEnabledChanged;

    public event EventHandler<MapPedestrianFeaturesEnabledChangedEventArgs> PedestrianFeaturesEnabledChanged;

    public event EventHandler<MapViewChangingEventArgs> ViewChanging;

    public event EventHandler<MapViewChangedEventArgs> ViewChanged;

    public event EventHandler<MapResolveCompletedEventArgs> ResolveCompleted;

    internal event EventHandler<TapMapGestureEventArgs> TestTap;

    internal event EventHandler<DoubleTapMapGestureEventArgs> TestDoubleTap;

    internal event EventHandler<TapAndHoldMapGestureEventArgs> TestHold;

    internal event EventHandler<PanMapGestureEventArgs> TestPan;

    internal event EventHandler<PinchStretchMapGestureEventArgs> TestPinchStretch;

    internal event EventHandler<FlickMapGestureEventArgs> TestFlick;

    internal event EventHandler<CreateSnapshotCompletedEventArgs> CreateSnapshotCompleted;

    private void FireCenterChangedEvent(GeoCoordinate center)
    {
      this.isInReverseCallback = true;
      this.Center = center;
      this.isInReverseCallback = false;
      if (this.CenterChanged == null)
        return;
      this.CenterChanged((object) this, MapCenterChangedEventArgs.EmptyEventArgs);
    }

    private void FireTransformCenterChangedEvent(Point point)
    {
      this.isInReverseCallback = true;
      this.TransformCenter = point;
      this.isInReverseCallback = false;
      if (this.TransformCenterChanged == null)
        return;
      this.TransformCenterChanged((object) this, MapTransformCenterChangedEventArgs.EmptyEventArgs);
    }

    private void FireZoomLevelChangedEvent(double zoomLevel)
    {
      this.isInReverseCallback = true;
      this.ZoomLevel = zoomLevel;
      this.isInReverseCallback = false;
      if (this.ZoomLevelChanged == null)
        return;
      this.ZoomLevelChanged((object) this, MapZoomLevelChangedEventArgs.EmptyEventArgs);
    }

    private void FireHeadingChangedEvent(double heading)
    {
      this.isInReverseCallback = true;
      this.Heading = heading;
      this.isInReverseCallback = false;
      if (this.HeadingChanged == null)
        return;
      this.HeadingChanged((object) this, MapHeadingChangedEventArgs.EmptyEventArgs);
    }

    private void FirePitchChangedEvent(double pitch)
    {
      this.isInReverseCallback = true;
      this.Pitch = pitch;
      this.isInReverseCallback = false;
    }

    private void FireActualPitchChangedEvent(double pitch)
    {
      this.ActualPitch = pitch;
      if (this.PitchChanged == null)
        return;
      this.PitchChanged((object) this, MapPitchChangedEventArgs.EmptyEventArgs);
    }

    private void FireCartographicModeChangedEvent(MapCartographicMode mode)
    {
      this.isInReverseCallback = true;
      this.CartographicMode = mode;
      this.isInReverseCallback = false;
      if (this.CartographicModeChanged == null)
        return;
      this.CartographicModeChanged((object) this, MapCartographicModeChangedEventArgs.EmptyEventArgs);
    }

    private void FireColorModeChangedEvent(MapColorMode mode)
    {
      this.isInReverseCallback = true;
      this.ColorMode = mode;
      this.isInReverseCallback = false;
      if (this.ColorModeChanged == null)
        return;
      this.ColorModeChanged((object) this, MapColorModeChangedEventArgs.EmptyEventArgs);
    }

    private void FireLandmarksEnabledChangedEvent(bool visible)
    {
      this.isInReverseCallback = true;
      this.LandmarksEnabled = visible;
      this.isInReverseCallback = false;
      if (this.LandmarksEnabledChanged == null)
        return;
      this.LandmarksEnabledChanged((object) this, MapLandmarksEnabledChangedEventArgs.EmptyEventArgs);
    }

    private void FirePedestrianFeaturesEnabledChangedEvent(bool visible)
    {
      this.isInReverseCallback = true;
      this.PedestrianFeaturesEnabled = visible;
      this.isInReverseCallback = false;
      if (this.PedestrianFeaturesEnabledChanged == null)
        return;
      this.PedestrianFeaturesEnabledChanged((object) this, MapPedestrianFeaturesEnabledChangedEventArgs.EmptyEventArgs);
    }

    private void FireViewChangingEvent()
    {
      if (this.ViewChanging == null)
        return;
      this.ViewChanging((object) this, MapViewChangingEventArgs.EmptyEventArgs);
    }

    private void FireViewChangedEvent(bool canceled)
    {
      if (this.ViewChanged == null)
        return;
      this.ViewChanged((object) this, new MapViewChangedEventArgs(canceled));
    }

    private void FireResolveCompletedEvent()
    {
      if (this.ResolveCompleted == null)
        return;
      this.ResolveCompleted((object) this, MapResolveCompletedEventArgs.EmptyEventArgs);
    }

    private void FireCreateSnapshotCompleted(Exception error, WriteableBitmap bitmap)
    {
      if (this.CreateSnapshotCompleted == null)
        return;
      if (bitmap != null)
        this.CreateSnapshotCompleted((object) this, new CreateSnapshotCompletedEventArgs(bitmap, (object) null));
      else
        this.CreateSnapshotCompleted((object) this, new CreateSnapshotCompletedEventArgs(error, false, (object) null));
    }

    private void FireTap(Point point)
    {
      if (this.TestTap == null)
        return;
      this.TestTap((object) this, new TapMapGestureEventArgs(point));
    }

    private void FireDoubleTap(Point point)
    {
      if (this.TestDoubleTap == null)
        return;
      this.TestDoubleTap((object) this, new DoubleTapMapGestureEventArgs(point));
    }

    private void FireTapAndHold(Point point)
    {
      if (this.TestHold == null)
        return;
      this.TestHold((object) this, new TapAndHoldMapGestureEventArgs(point));
    }

    private void FirePan(Point from, Point to)
    {
      if (this.TestPan == null)
        return;
      this.TestPan((object) this, new PanMapGestureEventArgs(from, to));
    }

    private void FirePinchStretch(Point center, float scale)
    {
      if (this.TestPinchStretch == null)
        return;
      this.TestPinchStretch((object) this, new PinchStretchMapGestureEventArgs(center, scale));
    }

    private void FireFlick(Point velocity)
    {
      if (this.TestFlick == null)
        return;
      this.TestFlick((object) this, new FlickMapGestureEventArgs(velocity));
    }

    public Map()
    {
      this.LoadTemplate();
      int mapVersion = (int) this.MapVersion;
      MapCallbacks mapInteropCallbacks = new MapCallbacks();
      mapInteropCallbacks.CenterChangedEventHandler = new MapCallbackDelegates.CenterChanged(this.FireCenterChangedEvent);
      mapInteropCallbacks.TransformCenterChangedEventHandler = new MapCallbackDelegates.TransformCenterChanged(this.FireTransformCenterChangedEvent);
      mapInteropCallbacks.ZoomLevelChangedEventHandler = new MapCallbackDelegates.ZoomLevelChanged(this.FireZoomLevelChangedEvent);
      mapInteropCallbacks.HeadingChangedEventHandler = new MapCallbackDelegates.HeadingChanged(this.FireHeadingChangedEvent);
      mapInteropCallbacks.PitchChangedEventHandler = new MapCallbackDelegates.PitchChanged(this.FirePitchChangedEvent);
      mapInteropCallbacks.ActualPitchChangedEventHandler = new MapCallbackDelegates.ActualPitchChanged(this.FireActualPitchChangedEvent);
      mapInteropCallbacks.CartographicModeChangedEventHandler = new MapCallbackDelegates.CartographicModeChanged(this.FireCartographicModeChangedEvent);
      mapInteropCallbacks.ColorModeChangedEventHandler = new MapCallbackDelegates.ColorModeChanged(this.FireColorModeChangedEvent);
      mapInteropCallbacks.LandmarksEnabledChangedEventHandler = new MapCallbackDelegates.LandmarksEnabledChanged(this.FireLandmarksEnabledChangedEvent);
      mapInteropCallbacks.PedestrianFeaturesEnabledChangedEventHandler = new MapCallbackDelegates.PedestrianFeaturesEnabledChanged(this.FirePedestrianFeaturesEnabledChangedEvent);
      mapInteropCallbacks.ResolveCompletedEventHandler = new MapCallbackDelegates.ResolveCompleted(this.FireResolveCompletedEvent);
      mapInteropCallbacks.ViewChangingEventHandler = new MapCallbackDelegates.ViewChanging(this.FireViewChangingEvent);
      mapInteropCallbacks.ViewChangedEventHandler = new MapCallbackDelegates.ViewChanged(this.FireViewChangedEvent);
      mapInteropCallbacks.TapEventHandler = new MapCallbackDelegates.Tap(this.FireTap);
      mapInteropCallbacks.DoubleTapEventHandler = new MapCallbackDelegates.DoubleTap(this.FireDoubleTap);
      mapInteropCallbacks.TapAndHoldEventHandler = new MapCallbackDelegates.TapAndHold(this.FireTapAndHold);
      mapInteropCallbacks.PanEventHandler = new MapCallbackDelegates.Pan(this.FirePan);
      mapInteropCallbacks.PinchStretchEventHandler = new MapCallbackDelegates.PinchStretch(this.FirePinchStretch);
      mapInteropCallbacks.FlickEventHandler = new MapCallbackDelegates.Flick(this.FireFlick);
      mapInteropCallbacks.SnapshotCreatedEventHandler = new MapCallbackDelegates.SnapshotCreated(this.FireCreateSnapshotCompleted);
      Dispatcher dispatcher = this.Dispatcher;
      this.lifeTime = MapCompatibility.GetLifetimeManager((MapVersion) mapVersion, (Control) this, mapInteropCallbacks, dispatcher);
      this.Loaded += new RoutedEventHandler(this.OnLoaded);
      this.Unloaded += new RoutedEventHandler(this.OnUnloaded);
      this.SizeChanged += new SizeChangedEventHandler(this.OnControlSizeChanged);
      this.mapElementCollectionManager = new MapElementCollectionManager(this.lifeTime.MapModel);
      ObservableCollection<MapElement> observableCollection1 = new ObservableCollection<MapElement>();
      // ISSUE: method pointer
      observableCollection1.CollectionChanged += new NotifyCollectionChangedEventHandler((object) this.mapElementCollectionManager, __methodptr(CollectionChanged));
      this.mapElements = (Collection<MapElement>) observableCollection1;
      this.rootLayer = new RootMapLayer();
      this.rootLayerManager = new RootLayerManager(this, this.rootLayer.Children, this.lifeTime.MapModel);
      ObservableCollection<MapLayer> observableCollection2 = new ObservableCollection<MapLayer>();
      // ISSUE: method pointer
      observableCollection2.CollectionChanged += new NotifyCollectionChangedEventHandler((object) this.rootLayerManager, __methodptr(CollectionChanged));
      this.layers = (Collection<MapLayer>) observableCollection2;
      this.tileSourceCollectionManager = new TileSourceCollectionManager(this.lifeTime.MapModel);
      ObservableCollection<TileSource> observableCollection3 = new ObservableCollection<TileSource>();
      // ISSUE: method pointer
      observableCollection3.CollectionChanged += new NotifyCollectionChangedEventHandler((object) this.tileSourceCollectionManager, __methodptr(CollectionChanged));
      this.tileSources = (Collection<TileSource>) observableCollection3;
    }

    private MapVersion MapVersion => MapVersion.V8;

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      this.presentationContainer = (Border) this.GetTemplateChild("PresentationContainer");
      this.lifeTime.OnApplyTemplate(this.presentationContainer);
      ((MapPresentationContainer) this.presentationContainer.Child).AddChildren((UIElement) this.rootLayer);
    }

    private void LoadTemplate() => this.Template = XamlReader.Load("<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' TargetType='Control'> <Border x:Name='StateContainer'   Background='{TemplateBinding Background}'   BorderBrush='{TemplateBinding BorderBrush}'   BorderThickness='{TemplateBinding BorderThickness}'   Opacity='1'> <Border   x:Name='PresentationContainer'   FlowDirection='LeftToRight'> </Border> </Border> </ControlTemplate>") as ControlTemplate;

    private bool ValidateDefaultValues() => this.Center == this.lifeTime.MapModel.Center && this.TransformCenter == this.lifeTime.MapModel.TransformCenter && (this.TransformCenter == Map.DefaultTransformCenter && this.ZoomLevel == this.lifeTime.MapModel.ZoomLevel) && (this.Heading == this.lifeTime.MapModel.Heading && this.Pitch == this.lifeTime.MapModel.Pitch && (this.CartographicMode == this.lifeTime.MapModel.CartographicMode && this.ColorMode == this.lifeTime.MapModel.ColorMode)) && this.LandmarksEnabled == this.lifeTime.MapModel.LandmarksEnabled && this.PedestrianFeaturesEnabled == this.lifeTime.MapModel.PedestrianFeaturesEnabled;

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
      this.ApplyTemplate();
      this.lifeTime.OnLoaded(this.presentationContainer);
      this.lifeTime.MapModel.OnLoaded();
      this.Dispatcher.BeginInvoke((Action) (() => this.lifeTime.OnAfterLoaded()));
    }

    [SuppressMessage("Microsoft.Reliability", "CA2001:Avoid calling problematic methods", Justification = "GC.Collect is being called deliberately")]
    private void OnUnloaded(object sender, RoutedEventArgs e)
    {
      this.lifeTime.OnUnloaded();
      this.lifeTime.MapModel.OnUnloaded();
      this.Dispatcher.BeginInvoke((Action) (() => GC.Collect()));
    }

    private void OnControlSizeChanged(object sender, SizeChangedEventArgs e)
    {
      this.lifeTime.MapModel.ViewPortSize = e.NewSize;
      RectangleGeometry rectangleGeometry1 = new RectangleGeometry();
      RectangleGeometry rectangleGeometry2 = rectangleGeometry1;
      Size newSize = e.NewSize;
      double width = newSize.Width;
      newSize = e.NewSize;
      double height = newSize.Height;
      Rect rect = new Rect(0.0, 0.0, width, height);
      rectangleGeometry2.Rect = rect;
      this.rootLayer.Clip = (Geometry) rectangleGeometry1;
    }
  }
}
