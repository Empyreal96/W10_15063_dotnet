// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Scheduler
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Windows;

namespace Microsoft.Phone.Reactive
{
  public static class Scheduler
  {
    private static readonly DispatcherScheduler s_dispatcher = new DispatcherScheduler(Deployment.Current.Dispatcher);

    internal static DateTimeOffset Now => DateTimeOffset.Now;

    internal static TimeSpan Normalize(TimeSpan timeSpan) => timeSpan.Ticks < 0L ? TimeSpan.Zero : timeSpan;

    public static ImmediateScheduler Immediate => ImmediateScheduler.Instance;

    public static CurrentThreadScheduler CurrentThread => CurrentThreadScheduler.Instance;

    public static ThreadPoolScheduler ThreadPool => ThreadPoolScheduler.Instance;

    public static NewThreadScheduler NewThread => NewThreadScheduler.Instance;

    public static TaskPoolScheduler TaskPool => TaskPoolScheduler.Instance;

    public static DispatcherScheduler Dispatcher => Scheduler.s_dispatcher;

    public static IDisposable Schedule(
      this IScheduler scheduler,
      Action action,
      DateTimeOffset dueTime)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      return scheduler.Schedule(action, dueTime - scheduler.Now);
    }

    public static IDisposable Schedule(this IScheduler scheduler, Action<Action> action)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      CompositeDisposable group = new CompositeDisposable(new IDisposable[0]);
      Action recursiveAction = (Action) null;
      object gate = new object();
      AsyncLock asyncLock = new AsyncLock();
      recursiveAction = (Action) (() => asyncLock.Wait((Action) (() => action((Action) (() =>
      {
        // ISSUE: variable of a compiler-generated type
        Scheduler.\u003C\u003Ec__DisplayClass17_0 cDisplayClass170 = this;
        bool isAdded = false;
        bool isDone = false;
        IDisposable d = (IDisposable) null;
        d = scheduler.Schedule((Action) (() =>
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass170.recursiveAction();
          // ISSUE: reference to a compiler-generated field
          lock (cDisplayClass170.gate)
          {
            if (isAdded)
            {
              // ISSUE: reference to a compiler-generated field
              cDisplayClass170.group.Remove(d);
            }
            else
              isDone = true;
          }
        }));
        lock (gate)
        {
          if (isDone)
            return;
          group.Add(d);
          isAdded = true;
        }
      })))));
      group.Add(scheduler.Schedule(recursiveAction));
      return (IDisposable) group;
    }

    public static IDisposable Schedule(
      this IScheduler scheduler,
      Action<Action<TimeSpan>> action,
      TimeSpan dueTime)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      CompositeDisposable group = new CompositeDisposable(new IDisposable[0]);
      Action recursiveAction = (Action) null;
      object gate = new object();
      AsyncLock asyncLock = new AsyncLock();
      recursiveAction = (Action) (() => asyncLock.Wait((Action) (() => action((Action<TimeSpan>) (dt =>
      {
        // ISSUE: variable of a compiler-generated type
        Scheduler.\u003C\u003Ec__DisplayClass18_0 cDisplayClass180 = this;
        bool isAdded = false;
        bool isDone = false;
        IDisposable d = (IDisposable) null;
        d = scheduler.Schedule((Action) (() =>
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass180.recursiveAction();
          // ISSUE: reference to a compiler-generated field
          lock (cDisplayClass180.gate)
          {
            if (isAdded)
            {
              // ISSUE: reference to a compiler-generated field
              cDisplayClass180.group.Remove(d);
            }
            else
              isDone = true;
          }
        }), dt);
        lock (gate)
        {
          if (isDone)
            return;
          group.Add(d);
          isAdded = true;
        }
      })))));
      group.Add(scheduler.Schedule(recursiveAction, dueTime));
      return (IDisposable) group;
    }

    public static IDisposable Schedule(
      this IScheduler scheduler,
      Action<Action<DateTimeOffset>> action,
      DateTimeOffset dueTime)
    {
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      CompositeDisposable group = new CompositeDisposable(new IDisposable[0]);
      Action recursiveAction = (Action) null;
      object gate = new object();
      AsyncLock asyncLock = new AsyncLock();
      recursiveAction = (Action) (() => asyncLock.Wait((Action) (() => action((Action<DateTimeOffset>) (dt =>
      {
        // ISSUE: variable of a compiler-generated type
        Scheduler.\u003C\u003Ec__DisplayClass19_0 cDisplayClass190 = this;
        bool isAdded = false;
        bool isDone = false;
        IDisposable d = (IDisposable) null;
        d = scheduler.Schedule((Action) (() =>
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass190.recursiveAction();
          // ISSUE: reference to a compiler-generated field
          lock (cDisplayClass190.gate)
          {
            if (isAdded)
            {
              // ISSUE: reference to a compiler-generated field
              cDisplayClass190.group.Remove(d);
            }
            else
              isDone = true;
          }
        }), dt);
        lock (gate)
        {
          if (isDone)
            return;
          group.Add(d);
          isAdded = true;
        }
      })))));
      group.Add(scheduler.Schedule(recursiveAction, dueTime));
      return (IDisposable) group;
    }
  }
}
