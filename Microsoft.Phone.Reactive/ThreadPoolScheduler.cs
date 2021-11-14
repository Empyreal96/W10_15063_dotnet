// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ThreadPoolScheduler
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  public sealed class ThreadPoolScheduler : IScheduler
  {
    internal static readonly ThreadPoolScheduler Instance = new ThreadPoolScheduler();
    internal static readonly object gate = new object();
    internal static readonly Dictionary<Timer, object> timers = new Dictionary<Timer, object>();

    private ThreadPoolScheduler()
    {
    }

    public DateTimeOffset Now => Scheduler.Now;

    public IDisposable Schedule(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      BooleanDisposable cancelable = new BooleanDisposable();
      ThreadPool.QueueUserWorkItem((WaitCallback) (_ =>
      {
        if (cancelable.IsDisposed)
          return;
        action();
      }), (object) null);
      return (IDisposable) cancelable;
    }

    public IDisposable Schedule(Action action, TimeSpan dueTime)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      TimeSpan dueTime1 = Scheduler.Normalize(dueTime);
      bool hasAdded = false;
      bool hasRemoved = false;
      Timer timer = (Timer) null;
      timer = new Timer((TimerCallback) (_ =>
      {
        lock (ThreadPoolScheduler.gate)
        {
          if (hasAdded && timer != null)
            ThreadPoolScheduler.timers.Remove(timer);
          hasRemoved = true;
        }
        timer = (Timer) null;
        action();
      }), (object) null, dueTime1, TimeSpan.FromMilliseconds(-1.0));
      lock (ThreadPoolScheduler.gate)
      {
        if (!hasRemoved)
        {
          ThreadPoolScheduler.timers.Add(timer, (object) null);
          hasAdded = true;
        }
      }
      return (IDisposable) new AnonymousDisposable((Action) (() =>
      {
        Timer key = timer;
        if (key != null)
        {
          key.Dispose();
          lock (ThreadPoolScheduler.gate)
          {
            ThreadPoolScheduler.timers.Remove(key);
            hasRemoved = true;
          }
        }
        timer = (Timer) null;
      }));
    }
  }
}
