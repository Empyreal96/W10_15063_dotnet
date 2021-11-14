// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapPolygon
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
  public sealed class MapPolygon : MapElement
  {
    public static readonly DependencyProperty PathProperty = DependencyProperty.Register(nameof (Path), typeof (GeoCoordinateCollection), typeof (MapPolygon), new PropertyMetadata(new PropertyChangedCallback(MapPolygon.OnPathChanged)));
    public static readonly DependencyProperty StrokeColorProperty = DependencyProperty.Register(nameof (StrokeColor), typeof (Color), typeof (MapPolygon), new PropertyMetadata((object) Colors.Blue, new PropertyChangedCallback(MapPolygon.OnStrokeColorChanged)));
    public static readonly DependencyProperty FillColorProperty = DependencyProperty.Register(nameof (FillColor), typeof (Color), typeof (MapPolygon), new PropertyMetadata((object) Colors.Blue, new PropertyChangedCallback(MapPolygon.OnFillColorChanged)));
    public static readonly DependencyProperty StrokeDashedProperty = DependencyProperty.Register(nameof (StrokeDashed), typeof (bool), typeof (MapPolygon), new PropertyMetadata((object) false, new PropertyChangedCallback(MapPolygon.OnStrokeDashedChanged)));
    public static readonly DependencyProperty StrokeThicknessProperty = DependencyProperty.Register(nameof (StrokeThickness), typeof (double), typeof (MapPolygon), new PropertyMetadata((object) 0.0, new PropertyChangedCallback(MapPolygon.OnStrokeThicknessChanged)));
    private readonly IMapPolygonModel model;

    public MapPolygon()
    {
      this.model = (IMapPolygonModel) new MOSMapPolygonModel();
      this.Path = new GeoCoordinateCollection();
      this.model.StrokeThickness = this.StrokeThickness;
    }

    [TypeConverter(typeof (GeoCoordinateCollectionConverter))]
    [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Public interface, cannot be changed")]
    public GeoCoordinateCollection Path
    {
      get => (GeoCoordinateCollection) this.GetValue(MapPolygon.PathProperty);
      set => this.SetValue(MapPolygon.PathProperty, (object) value);
    }

    public Color StrokeColor
    {
      get => (Color) this.GetValue(MapPolygon.StrokeColorProperty);
      set => this.SetValue(MapPolygon.StrokeColorProperty, value);
    }

    public Color FillColor
    {
      get => (Color) this.GetValue(MapPolygon.FillColorProperty);
      set => this.SetValue(MapPolygon.FillColorProperty, value);
    }

    public bool StrokeDashed
    {
      get => (bool) this.GetValue(MapPolygon.StrokeDashedProperty);
      set => this.SetValue(MapPolygon.StrokeDashedProperty, value);
    }

    public double StrokeThickness
    {
      get => (double) this.GetValue(MapPolygon.StrokeThicknessProperty);
      set => this.SetValue(MapPolygon.StrokeThicknessProperty, value);
    }

    internal override IMapElementModel Model => (IMapElementModel) this.model;

    private static void OnPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      MapPolygon mapPolygon = (MapPolygon) d;
      if (e.OldValue is GeoCoordinateCollection oldValue)
      {
        // ISSUE: method pointer
        oldValue.CollectionChanged -= new NotifyCollectionChangedEventHandler((object) mapPolygon, __methodptr(PathCollectionChanged));
      }
      if (!(e.NewValue is GeoCoordinateCollection newValue))
        return;
      mapPolygon.model.Path = (IList<GeoCoordinate>) newValue;
      // ISSUE: method pointer
      newValue.CollectionChanged += new NotifyCollectionChangedEventHandler((object) mapPolygon, __methodptr(PathCollectionChanged));
    }

    private static void OnStrokeColorChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      ((MapPolygon) d).model.StrokeColor = (Color) e.NewValue;
    }

    private static void OnFillColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((MapPolygon) d).model.FillColor = (Color) e.NewValue;

    private static void OnStrokeDashedChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      ((MapPolygon) d).model.StrokeDashed = (bool) e.NewValue;
    }

    private static void OnStrokeThicknessChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      double newValue = (double) e.NewValue;
      ((MapPolygon) d).model.StrokeThickness = MapElement.IsStrokeThicknessValid(newValue) ? newValue : throw new ArgumentOutOfRangeException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) "StrokeThickness", (object) 0.0, (object) 100.0), "StrokeThickness");
    }

    private void PathCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) => this.model.Path = (IList<GeoCoordinate>) sender;
  }
}
