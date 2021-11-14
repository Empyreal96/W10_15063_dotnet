// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MOSMapRoute
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Services;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MOSMapRoute : IMapRoute
  {
    private readonly MapRouteAdapter adapter;

    public MOSMapRoute(Route route) => this.adapter = new MapRouteAdapter(route);

    public MapRouteSafeHandle NativeHandle => this.adapter.NativeHandle;

    public Color Color
    {
      get => this.adapter.Color;
      set => this.adapter.Color = value;
    }

    public bool DisplayOutline
    {
      get => this.adapter.DisplayOutline;
      set => this.adapter.DisplayOutline = value;
    }

    public Color OutlineColor
    {
      get => this.adapter.OutlineColor;
      set => this.adapter.OutlineColor = value;
    }

    public RouteViewKind RouteViewKind
    {
      get => this.adapter.RouteViewKind;
      set => this.adapter.RouteViewKind = value;
    }

    public Route Route
    {
      get => this.adapter.Route;
      set => this.adapter.Route = value;
    }
  }
}
