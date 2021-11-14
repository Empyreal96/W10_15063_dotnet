// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapRoute
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Services;
using System;
using System.Globalization;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  public sealed class MapRoute
  {
    private readonly IMapRoute mapRoute;

    public MapRoute(Route route) => this.mapRoute = route != null ? (IMapRoute) new MOSMapRoute(route) : throw new ArgumentNullException(nameof (route));

    public Color Color
    {
      get => this.mapRoute.Color;
      set => this.mapRoute.Color = value;
    }

    public bool DisplayOutline
    {
      get => this.mapRoute.DisplayOutline;
      set => this.mapRoute.DisplayOutline = value;
    }

    public Color OutlineColor
    {
      get => this.mapRoute.OutlineColor;
      set => this.mapRoute.OutlineColor = value;
    }

    public RouteViewKind RouteViewKind
    {
      get => this.mapRoute.RouteViewKind;
      set => this.mapRoute.RouteViewKind = Enum.IsDefined(typeof (RouteViewKind), (object) value) ? value : throw new ArgumentOutOfRangeException(nameof (value), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) value));
    }

    public Route Route
    {
      get => this.mapRoute.Route;
      set => this.mapRoute.Route = value != null ? value : throw new ArgumentNullException(nameof (value));
    }

    internal MapRouteSafeHandle NativeHandle => this.mapRoute.NativeHandle;
  }
}
