// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapPolyline
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Device.Location;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  [ContentProperty("Path")]
  [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Polyline is correct")]
  public sealed class MapPolyline : MapElement
  {
    public static readonly DependencyProperty PathProperty = DependencyProperty.Register(nameof (Path), typeof (GeoCoordinateCollection), typeof (MapPolyline), new PropertyMetadata(new PropertyChangedCallback(MapPolyline.OnPathChanged)));
    public static readonly DependencyProperty StrokeColorProperty = DependencyProperty.Register(nameof (StrokeColor), typeof (Color), typeof (MapPolyline), new PropertyMetadata((object) Colors.Blue, new PropertyChangedCallback(MapPolyline.OnStrokeColorChanged)));
    public static readonly DependencyProperty StrokeDashedProperty = DependencyProperty.Register(nameof (StrokeDashed), typeof (bool), typeof (MapPolyline), new PropertyMetadata((object) false, new PropertyChangedCallback(MapPolyline.OnStrokeDashedChanged)));
    public static readonly DependencyProperty StrokeThicknessProperty = DependencyProperty.Register(nameof (StrokeThickness), typeof (double), typeof (MapPolyline), new PropertyMetadata((object) 1.0, new PropertyChangedCallback(MapPolyline.OnStrokeThicknessChanged)));
    private readonly IMapPolylineModel model;

    public MapPolyline()
    {
      this.model = (IMapPolylineModel) new MOSMapPolylineModel();
      this.Path = new GeoCoordinateCollection();
      this.model.StrokeThickness = this.StrokeThickness;
    }

    [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Public interface, cannot be changed")]
    [TypeConverter(typeof (GeoCoordinateCollectionConverter))]
    public GeoCoordinateCollection Path
    {
      get => (GeoCoordinateCollection) this.GetValue(MapPolyline.PathProperty);
      set => this.SetValue(MapPolyline.PathProperty, (object) value);
    }

    public Color StrokeColor
    {
      get => (Color) this.GetValue(MapPolyline.StrokeColorProperty);
      set => this.SetValue(MapPolyline.StrokeColorProperty, value);
    }

    public bool StrokeDashed
    {
      get => (bool) this.GetValue(MapPolyline.StrokeDashedProperty);
      set => this.SetValue(MapPolyline.StrokeDashedProperty, value);
    }

    public double StrokeThickness
    {
      get => (double) this.GetValue(MapPolyline.StrokeThicknessProperty);
      set => this.SetValue(MapPolyline.StrokeThicknessProperty, value);
    }

    internal override IMapElementModel Model => (IMapElementModel) this.model;

    private static void OnPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      MapPolyline mapPolyline = (MapPolyline) d;
      if (e.OldValue is GeoCoordinateCollection oldValue)
      {
        // ISSUE: method pointer
        oldValue.CollectionChanged -= new NotifyCollectionChangedEventHandler((object) mapPolyline, __methodptr(PathCollectionChanged));
      }
      if (!(e.NewValue is GeoCoordinateCollection newValue))
        return;
      mapPolyline.model.Path = (IList<GeoCoordinate>) newValue;
      // ISSUE: method pointer
      newValue.CollectionChanged += new NotifyCollectionChangedEventHandler((object) mapPolyline, __methodptr(PathCollectionChanged));
    }

    private static void OnStrokeColorChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      ((MapPolyline) d).model.StrokeColor = (Color) e.NewValue;
    }

    private static void OnStrokeDashedChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      ((MapPolyline) d).model.StrokeDashed = (bool) e.NewValue;
    }

    private static void OnStrokeThicknessChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      double newValue = (double) e.NewValue;
      ((MapPolyline) d).model.StrokeThickness = MapElement.IsStrokeThicknessValid(newValue) ? newValue : throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "StrokeThickness", (object) 0.0, (object) 100.0), "StrokeThickness");
    }

    private void PathCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) => this.model.Path = (IList<GeoCoordinate>) sender;
  }
}
