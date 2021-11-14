// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.GeocodeQuery
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  public sealed class GeocodeQuery : Query<IList<MapLocation>>
  {
    private const uint MinResultCount = 1;
    private bool disposed;
    private Lazy<IFinderModel> lazyFinder;
    private string searchTerm;
    private GeoCoordinate geoCoordinate;
    private int maxResultCount = 10;

    public GeocodeQuery() => this.lazyFinder = new Lazy<IFinderModel>(new Func<IFinderModel>(this.CreateFinderInstance));

    public string SearchTerm
    {
      get
      {
        this.CheckThread();
        return this.searchTerm;
      }
      set
      {
        this.CheckThread();
        this.searchTerm = value;
      }
    }

    public GeoCoordinate GeoCoordinate
    {
      get
      {
        this.CheckThread();
        return this.geoCoordinate;
      }
      set
      {
        this.CheckThread();
        this.geoCoordinate = value;
      }
    }

    public int MaxResultCount
    {
      get
      {
        this.CheckThread();
        return this.maxResultCount;
      }
      set
      {
        this.CheckThread();
        this.maxResultCount = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof (value), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LessThanExceptionFormat, (object) nameof (MaxResultCount), (object) 1U));
      }
    }

    internal IFinderModel FinderModel
    {
      get
      {
        if (this.disposed)
          throw new ObjectDisposedException(this.GetType().Name);
        return this.lazyFinder.Value;
      }
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this.disposed)
          return;
        if (disposing && this.lazyFinder != null && this.lazyFinder.IsValueCreated)
        {
          this.lazyFinder.Value.Dispose();
          this.lazyFinder = (Lazy<IFinderModel>) null;
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
      if (string.IsNullOrWhiteSpace(this.searchTerm))
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidQueryParametersExceptionFormat, (object) string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.ArgumentNullEmptyWhiteSpaceFormat, (object) "SearchTerm")));
      if (this.geoCoordinate == (GeoCoordinate) null)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.InvalidQueryParametersExceptionFormat, (object) string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.ArgumentNullExceptionFormat, (object) "GeoCoordinate")));
      EventLogger.LogEvent(EventId.FinderAdapter_Geocode_Silverlight, this.FinderModel.Id);
      this.FinderModel.Geocode(this.searchTerm, this.geoCoordinate, (uint) this.maxResultCount);
    }

    protected override void DoCancelAsync() => this.FinderModel.Cancel();

    private IFinderModel CreateFinderInstance() => (IFinderModel) new MOSFinder(new FinderCallbacks()
    {
      StatusChangedEventHandler = new FinderCallbackDelegates.StatusChanged(this.FireFinderStatusChanged)
    }, this.Dispatcher);

    private void FireFinderStatusChanged()
    {
      Exception queryException = (Exception) null;
      IList<MapLocation> result = (IList<MapLocation>) null;
      bool flag = false;
      try
      {
        if (this.FinderModel.Status == QueryStatus.QueryStatusComplete)
        {
          queryException = Marshal.GetExceptionForHR(this.FinderModel.ErrorCode);
          if (queryException == null)
            result = this.FinderModel.Result;
          flag = true;
        }
      }
      catch (Exception ex)
      {
        queryException = ex;
        result = (IList<MapLocation>) null;
        flag = true;
      }
      if (!flag)
        return;
      this.Dispatcher.BeginInvoke((Action) (() => this.OnQueryCompleted(result, queryException)));
    }
  }
}
