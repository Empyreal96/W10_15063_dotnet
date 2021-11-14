// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.JoinObserver`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  internal sealed class JoinObserver<T> : 
    AbstractObserver<Notification<T>>,
    IJoinObserver,
    IDisposable
  {
    private readonly List<ActivePlan> activePlans;
    private readonly Action<Exception> onError;
    private readonly IObservable<T> source;
    private readonly MutableDisposable subscription;
    private object gate;
    private bool initialized;
    private bool isDisposed;

    public JoinObserver(IObservable<T> source, Action<Exception> onError)
    {
      this.source = source;
      this.onError = onError;
      this.Queue = new System.Collections.Generic.Queue<Notification<T>>();
      this.subscription = new MutableDisposable();
      this.activePlans = new List<ActivePlan>();
    }

    public System.Collections.Generic.Queue<Notification<T>> Queue { get; private set; }

    public void Subscribe(object gate)
    {
      this.gate = gate;
      this.initialized = true;
      this.subscription.Disposable = this.source.Materialize<T>().Subscribe((IObserver<Notification<T>>) this);
    }

    public void Dequeue() => this.Queue.Dequeue();

    public void Dispose()
    {
      if (this.isDisposed)
        return;
      this.isDisposed = true;
      this.subscription.Dispose();
    }

    public void AddActivePlan(ActivePlan activePlan) => this.activePlans.Add(activePlan);

    protected override void Next(Notification<T> n)
    {
      lock (this.gate)
      {
        if (this.isDisposed)
          return;
        if (n.Kind == NotificationKind.OnError)
        {
          this.onError(n.Exception);
        }
        else
        {
          this.Queue.Enqueue(n);
          foreach (ActivePlan activePlan in this.activePlans.ToArray())
            activePlan.Match();
        }
      }
    }

    protected override void Error(Exception exception)
    {
    }

    protected override void Completed()
    {
    }

    internal void RemoveActivePlan(ActivePlan activePlan)
    {
      this.activePlans.Remove(activePlan);
      if (this.activePlans.Count != 0)
        return;
      this.Dispose();
    }
  }
}
