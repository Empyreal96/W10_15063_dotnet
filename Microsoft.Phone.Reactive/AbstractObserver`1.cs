// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.AbstractObserver`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal abstract class AbstractObserver<T> : IObserver<T>
  {
    private bool isStopped;

    public AbstractObserver() => this.isStopped = false;

    public void OnNext(T value)
    {
      if (this.isStopped)
        return;
      this.Next(value);
    }

    public void OnError(Exception exception)
    {
      if (exception == null)
        throw new ArgumentNullException(nameof (exception));
      if (this.isStopped)
        return;
      this.isStopped = true;
      this.Error(exception);
    }

    public void OnCompleted()
    {
      if (this.isStopped)
        return;
      this.isStopped = true;
      this.Completed();
    }

    public void Stop() => this.isStopped = true;

    protected abstract void Next(T value);

    protected abstract void Error(Exception exception);

    protected abstract void Completed();
  }
}
