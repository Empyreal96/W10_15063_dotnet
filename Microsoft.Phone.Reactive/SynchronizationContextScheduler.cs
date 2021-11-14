// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.SynchronizationContextScheduler
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  public class SynchronizationContextScheduler : IScheduler
  {
    private readonly SynchronizationContext context;

    public SynchronizationContextScheduler(SynchronizationContext context) => this.context = context;

    public DateTimeOffset Now => Scheduler.Now;

    public IDisposable Schedule(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      BooleanDisposable d = new BooleanDisposable();
      this.context.Post((SendOrPostCallback) (_ =>
      {
        if (d.IsDisposed)
          return;
        action();
      }), (object) null);
      return (IDisposable) d;
    }

    public IDisposable Schedule(Action action, TimeSpan dueTime)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      TimeSpan dueTime1 = Scheduler.Normalize(dueTime);
      CompositeDisposable g = new CompositeDisposable(new IDisposable[0]);
      g.Add(ThreadPoolScheduler.Instance.Schedule((Action) (() => g.Add(this.Schedule(action))), dueTime1));
      return (IDisposable) g;
    }
  }
}
