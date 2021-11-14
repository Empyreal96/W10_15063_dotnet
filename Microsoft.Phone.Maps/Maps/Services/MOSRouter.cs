// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MOSRouter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Services
{
  internal class MOSRouter : IRouterModel, IDisposable
  {
    private const int AnyStartHeading = -1;
    private readonly Dispatcher dispatcher;
    private bool disposed;
    private AgRouterManagedAdapter adapter;
    private Route cachedResult;

    public MOSRouter(RouterCallbacks routerCallbacks, Dispatcher dispatcher)
    {
      this.dispatcher = dispatcher;
      this.RouterCallbacks = routerCallbacks;
      this.adapter = new AgRouterManagedAdapter();
      this.Id = this.adapter.Id;
      RouterReverseCallbacksThunk.RouterInstanceRegistry.Insert(this.Id, (IRouterModel) this);
      this.IsInRegistry = true;
      this.SetReverseCallbacks();
    }

    ~MOSRouter() => this.Dispose(false);

    public RouterCallbacks RouterCallbacks { get; set; }

    public int Id { get; private set; }

    public bool Cancelled { get; private set; }

    public bool IsInRegistry { get; private set; }

    public QueryStatus Status => this.adapter.Status;

    public int ErrorCode => this.adapter.ErrorCode;

    public Route Result
    {
      get
      {
        if (this.cachedResult == null)
          this.cachedResult = this.adapter.GetRoute();
        return this.cachedResult;
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void InvokeProcessDispatchQueue() => this.dispatcher.BeginInvoke((Delegate) new MOSRouter.ProcessDispatcherQueue(this.ProcessQueue), (object[]) null);

    public void CalculateRoute(
      IEnumerable<GeoCoordinate> waypoints,
      TravelMode travelMode,
      RouteOptimization routeOptimization,
      double? initialHeadingInDegrees)
    {
      this.Cancelled = false;
      this.cachedResult = (Route) null;
      int startHeadingInDegrees = initialHeadingInDegrees.HasValue ? checked ((int) initialHeadingInDegrees.Value) : -1;
      this.adapter.CalculateRoute(waypoints, travelMode, routeOptimization, startHeadingInDegrees);
    }

    public void Cancel()
    {
      this.Cancelled = true;
      this.adapter.Cancel();
    }

    protected void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (this.IsInRegistry)
      {
        RouterReverseCallbacksThunk.RouterInstanceRegistry.Remove(this.Id);
        this.IsInRegistry = false;
      }
      if (disposing && this.adapter != null)
      {
        this.adapter.Dispose();
        this.adapter = (AgRouterManagedAdapter) null;
      }
      this.disposed = true;
    }

    private void SetReverseCallbacks() => this.adapter.SetReverseCallbacks(RouterReverseCallbacksThunk.InvokeProcessDispatchQueueEventHandler, RouterReverseCallbacksThunk.StatusChangedEventHandler);

    private void ProcessQueue()
    {
      if (this.adapter == null)
        return;
      this.adapter.ProcessDispatchQueue();
    }

    private delegate void ProcessDispatcherQueue();
  }
}
