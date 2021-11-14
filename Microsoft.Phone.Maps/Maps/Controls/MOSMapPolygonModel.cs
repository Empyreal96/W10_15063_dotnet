// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MOSMapPolygonModel
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MOSMapPolygonModel : MOSMapObject, IMapPolygonModel, IMapElementModel
  {
    private readonly MapPolygonAdapter adapter;
    private double? strokeThickness;

    public MOSMapPolygonModel() => this.adapter = new MapPolygonAdapter();

    public IList<GeoCoordinate> Path
    {
      get => throw new NotImplementedException();
      set => this.adapter.Path = value != null ? MarshaledTypeConverter.ToMarshaledGeoCoordinatesArray((IEnumerable<GeoCoordinate>) value) : throw new ArgumentNullException(nameof (value));
    }

    public Color StrokeColor
    {
      get => this.adapter.StrokeColor;
      set => this.adapter.StrokeColor = value;
    }

    public Color FillColor
    {
      get => this.adapter.FillColor;
      set => this.adapter.FillColor = value;
    }

    public bool StrokeDashed
    {
      get => throw new NotImplementedException();
      set => this.adapter.StrokeDashed = value;
    }

    public double StrokeThickness
    {
      get
      {
        if (!this.strokeThickness.HasValue)
          this.strokeThickness = new double?(DipHelper.ConvertScreenToDipPixel((double) this.adapter.StrokeThickness));
        return this.strokeThickness.Value;
      }
      set
      {
        this.strokeThickness = new double?(value);
        this.adapter.StrokeThickness = Convert.ToUInt32(DipHelper.ConvertDipToScreenPixel(value));
      }
    }

    internal override MapObjectAdapter MapObjectAdapter => (MapObjectAdapter) this.adapter;
  }
}
