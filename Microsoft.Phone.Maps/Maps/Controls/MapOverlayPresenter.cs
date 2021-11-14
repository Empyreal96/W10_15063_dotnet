// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapOverlayPresenter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.ComponentModel;
using System.Device.Location;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Microsoft.Phone.Maps.Controls
{
  internal sealed class MapOverlayPresenter : ContentPresenter
  {
    public static readonly DependencyProperty PositionOriginProperty = DependencyProperty.Register(nameof (PositionOrigin), typeof (Point), typeof (MapOverlayPresenter), new PropertyMetadata(new PropertyChangedCallback(MapOverlayPresenter.OnPositionOriginChanged)));
    public static readonly DependencyProperty GeoCoordinateProperty = DependencyProperty.Register(nameof (GeoCoordinate), typeof (GeoCoordinate), typeof (MapOverlayPresenter), new PropertyMetadata(new PropertyChangedCallback(MapOverlayPresenter.OnGeoCoordinateChanged)));
    public static readonly DependencyProperty OverlayContentProperty = DependencyProperty.Register(nameof (OverlayContent), typeof (object), typeof (MapOverlayPresenter), new PropertyMetadata((PropertyChangedCallback) null));
    public static readonly DependencyProperty OverlayContentTemplateProperty = DependencyProperty.Register(nameof (OverlayContentTemplate), typeof (DataTemplate), typeof (MapOverlayPresenter), new PropertyMetadata((PropertyChangedCallback) null));
    private static int externalAnimationId = 0;
    private int id;
    private ContentPresenter childContentPresenter;

    public MapOverlayPresenter()
    {
      this.AcquireExternalAnimationModel();
      this.Loaded += new RoutedEventHandler(this.OnLoaded);
      this.Unloaded += new RoutedEventHandler(this.OnUnloaded);
      this.SizeChanged += new SizeChangedEventHandler(this.OnMapOverlaySizeChanged);
      this.SetupChildContentPresenter();
      this.Content = (object) this.childContentPresenter;
    }

    ~MapOverlayPresenter() => this.OnBeforeUnLoaded();

    public Point PositionOrigin
    {
      get => (Point) this.GetValue(MapOverlayPresenter.PositionOriginProperty);
      set => this.SetValue(MapOverlayPresenter.PositionOriginProperty, value);
    }

    [TypeConverter(typeof (GeoCoordinateConverter))]
    public GeoCoordinate GeoCoordinate
    {
      get => (GeoCoordinate) this.GetValue(MapOverlayPresenter.GeoCoordinateProperty);
      set => this.SetValue(MapOverlayPresenter.GeoCoordinateProperty, (object) value);
    }

    public object OverlayContent
    {
      get => this.GetValue(MapOverlayPresenter.OverlayContentProperty);
      set => this.SetValue(MapOverlayPresenter.OverlayContentProperty, value);
    }

    public object OverlayContentTemplate
    {
      get => this.GetValue(MapOverlayPresenter.OverlayContentTemplateProperty);
      set => this.SetValue(MapOverlayPresenter.OverlayContentTemplateProperty, value);
    }

    internal IMapOverlayModel Model { get; set; }

    internal bool IsPresenterLoaded { get; private set; }

    public void OnBeforeUnLoaded()
    {
      if (this.IsPresenterLoaded)
        this.Model.OnLeavingVisual();
      this.IsPresenterLoaded = false;
    }

    public void SetupMapBindings(Map map) => BindingOperations.SetBinding((DependencyObject) this.childContentPresenter, FrameworkElement.FlowDirectionProperty, (BindingBase) new Binding()
    {
      Source = (object) map,
      Mode = BindingMode.OneWay,
      Path = new PropertyPath("FlowDirection", new object[0])
    });

    internal static bool IsValueNormalized(double value) => value >= 0.0 && value <= 1.0;

    private static void OnPositionOriginChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Point newValue = (Point) e.NewValue;
      ((MapOverlayPresenter) d).UpdateActualPositionOrigin(newValue);
    }

    private static void OnGeoCoordinateChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      MapOverlayPresenter overlayPresenter = (MapOverlayPresenter) d;
      GeoCoordinate newValue = e.NewValue as GeoCoordinate;
      if (newValue != (GeoCoordinate) null)
        overlayPresenter.Model.GeoCoordinate = newValue;
      else
        overlayPresenter.Model.GeoCoordinate = GeoCoordinate.Unknown;
    }

    private void SetupChildContentPresenter()
    {
      this.childContentPresenter = new ContentPresenter();
      this.SetupChildPresenterBindings();
    }

    private void SetupChildPresenterBindings()
    {
      this.SetupChildPresenterBinding("OverlayContent", ContentPresenter.ContentProperty);
      this.SetupChildPresenterBinding("OverlayContentTemplate", ContentPresenter.ContentTemplateProperty);
    }

    private void SetupChildPresenterBinding(
      string sourcePropertyPath,
      DependencyProperty targetProperty)
    {
      Binding binding = new Binding()
      {
        Source = (object) this,
        Mode = BindingMode.OneWay,
        Path = new PropertyPath(sourcePropertyPath, new object[0])
      };
      BindingOperations.SetBinding((DependencyObject) this.childContentPresenter, targetProperty, (BindingBase) binding);
    }

    private void AcquireExternalAnimationModel()
    {
      IntPtr zero = IntPtr.Zero;
      this.id = Interlocked.Add(ref MapOverlayPresenter.externalAnimationId, 1);
      IntPtr animationElement = this.GetExternalAnimationElement((uint) this.id);
      if (animationElement == IntPtr.Zero)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidExternalAnimationHandle));
      this.Model = (IMapOverlayModel) new MOSMapOverlayModel();
      this.Model.AnimationHandle = (SafeHandle) new ExternalAnimationHandle(animationElement);
    }

    private void UpdateActualPositionOrigin(Point positionOrigin) => this.Model.PositionOrigin = new Point(positionOrigin.X * this.ActualWidth, positionOrigin.Y * this.ActualHeight);

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
      this.Model.OnEnterVisualTree();
      this.IsPresenterLoaded = true;
    }

    private void OnUnloaded(object sender, RoutedEventArgs e) => this.OnBeforeUnLoaded();

    private void OnMapOverlaySizeChanged(object sender, SizeChangedEventArgs e) => this.UpdateActualPositionOrigin(this.PositionOrigin);
  }
}
