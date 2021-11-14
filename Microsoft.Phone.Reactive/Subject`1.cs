// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Subject`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  public class Subject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>
  {
    private readonly List<IObserver<T>> observers;
    private bool isStopped;

    public Subject()
    {
      this.observers = new List<IObserver<T>>();
      this.isStopped = false;
    }

    public void OnNext(T value)
    {
      IObserver<T>[] iobserverArray = (IObserver<T>[]) null;
      lock (this.observers)
      {
        if (!this.isStopped)
          iobserverArray = this.observers.ToArray();
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
        }
      }
      if (iobserverArray == null)
        return;
      foreach (IObserver<T> iobserver in iobserverArray)
        iobserver.OnCompleted();
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
      if (observer == null)
        throw new ArgumentNullException(nameof (observer));
      lock (this.observers)
      {
        if (this.isStopped)
          return Disposable.Empty;
        this.observers.Add(observer);
        return (IDisposable) new Subject<T>.RemovableDisposable(this, observer);
      }
    }

    private void Unsubscribe(IObserver<T> observer)
    {
      lock (this.observers)
        this.observers.Remove(observer);
    }

    private sealed class RemovableDisposable : IDisposable
    {
      private readonly IObserver<T> observer;
      private readonly Subject<T> subject;

      public RemovableDisposable(Subject<T> subject, IObserver<T> observer)
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
