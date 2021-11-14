// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapRouteAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Services;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapRouteAdapter
  {
    private MapRouteSafeHandle nativeHandle;

    public MapRouteAdapter(Route route) => this.Route = route;

    public Color Color
    {
      get
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        int color;
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_GetColor(this.NativeHandle, out color));
        return ColorHelper.FromArgb(color);
      }
      set
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_SetColor(this.NativeHandle, value.ToArgb()));
      }
    }

    public bool DisplayOutline
    {
      get
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        bool displayOutline;
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_GetDisplayOutline(this.NativeHandle, out displayOutline));
        return displayOutline;
      }
      set
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_SetDisplayOutline(this.NativeHandle, value));
      }
    }

    public Color OutlineColor
    {
      get
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        int color;
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_GetOutlineColor(this.NativeHandle, out color));
        return ColorHelper.FromArgb(color);
      }
      set
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_SetOutlineColor(this.NativeHandle, value.ToArgb()));
      }
    }

    public RouteViewKind RouteViewKind
    {
      get
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        int viewType;
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_GetViewType(this.NativeHandle, out viewType));
        return Enum.IsDefined(typeof (RouteViewKind), (object) (RouteViewKind) viewType) ? (RouteViewKind) viewType : throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.EnumMatchingExceptionFormat, (object) nameof (RouteViewKind)));
      }
      set
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_SetViewType(this.NativeHandle, (int) value));
      }
    }

    public Route Route
    {
      get
      {
        if (this.NativeHandle.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        RouteSafeHandle nativeRoute;
        Marshal.ThrowExceptionForHR(Shim.AgMapRoute_GetRoute(this.NativeHandle, out nativeRoute));
        if (nativeRoute.IsInvalid)
          throw new InvalidOperationException(Resources.InvalidBackingObjectException);
        MarshaledRoute route;
        Marshal.ThrowExceptionForHR(Shim.AgRouterAdapter_GetRoute(nativeRoute, out route));
        using (route)
          return MarshaledMapServicesTypeConverter.ToRoute(route, nativeRoute);
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        if (this.nativeHandle == null)
        {
          Marshal.ThrowExceptionForHR(Shim.AgMapRoute_Create(value.NativeHandle, out this.nativeHandle));
          if (this.nativeHandle.IsInvalid)
            throw new InvalidOperationException(Resources.CreationException);
        }
        else
          Marshal.ThrowExceptionForHR(Shim.AgMapRoute_SetRoute(this.nativeHandle, value.NativeHandle));
      }
    }

    internal MapRouteSafeHandle NativeHandle => this.nativeHandle;
  }
}
