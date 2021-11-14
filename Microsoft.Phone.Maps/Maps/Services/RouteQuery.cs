// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.RouteQuery
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  public sealed class RouteQuery : Query<Route>
  {
    private const double MaxHeading = 360.0;
    private bool disposed;
    private Lazy<IRouterModel> lazyModel;
    private IEnumerable<GeoCoordinate> waypoints;
    private TravelMode travelMode;
    private RouteOptimization routeOptimization;
    private double? initialHeadingInDegrees;

    public RouteQuery()
    {
      this.travelMode = TravelMode.Driving;
      this.routeOptimization = RouteOptimization.MinimizeTime;
      this.initialHeadingInDegrees = new double?();
      this.lazyModel = new Lazy<IRouterModel>(new Func<IRouterModel>(this.CreateRouterInstance));
    }

    public IEnumerable<GeoCoordinate> Waypoints
    {
      get
      {
        this.CheckThread();
        return this.waypoints;
      }
      set
      {
        this.CheckThread();
        this.waypoints = value;
      }
    }

    public TravelMode TravelMode
    {
      get
      {
        this.CheckThread();
        return this.travelMode;
      }
      set
      {
        this.CheckThread();
        this.travelMode = Enum.IsDefined(typeof (TravelMode), (object) value) ? value : throw new ArgumentOutOfRangeException(nameof (value), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) value));
      }
    }

    public RouteOptimization RouteOptimization
    {
      get
      {
        this.CheckThread();
        return this.routeOptimization;
      }
      set
      {
        this.CheckThread();
        this.routeOptimization = Enum.IsDefined(typeof (RouteOptimization), (object) value) ? value : throw new ArgumentOutOfRangeException(nameof (value), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidEnumExceptionFormat, (object) value));
      }
    }

    public double? InitialHeadingInDegrees
    {
      get
      {
        this.CheckThread();
        return this.initialHeadingInDegrees;
      }
      set
      {
        this.CheckThread();
        this.initialHeadingInDegrees = value;
      }
    }

    internal IRouterModel RouterModel
    {
      get
      {
        if (this.disposed)
          throw new ObjectDisposedException(this.GetType().Name);
        return this.lazyModel.Value;
      }
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this.disposed)
          return;
        if (disposing && this.lazyModel.IsValueCreated)
        {
          this.RouterModel.Dispose();
          this.lazyModel = (Lazy<IRouterModel>) null;
        }
        this.disposed = true;
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    protected override void DoStartAsync()
    {
      if (this.waypoints == null)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidQueryParametersExceptionFormat, (object) string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.ArgumentNullExceptionFormat, (object) "Waypoints")));
      if (this.waypoints.Count<GeoCoordinate>() < 2)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidQueryParametersExceptionFormat, (object) Resources.WaypointCountException));
      EventLogger.LogEvent(EventId.RouterAdapter_CalculateRoute_Silverlight, this.RouterModel.Id);
      this.RouterModel.CalculateRoute(this.waypoints, this.travelMode, this.routeOptimization, RouteQuery.NormalizeHeading(this.initialHeadingInDegrees));
    }

    protected override void DoCancelAsync() => this.RouterModel.Cancel();

    private static double? NormalizeHeading(double? heading)
    {
      double? nullable1 = new double?();
      if (heading.HasValue)
      {
        nullable1 = new double?(heading.Value % 360.0);
        double? nullable2 = nullable1;
        double num1 = 0.0;
        if ((nullable2.GetValueOrDefault() < num1 ? (nullable2.HasValue ? 1 : 0) : 0) != 0)
        {
          nullable2 = nullable1;
          double num2 = 360.0;
          nullable1 = nullable2.HasValue ? new double?(nullable2.GetValueOrDefault() + num2) : new double?();
        }
      }
      return nullable1;
    }

    private IRouterModel CreateRouterInstance() => (IRouterModel) new MOSRouter(new RouterCallbacks()
    {
      StatusChangedEventHandler = new RouterCallbackDelegates.StatusChanged(this.FireRouterStatusChanged)
    }, this.Dispatcher);

    private void FireRouterStatusChanged()
    {
      Exception queryException = (Exception) null;
      Route route = (Route) null;
      bool flag = false;
      try
      {
        if (this.RouterModel.Status == QueryStatus.QueryStatusComplete)
        {
          queryException = Marshal.GetExceptionForHR(this.RouterModel.ErrorCode);
          if (queryException == null)
            route = this.RouterModel.Result;
          flag = true;
        }
      }
      catch (Exception ex)
      {
        queryException = ex;
        route = (Route) null;
        flag = true;
      }
      if (!flag)
        return;
      this.Dispatcher.BeginInvoke((Action) (() => this.OnQueryCompleted(route, queryException)));
    }
  }
}
