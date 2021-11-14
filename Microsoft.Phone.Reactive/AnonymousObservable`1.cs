// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.AnonymousObservable`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal class AnonymousObservable<T> : IObservable<T>
  {
    private readonly Func<IObserver<T>, IDisposable> subscribe;

    public AnonymousObservable(Func<IObserver<T>, IDisposable> subscribe) => this.subscribe = subscribe;

    public IDisposable Subscribe(IObserver<T> observer)
    {
      AnonymousObservable<T>.AutoDetachObserver autoDetachObserver = observer != null ? observer as AnonymousObservable<T>.AutoDetachObserver : throw new ArgumentNullException(nameof (observer));
      if (autoDetachObserver == null)
        autoDetachObserver = new AnonymousObservable<T>.AutoDetachObserver(observer);
      AnonymousObservable<T>.Disposable subscription = new AnonymousObservable<T>.Disposable(autoDetachObserver);
      autoDetachObserver.Add((IDisposable) subscription);
      Scheduler.CurrentThread.EnsureTrampoline((Action) (() => subscription.Set(this.subscribe((IObserver<T>) autoDetachObserver))));
      return (IDisposable) subscription;
    }

    private class AutoDetachObserver : AbstractObserver<T>
    {
      private readonly CompositeDisposable group = new CompositeDisposable(new IDisposable[0]);
      private readonly IObserver<T> observer;

      public AutoDetachObserver(IObserver<T> observer) => this.observer = observer;

      public void Add(IDisposable disposable) => this.group.Add(disposable);

      protected override void Next(T value) => this.observer.OnNext(value);

      protected override void Error(Exception exception)
      {
        this.observer.OnError(exception);
        this.group.Dispose();
      }

      protected override void Completed()
      {
        this.observer.OnCompleted();
        this.group.Dispose();
      }
    }

    private sealed class Disposable : IDisposable
    {
      private readonly object gate = new object();
      private readonly AnonymousObservable<T>.AutoDetachObserver observer;
      private IDisposable disposable;
      private bool disposed;

      public Disposable(AnonymousObservable<T>.AutoDetachObserver observer) => this.observer = observer;

      public void Dispose()
      {
        this.observer.Stop();
        IDisposable disposable = (IDisposable) null;
        lock (this.gate)
        {
          if (!this.disposed)
          {
            this.disposed = true;
            disposable = this.disposable;
          }
        }
        disposable?.Dispose();
      }

      public void Set(IDisposable disposable)
      {
        if (disposable == null)
          throw new ArgumentNullException(nameof (disposable));
        bool flag = false;
        lock (this.gate)
        {
          if (!this.disposed)
            this.disposable = disposable;
          else
            flag = true;
        }
        if (!flag)
          return;
        disposable.Dispose();
      }
    }
  }
}
