// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MOSFinder
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Services
{
  internal class MOSFinder : IFinderModel, IDisposable
  {
    private readonly Dispatcher dispatcher;
    private bool disposed;
    private AgFinderManagedAdapter adapter;
    private List<MapLocation> cachedResults;

    public MOSFinder(FinderCallbacks finderCallbacks, Dispatcher dispatcher)
    {
      this.dispatcher = dispatcher;
      this.FinderCallbacks = finderCallbacks;
      this.SetReverseCallbacks();
      this.adapter = new AgFinderManagedAdapter();
      this.Id = this.adapter.Id;
      FinderReverseCallbacksThunk.FinderInstanceRegistry.Insert(this.Id, (IFinderModel) this);
      this.IsInRegistry = true;
    }

    ~MOSFinder() => this.Dispose(false);

    public FinderCallbacks FinderCallbacks { get; set; }

    public int Id { get; private set; }

    public bool IsInRegistry { get; private set; }

    public QueryStatus Status => this.adapter.Status;

    public int ErrorCode => this.adapter.ErrorCode;

    public IList<MapLocation> Result
    {
      get
      {
        if (this.cachedResults == null)
        {
          uint resultCount = this.adapter.GetResultCount();
          List<MapLocation> mapLocationList = new List<MapLocation>((int) resultCount);
          for (uint index = 0; index < resultCount; ++index)
          {
            MarshaledLocation result = this.adapter.GetResult(index);
            mapLocationList.Add(MarshaledMapServicesTypeConverter.ToLocation(result));
          }
          this.cachedResults = mapLocationList;
        }
        return (IList<MapLocation>) this.cachedResults;
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void InvokeProcessDispatchQueue() => this.dispatcher.BeginInvoke((Delegate) new MOSFinder.ProcessDispatcherQueue(this.ProcessQueue), (object[]) null);

    public void Geocode(string searchString, GeoCoordinate hintCoordinate, uint maxResults)
    {
      this.cachedResults = (List<MapLocation>) null;
      this.adapter.Geocode(searchString, hintCoordinate, maxResults);
    }

    public void ReverseGeocode(GeoCoordinate coordinate)
    {
      this.cachedResults = (List<MapLocation>) null;
      this.adapter.ReverseGeocode(coordinate);
    }

    public void Cancel() => this.adapter.Cancel();

    protected void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (this.IsInRegistry)
      {
        FinderReverseCallbacksThunk.FinderInstanceRegistry.Remove(this.Id);
        this.IsInRegistry = false;
      }
      if (disposing && this.adapter != null)
      {
        this.adapter.Dispose();
        this.adapter = (AgFinderManagedAdapter) null;
      }
      this.disposed = true;
    }

    private void ProcessQueue()
    {
      if (this.adapter == null)
        return;
      this.adapter.ProcessDispatchQueue();
    }

    private void SetReverseCallbacks() => AgFinderManagedAdapter.SetReverseCallbacks(FinderReverseCallbacksThunk.InvokeProcessDispatchQueueEventHandler, FinderReverseCallbacksThunk.StatusChangedEventHandler);

    private delegate void ProcessDispatcherQueue();
  }
}
