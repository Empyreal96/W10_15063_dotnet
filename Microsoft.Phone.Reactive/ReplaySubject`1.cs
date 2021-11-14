// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ReplaySubject`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  public class ReplaySubject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>
  {
    private const int InfiniteBufferSize = 2147483647;
    private readonly TimeSpan _window;
    private readonly int bufferSize;
    private readonly List<IObserver<T>> observers;
    private readonly Queue<Timestamped<Notification<T>>> q;
    private readonly List<Queue<Timestamped<Notification<T>>>> qs;
    private readonly IScheduler scheduler;
    private readonly TimeSpan window;
    private bool isStopped;

    public ReplaySubject(int bufferSize, TimeSpan window, IScheduler scheduler)
    {
      if (bufferSize < 0)
        throw new ArgumentOutOfRangeException(nameof (bufferSize));
      if (window.TotalMilliseconds < 0.0)
        throw new ArgumentOutOfRangeException(nameof (window));
      this.scheduler = scheduler != null ? scheduler : throw new ArgumentNullException(nameof (scheduler));
      this.bufferSize = bufferSize;
      this.window = window;
      this.q = new Queue<Timestamped<Notification<T>>>();
      this.qs = new List<Queue<Timestamped<Notification<T>>>>();
      this.observers = new List<IObserver<T>>();
      this.isStopped = false;
    }

    public ReplaySubject(int bufferSize, TimeSpan window)
      : this(bufferSize, window, (IScheduler) Scheduler.CurrentThread)
    {
    }

    public ReplaySubject()
      : this(int.MaxValue, TimeSpan.MaxValue, (IScheduler) Scheduler.CurrentThread)
    {
    }

    public ReplaySubject(IScheduler scheduler)
      : this(int.MaxValue, TimeSpan.MaxValue, scheduler)
    {
    }

    public ReplaySubject(int bufferSize, IScheduler scheduler)
      : this(bufferSize, TimeSpan.MaxValue, scheduler)
    {
    }

    public ReplaySubject(int bufferSize)
      : this(bufferSize, TimeSpan.MaxValue, (IScheduler) Scheduler.CurrentThread)
    {
    }

    public ReplaySubject(TimeSpan window, IScheduler scheduler)
      : this(int.MaxValue, window, scheduler)
    {
      this._window = window;
    }

    public ReplaySubject(TimeSpan window)
      : this(int.MaxValue, window, (IScheduler) Scheduler.CurrentThread)
    {
    }

    public void OnNext(T value)
    {
      IObserver<T>[] iobserverArray = (IObserver<T>[]) null;
      lock (this.observers)
      {
        if (!this.isStopped)
        {
          iobserverArray = this.observers.ToArray();
          this.Enqueue((Notification<T>) new Notification<T>.OnNext(value));
        }
      }
      if (iobserverArray == null)
        return;
      foreach (IObserver<T> iobserver in iobserverArray)
        iobserver.OnNext(value);
    }

    public void OnError(Exception exception)
    {
      if (exception == null)
        throw new ArgumentNullException(nameof (exception));
      IObserver<T>[] iobserverArray = (IObserver<T>[]) null;
      lock (this.observers)
      {
        if (!this.isStopped)
        {
          iobserverArray = this.observers.ToArray();
          this.isStopped = true;
          this.Enqueue((Notification<T>) new Notification<T>.OnError(exception));
        }
      }
      if (iobserverArray == null)
        return;
      foreach (IObserver<T> iobserver in iobserverArray)
        iobserver.OnError(exception);
    }

    public void OnCompleted()
    {
      IObserver<T>[] iobserverArray = (IObserver<T>[]) null;
      lock (this.observers)
      {
        if (!this.isStopped)
        {
          iobserverArray = this.observers.ToArray();
          this.isStopped = true;
          this.Enqueue((Notification<T>) new Notification<T>.OnCompleted());
        }
      }
      if (iobserverArray == null)
        return;
      foreach (IObserver<T> iobserver in iobserverArray)
        iobserver.OnCompleted();
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
      ReplaySubject<T>.RemovableDisposable subscription = observer != null ? new ReplaySubject<T>.RemovableDisposable(this, observer) : throw new ArgumentNullException(nameof (observer));
      CompositeDisposable compositeDisposable = new CompositeDisposable(new IDisposable[1]
      {
        (IDisposable) subscription
      });
      Queue<Timestamped<Notification<T>>> myq = (Queue<Timestamped<Notification<T>>>) null;
      lock (this.observers)
      {
        this.Trim(this.scheduler.Now);
        myq = new Queue<Timestamped<Notification<T>>>((IEnumerable<Timestamped<Notification<T>>>) this.q);
        this.qs.Add(myq);
      }
      compositeDisposable.Add(this.scheduler.Schedule((Action<Action>) (self =>
      {
        Timestamped<Notification<T>> timestamped = new Timestamped<Notification<T>>();
        lock (this.observers)
        {
          if (!subscription.IsStopped && myq.Count > 0)
          {
            timestamped = myq.Dequeue();
          }
          else
          {
            this.qs.Remove(myq);
            this.observers.Add(observer);
            subscription.IsStarted = true;
          }
        }
        if (!(timestamped.Value != (Notification<T>) null))
          return;
        timestamped.Value.Accept(observer);
        self();
      })));
      return (IDisposable) compositeDisposable;
    }

    private void Trim(DateTimeOffset now)
    {
      while (this.q.Count > this.bufferSize)
        this.q.Dequeue();
      while (this.q.Count > 0 && now.Subtract(this.q.Peek().Timestamp).CompareTo(this.window) > 0)
        this.q.Dequeue();
    }

    private void Enqueue(Notification<T> n)
    {
      DateTimeOffset now = this.scheduler.Now;
      Timestamped<Notification<T>> timestamped = new Timestamped<Notification<T>>(n, now);
      this.q.Enqueue(timestamped);
      foreach (Queue<Timestamped<Notification<T>>> q in this.qs)
        q.Enqueue(timestamped);
      this.Trim(now);
    }

    private void Unsubscribe(IObserver<T> observer)
    {
      lock (this.observers)
        this.observers.Remove(observer);
    }

    private sealed class RemovableDisposable : IDisposable
    {
      private readonly IObserver<T> observer;
      private readonly ReplaySubject<T> subject;

      public RemovableDisposable(ReplaySubject<T> subject, IObserver<T> observer)
      {
        this.subject = subject;
        this.observer = observer;
      }

      public bool IsStopped { get; private set; }

      public bool IsStarted { get; set; }

      public void Dispose()
      {
        lock (this.subject.observers)
        {
          if (this.IsStarted)
            this.subject.Unsubscribe(this.observer);
          this.IsStopped = true;
        }
        GC.SuppressFinalize((object) this);
      }
    }
  }
}
