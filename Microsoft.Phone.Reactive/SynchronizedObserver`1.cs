// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.SynchronizedObserver`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal class SynchronizedObserver<T> : IObserver<T>
  {
    private readonly object gate;
    private readonly IObserver<T> underlyingObserver;

    public SynchronizedObserver(IObserver<T> underlyingObserver, object gate)
    {
      this.gate = gate;
      this.underlyingObserver = underlyingObserver;
    }

    public void OnNext(T value)
    {
      lock (this.gate)
        this.underlyingObserver.OnNext(value);
    }

    public void OnError(Exception exception)
    {
      if (exception == null)
        throw new ArgumentNullException(nameof (exception));
      lock (this.gate)
        this.underlyingObserver.OnError(exception);
    }

    public void OnCompleted()
    {
      lock (this.gate)
        this.underlyingObserver.OnCompleted();
    }
  }
}
