// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.AsyncSubject`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  public class AsyncSubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>
  {
    private readonly List<IObserver<T>> observers;
    private readonly IScheduler scheduler;
    private bool completed;
    private Notification<T> last;

    public AsyncSubject()
      : this((IScheduler) Scheduler.CurrentThread)
    {
    }

    public AsyncSubject(IScheduler scheduler)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      this.observers = new List<IObserver<T>>();
      this.last = (Notification<T>) null;
      this.scheduler = scheduler;
      this.completed = false;
    }

    public void OnNext(T value)
    {
      lock (this.observers)
      {
        if (this.completed)
          return;
        this.last = (Notification<T>) new Notification<T>.OnNext(value);
      }
    }

    public void OnError(Exception exception)
    {
      if (exception == null)
        throw new ArgumentNullException(nameof (exception));
      IObserver<T>[] iobserverArray = (IObserver<T>[]) null;
      lock (this.observers)
      {
        if (!this.completed)
        {
          iobserverArray = this.observers.ToArray();
          this.last = (Notification<T>) new Notification<T>.OnError(exception);
          this.completed = true;
          this.observers.Clear();
        }
      }
      if (iobserverArray == null)
        return;
      foreach (IObserver<T> observer in iobserverArray)
        this.last.Accept(observer);
    }

    public void OnCompleted()
    {
      IObserver<T>[] iobserverArray = (IObserver<T>[]) null;
      lock (this.observers)
      {
        if (!this.completed)
        {
          this.completed = true;
          iobserverArray = this.observers.ToArray();
          if (this.last == (Notification<T>) null)
            this.last = (Notification<T>) new Notification<T>.OnCompleted();
          this.observers.Clear();
        }
      }
      if (iobserverArray == null)
        return;
      foreach (IObserver<T> observer in iobserverArray)
      {
        this.last.Accept(observer);
        if (this.last.HasValue)
          observer.OnCompleted();
      }
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
      if (observer == null)
        throw new ArgumentNullException(nameof (observer));
      lock (this.observers)
      {
        if (!this.completed)
        {
          this.observers.Add(observer);
          return (IDisposable) new AsyncSubject<T>.RemovableDisposable(this, observer);
        }
      }
      return this.scheduler.Schedule((Action) (() => this.last.Accept((IObserver<T>) new AsyncSubject<T>.AsyncObserver(observer))));
    }

    private void Unsubscribe(IObserver<T> observer)
    {
      lock (this.observers)
        this.observers.Remove(observer);
    }

    private class AsyncObserver : IObserver<T>
    {
      private readonly IObserver<T> observer;

      public AsyncObserver(IObserver<T> observer) => this.observer = observer;

      public void OnNext(T value)
      {
        this.observer.OnNext(value);
        this.observer.OnCompleted();
      }

      public void OnError(Exception exception) => this.observer.OnError(exception);

      public void OnCompleted() => this.observer.OnCompleted();
    }

    private sealed class RemovableDisposable : IDisposable
    {
      private readonly IObserver<T> observer;
      private readonly AsyncSubject<T> subject;

      public RemovableDisposable(AsyncSubject<T> subject, IObserver<T> observer)
      {
        this.subject = subject;
        this.observer = observer;
      }

      public void Dispose()
      {
        this.subject.Unsubscribe(this.observer);
        GC.SuppressFinalize((object) this);
      }
    }
  }
}
