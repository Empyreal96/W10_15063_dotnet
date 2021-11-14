// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ScheduledDisposable
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  public class ScheduledDisposable : IDisposable
  {
    private int disposed;

    public ScheduledDisposable(IScheduler scheduler, IDisposable disposable)
    {
      this.Scheduler = scheduler;
      this.Disposable = disposable;
    }

    public IDisposable Disposable { get; private set; }

    public IScheduler Scheduler { get; private set; }

    public void Dispose() => this.Scheduler.Schedule(new Action(this.DisposeInner));

    private void DisposeInner()
    {
      if (Interlocked.Exchange(ref this.disposed, 1) != 0)
        return;
      this.Disposable.Dispose();
    }
  }
}
