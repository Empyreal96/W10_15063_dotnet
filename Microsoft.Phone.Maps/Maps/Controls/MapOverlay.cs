// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapOverlay
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.ComponentModel;
using System.Device.Location;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Microsoft.Phone.Maps.Controls
{
  [System.Windows.Markup.ContentProperty("Content")]
  public sealed class MapOverlay : DependencyObject
  {
    public static readonly DependencyProperty PositionOriginProperty = DependencyProperty.Register(nameof (PositionOrigin), typeof (Point), typeof (MapOverlay), new PropertyMetadata((object) new Point(0.0, 0.0), new PropertyChangedCallback(MapOverlay.OnPositionOriginChanged)));
    public static readonly DependencyProperty GeoCoordinateProperty = DependencyProperty.Register(nameof (GeoCoordinate), typeof (GeoCoordinate), typeof (MapOverlay), new PropertyMetadata((PropertyChangedCallback) null));
    public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(nameof (Content), typeof (object), typeof (MapOverlay), new PropertyMetadata((PropertyChangedCallback) null));
    public static readonly DependencyProperty ContentTemplateProperty = DependencyProperty.Register(nameof (ContentTemplate), typeof (DataTemplate), typeof (MapOverlay), new PropertyMetadata((PropertyChangedCallback) null));

    public Point PositionOrigin
    {
      get => (Point) this.GetValue(MapOverlay.PositionOriginProperty);
      set => this.SetValue(MapOverlay.PositionOriginProperty, value);
    }

    [TypeConverter(typeof (GeoCoordinateConverter))]
    public GeoCoordinate GeoCoordinate
    {
      get => (GeoCoordinate) this.GetValue(MapOverlay.GeoCoordinateProperty);
      set => this.SetValue(MapOverlay.GeoCoordinateProperty, (object) value);
    }

    public object Content
    {
      get => this.GetValue(MapOverlay.ContentProperty);
      set => this.SetValue(MapOverlay.ContentProperty, value);
    }

    public DataTemplate ContentTemplate
    {
      get => (DataTemplate) this.GetValue(MapOverlay.ContentTemplateProperty);
      set => this.SetValue(MapOverlay.ContentTemplateProperty, (DependencyObject) value);
    }

    internal MapOverlayPresenter Presenter { get; set; }

    internal void SetupPresenter(Map map, IMapModel mapModel)
    {
      this.Presenter = new MapOverlayPresenter();
      this.Presenter.Model.MapModel = mapModel;
      this.Presenter.SetupMapBindings(map);
      this.SetupPresenterBindings();
    }

    internal void ClearPresenter()
    {
      if (this.Presenter == null)
        return;
      this.Presenter.OnBeforeUnLoaded();
      this.ClearPresenterBindings();
      this.Presenter = (MapOverlayPresenter) null;
    }

    private static void OnPositionOriginChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Point newValue = (Point) e.NewValue;
      if (!MapOverlayPresenter.IsValueNormalized(newValue.X))
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "PositionOrigin.X", (object) 0, (object) 1), "PositionOrigin.X");
      if (!MapOverlayPresenter.IsValueNormalized(newValue.Y))
        throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "PositionOrigin.Y", (object) 0, (object) 1), "PositionOrigin.Y");
    }

    private void SetupPresenterBindings()
    {
      this.SetupPresenterBinding("Content", MapOverlayPresenter.OverlayContentProperty);
      this.SetupPresenterBinding("ContentTemplate", MapOverlayPresenter.OverlayContentTemplateProperty);
      this.SetupPresenterBinding("GeoCoordinate", MapOverlayPresenter.GeoCoordinateProperty);
      this.SetupPresenterBinding("PositionOrigin", MapOverlayPresenter.PositionOriginProperty);
    }

    private void SetupPresenterBinding(string sourcePropertyPath, DependencyProperty targetProperty)
    {
      Binding binding = new Binding()
      {
        Source = (object) this,
        Mode = BindingMode.OneWay,
        Path = new PropertyPath(sourcePropertyPath, new object[0])
      };
      BindingOperations.SetBinding((DependencyObject) this.Presenter, targetProperty, (BindingBase) binding);
    }

    private void ClearPresenterBindings()
    {
      this.Presenter.ClearValue(MapOverlayPresenter.OverlayContentProperty);
      this.Presenter.ClearValue(MapOverlayPresenter.OverlayContentTemplateProperty);
      this.Presenter.ClearValue(MapOverlayPresenter.GeoCoordinateProperty);
      this.Presenter.ClearValue(MapOverlayPresenter.PositionOriginProperty);
    }
  }
}
