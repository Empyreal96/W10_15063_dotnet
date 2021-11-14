// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.AgFinderManagedAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System;
using System.Device.Location;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  internal class AgFinderManagedAdapter : IDisposable
  {
    private static bool reverseCallbacksInitialized;
    private bool disposed;
    private AgFinderSafeHandle nativeAdapter;

    public AgFinderManagedAdapter()
    {
      try
      {
        Marshal.ThrowExceptionForHR(Shim.AgFinderAdapter_Create(out this.nativeAdapter));
      }
      catch (UnauthorizedAccessException ex)
      {
        throw new UnauthorizedAccessException(Resources.RequireMapCapabilityException);
      }
      if (this.nativeAdapter.IsInvalid)
        throw new InvalidOperationException(Resources.CreationException);
    }

    ~AgFinderManagedAdapter() => this.Dispose(false);

    public int Id => Shim.AgFinderAdapter_GetInstanceId(this.nativeAdapter);

    public QueryStatus Status => Shim.AgFinderAdapter_GetStatus(this.nativeAdapter);

    public int ErrorCode => Shim.AgFinderAdapter_GetErrorCode(this.nativeAdapter);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void Geocode(string searchString, GeoCoordinate hintCoordinate, uint maxResults)
    {
      MarshaledGeoCoordinates marshaledGeoCoordinates = MarshaledTypeConverter.ToMarshaledGeoCoordinates(hintCoordinate);
      Shim.AgFinderAdapter_Geocode(this.nativeAdapter, searchString, marshaledGeoCoordinates, maxResults);
    }

    public void ReverseGeocode(GeoCoordinate coordinate) => Shim.AgFinderAdapter_ReverseGeocode(this.nativeAdapter, MarshaledTypeConverter.ToMarshaledGeoCoordinates(coordinate));

    public void Cancel() => Shim.AgFinderAdapter_Cancel(this.nativeAdapter);

    public uint GetResultCount() => Shim.AgFinderAdapter_GetResultCount(this.nativeAdapter);

    public MarshaledLocation GetResult(uint index)
    {
      MarshaledLocation location;
      Marshal.ThrowExceptionForHR(Shim.AgFinderAdapter_GetResult(this.nativeAdapter, index, out location));
      return location;
    }

    public void ProcessDispatchQueue() => Shim.AgFinderAdapter_ProcessDispatchQueue(this.Id);

    public static void SetReverseCallbacks(
      FinderReverseCallbackDelegates.InvokeProcessDispatchQueueCallback invokeProcessDispatchQueueEventHandler,
      FinderReverseCallbackDelegates.StatusChangedCallback statusChangedEventHandler)
    {
      if (AgFinderManagedAdapter.reverseCallbacksInitialized)
        return;
      Marshal.ThrowExceptionForHR(Shim.AgFinderAdapter_SetFinderReverseCallbacks(invokeProcessDispatchQueueEventHandler, statusChangedEventHandler));
      AgFinderManagedAdapter.reverseCallbacksInitialized = true;
    }

    protected void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing && this.nativeAdapter != null && !this.nativeAdapter.IsInvalid)
      {
        this.nativeAdapter.Dispose();
        this.nativeAdapter = (AgFinderSafeHandle) null;
      }
      this.disposed = true;
    }
  }
}
