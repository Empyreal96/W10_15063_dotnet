// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.AgRouterManagedAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  internal class AgRouterManagedAdapter : IDisposable
  {
    private static bool reverseCallbacksInitialized;
    private bool disposed;
    private AgRouterSafeHandle nativeAdapter;

    public AgRouterManagedAdapter()
    {
      try
      {
        Marshal.ThrowExceptionForHR(Shim.AgRouterAdapter_Create(out this.nativeAdapter));
      }
      catch (UnauthorizedAccessException ex)
      {
        throw new UnauthorizedAccessException(Resources.RequireMapCapabilityException);
      }
      if (this.nativeAdapter.IsInvalid)
        throw new InvalidOperationException(Resources.CreationException);
    }

    ~AgRouterManagedAdapter() => this.Dispose(false);

    public int Id => Shim.AgRouterAdapter_GetInstanceId(this.nativeAdapter);

    public QueryStatus Status => Shim.AgRouterAdapter_GetStatus(this.nativeAdapter);

    public int ErrorCode => Shim.AgRouterAdapter_GetErrorCode(this.nativeAdapter);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void ProcessDispatchQueue() => Shim.AgRouterAdapter_ProcessDispatchQueue(this.Id);

    public void CalculateRoute(
      IEnumerable<GeoCoordinate> waypoints,
      TravelMode travelMode,
      RouteOptimization routeOptimization,
      int startHeadingInDegrees)
    {
      List<MarshaledGeoCoordinates> marshaledGeoCoordinatesList = new List<MarshaledGeoCoordinates>();
      foreach (GeoCoordinate waypoint in waypoints)
        marshaledGeoCoordinatesList.Add(MarshaledTypeConverter.ToMarshaledGeoCoordinates(waypoint));
      MarshaledGeoCoordinates[] array = marshaledGeoCoordinatesList.ToArray();
      AgRouterSafeHandle nativeAdapter = this.nativeAdapter;
      MarshaledGeoCoordinates[] waypoints1 = array;
      int length = waypoints1.Length;
      int num1 = (int) travelMode;
      int num2 = (int) routeOptimization;
      int startHeadingInDegrees1 = startHeadingInDegrees;
      Marshal.ThrowExceptionForHR(Shim.AgRouterAdapter_CalculateRoute(nativeAdapter, waypoints1, length, (uint) num1, (uint) num2, startHeadingInDegrees1));
    }

    public void Cancel() => Shim.AgRouterAdapter_Cancel(this.nativeAdapter);

    public Route GetRoute()
    {
      RouteSafeHandle routeHandle = Shim.AgRouterAdapter_GetRouteHandle(this.nativeAdapter);
      if (routeHandle.IsInvalid)
        throw new InvalidOperationException(Resources.InvalidBackingObjectException);
      MarshaledRoute route;
      Marshal.ThrowExceptionForHR(Shim.AgRouterAdapter_GetRoute(routeHandle, out route));
      using (route)
        return MarshaledMapServicesTypeConverter.ToRoute(route, routeHandle);
    }

    public void SetReverseCallbacks(
      RouterReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueEventHandler,
      RouterReverseCallbackDelegates.StatusChangedCallback statusChangedEventHandler)
    {
      if (AgRouterManagedAdapter.reverseCallbacksInitialized)
        return;
      Marshal.ThrowExceptionForHR(Shim.AgRouterAdapter_SetRouterReverseCallbacks(invokeProcessDispatchQueueEventHandler, statusChangedEventHandler));
      AgRouterManagedAdapter.reverseCallbacksInitialized = true;
    }

    protected void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing && this.nativeAdapter != null && !this.nativeAdapter.IsInvalid)
      {
        this.nativeAdapter.Dispose();
        this.nativeAdapter = (AgRouterSafeHandle) null;
      }
      this.disposed = true;
    }
  }
}
