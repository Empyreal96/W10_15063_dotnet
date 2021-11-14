// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.PushPullAdapter`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  internal sealed class PushPullAdapter<T> : IObserver<T>, IEnumerator<T>, IEnumerator, IDisposable
  {
    private readonly Action dispose;
    private readonly Func<Notification<T>> moveNext;
    private readonly Action<Notification<T>> yield;
    private Notification<T> current;
    private bool done;

    public PushPullAdapter(
      Action<Notification<T>> yield,
      Func<Notification<T>> moveNext,
      Action dispose)
    {
      this.yield = yield;
      this.moveNext = moveNext;
      this.dispose = dispose;
    }

    public T Current => this.current.Value;

    public void Dispose() => this.dispose();

    object IEnumerator.Current => (object) this.Current;

    public bool MoveNext()
    {
      if (!this.done)
      {
        this.current = this.moveNext();
        this.done = (uint) this.current.Kind > 0U;
      }
      return this.current.Exception == null ? this.current.HasValue : throw this.current.Exception.PrepareForRethrow();
    }

    public void Reset() => throw new NotSupportedException();

    public void OnNext(T value) => this.yield((Notification<T>) new Notification<T>.OnNext(value));

    public void OnError(Exception exception) => this.yield((Notification<T>) new Notification<T>.OnError(exception));

    public void OnCompleted() => this.yield((Notification<T>) new Notification<T>.OnCompleted());
  }
}
