// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ConnectableObservable`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public class ConnectableObservable<T> : IConnectableObservable<T>, IObservable<T>
  {
    private readonly object gate;
    private readonly IObservable<T> source;
    private readonly ISubject<T> subject;
    private bool hasSubscription;
    private IDisposable subscription;

    public ConnectableObservable(IObservable<T> source, ISubject<T> subject)
    {
      this.subject = subject;
      this.source = source.AsObservable<T>();
      this.gate = new object();
    }

    public ConnectableObservable(IObservable<T> source)
      : this(source, (ISubject<T>) new Subject<T>())
    {
    }

    public IDisposable Connect()
    {
      CompositeDisposable compositeDisposable = new CompositeDisposable(new IDisposable[1]
      {
        Disposable.Create((Action) (() =>
        {
          lock (this.gate)
            this.hasSubscription = false;
        }))
      });
      bool flag = false;
      IDisposable disposable = (IDisposable) null;
      lock (this.gate)
      {
        if (!this.hasSubscription)
        {
          this.hasSubscription = true;
          this.subscription = (IDisposable) compositeDisposable;
          flag = true;
        }
        disposable = this.subscription;
      }
      if (flag)
        compositeDisposable.Add(this.source.Subscribe((IObserver<T>) this.subject));
      return disposable;
    }

    public IDisposable Subscribe(IObserver<T> observer) => ((IObservable<T>) this.subject).Subscribe(observer);
  }
}
