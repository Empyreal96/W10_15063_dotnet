// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.FinderTest
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Threading;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Services
{
  internal sealed class FinderTest : IFinderModel, IDisposable
  {
    private static int idSeed;
    private QueryStatus status;
    private IList<MapLocation> cachedResults;

    public FinderTest(FinderCallbacks finderCallbacks, Dispatcher dispatcher)
    {
      this.Id = Interlocked.Add(ref FinderTest.idSeed, 1);
      this.Dispatcher = dispatcher;
      this.FinderCallbacks = finderCallbacks;
      this.DispatcherQueue = new Queue<FinderTest.DispatcherQueueItem>();
      this.StatusChangedDispatcherQueueItem = new FinderTest.DispatcherQueueItem(this.OnStatusChanged);
      FinderReverseCallbacksThunk.FinderInstanceRegistry.Insert(this.Id, (IFinderModel) this);
      this.IsInRegistry = true;
    }

    public FinderCallbacks FinderCallbacks { get; set; }

    public int Id { get; private set; }

    public bool IsInRegistry { get; private set; }

    public QueryStatus Status
    {
      get => this.status;
      set
      {
        if (this.status == value)
          return;
        this.status = value;
        this.DispatcherQueue.Enqueue(this.StatusChangedDispatcherQueueItem);
        this.InvokeProcessDispatchQueue();
      }
    }

    public int ErrorCode { get; set; }

    public IList<MapLocation> Result
    {
      get
      {
        if (this.cachedResults == null)
          this.cachedResults = (IList<MapLocation>) new List<MapLocation>();
        return this.cachedResults;
      }
    }

    private FinderTest.DispatcherQueueItem StatusChangedDispatcherQueueItem { get; set; }

    private Queue<FinderTest.DispatcherQueueItem> DispatcherQueue { get; set; }

    private Dispatcher Dispatcher { get; set; }

    public void InvokeProcessDispatchQueue() => this.Dispatcher.BeginInvoke((Delegate) new FinderTest.ProcessDispatcherQueue(this.ProcessQueue), (object[]) null);

    public void Geocode(string searchString, GeoCoordinate hintCoordinate, uint maxResults)
    {
      this.cachedResults = (IList<MapLocation>) null;
      throw new NotImplementedException();
    }

    public void ReverseGeocode(GeoCoordinate coordinate)
    {
      this.cachedResults = (IList<MapLocation>) null;
      throw new NotImplementedException();
    }

    public void OnStatusChanged() => FinderReverseCallbacksThunk.StatusChangedEventHandler(this.Id);

    public void Cancel()
    {
    }

    public void Dispose()
    {
    }

    private void ProcessQueue()
    {
      while (this.DispatcherQueue.Count > 0)
        this.DispatcherQueue.Dequeue()();
    }

    private delegate void DispatcherQueueItem();

    private delegate void ProcessDispatcherQueue();
  }
}
