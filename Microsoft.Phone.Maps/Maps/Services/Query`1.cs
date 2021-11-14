// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.Query`1
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;

namespace Microsoft.Phone.Maps.Services
{
  public abstract class Query<T> : IDisposable
  {
    private static readonly object lockObject = new object();
    private static readonly HashSet<Query<T>> queryReferences = new HashSet<Query<T>>();
    private bool isBusy;
    private bool disposed;
    private bool canceled;

    internal Query()
    {
      this.Dispatcher = Deployment.Current.Dispatcher;
      this.CheckThread();
    }

    ~Query() => this.Dispose(false);

    public event EventHandler<QueryCompletedEventArgs<T>> QueryCompleted;

    public bool IsBusy
    {
      get
      {
        this.CheckThread();
        return this.isBusy;
      }
      private set
      {
        this.CheckThread();
        this.isBusy = value;
      }
    }

    internal Dispatcher Dispatcher { get; private set; }

    public void Dispose()
    {
      this.CheckThread();
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public void QueryAsync()
    {
      this.CheckThread();
      if (this.IsBusy)
        throw new InvalidOperationException(Resources.ConcurrentQueryException);
      this.canceled = false;
      this.IsBusy = true;
      this.DoStartAsync();
      lock (Query<T>.lockObject)
        Query<T>.queryReferences.Add(this);
    }

    public void CancelAsync()
    {
      this.CheckThread();
      this.DoCancelAsync();
      this.canceled = true;
    }

    protected void CheckThread()
    {
      if (!this.Dispatcher.CheckAccess())
        throw new UnauthorizedAccessException(Resources.ThreadAccessException);
    }

    protected abstract void DoStartAsync();

    protected abstract void DoCancelAsync();

    protected virtual void Dispose(bool disposing)
    {
      if (this.disposed)
        return;
      if (disposing && this.isBusy)
      {
        this.canceled = true;
        this.OnQueryCompleted(default (T), (Exception) null);
      }
      this.disposed = true;
    }

    protected virtual void OnQueryCompleted(T result, Exception queryError)
    {
      if (!this.IsBusy)
        return;
      this.IsBusy = false;
      if (this.canceled)
      {
        result = default (T);
        queryError = (Exception) null;
      }
      lock (Query<T>.lockObject)
        Query<T>.queryReferences.Remove(this);
      this.OnQueryCompleted(new QueryCompletedEventArgs<T>(queryError, this.canceled, (object) this, result));
    }

    private void OnQueryCompleted(QueryCompletedEventArgs<T> e)
    {
      if (this.QueryCompleted == null)
        return;
      this.QueryCompleted((object) this, e);
    }
  }
}
