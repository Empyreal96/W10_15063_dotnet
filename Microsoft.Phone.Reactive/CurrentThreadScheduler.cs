// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.CurrentThreadScheduler
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  public sealed class CurrentThreadScheduler : IScheduler
  {
    internal static readonly CurrentThreadScheduler Instance = new CurrentThreadScheduler();
    private static Dictionary<int, PriorityQueue<ScheduledItem>> queues = new Dictionary<int, PriorityQueue<ScheduledItem>>();

    private static PriorityQueue<ScheduledItem> GetQueue()
    {
      lock (CurrentThreadScheduler.queues)
      {
        PriorityQueue<ScheduledItem> priorityQueue = (PriorityQueue<ScheduledItem>) null;
        return CurrentThreadScheduler.queues.TryGetValue(Thread.CurrentThread.ManagedThreadId, out priorityQueue) ? priorityQueue : (PriorityQueue<ScheduledItem>) null;
      }
    }

    private static void SetQueue(PriorityQueue<ScheduledItem> newQueue)
    {
      lock (CurrentThreadScheduler.queues)
      {
        if (newQueue == null)
          CurrentThreadScheduler.queues.Remove(Thread.CurrentThread.ManagedThreadId);
        else
          CurrentThreadScheduler.queues[Thread.CurrentThread.ManagedThreadId] = newQueue;
      }
    }

    private CurrentThreadScheduler()
    {
    }

    public DateTimeOffset Now => Scheduler.Now;

    public IDisposable Schedule(Action action) => action != null ? this.Schedule(action, TimeSpan.Zero) : throw new ArgumentNullException(nameof (action));

    public IDisposable Schedule(Action action, TimeSpan dueTime)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      DateTimeOffset dueTime1 = this.Now + dueTime;
      ScheduledItem scheduledItem = new ScheduledItem(action, dueTime1);
      PriorityQueue<ScheduledItem> queue = CurrentThreadScheduler.GetQueue();
      if (queue == null)
      {
        using (CurrentThreadScheduler.Trampoline trampoline = new CurrentThreadScheduler.Trampoline())
        {
          CurrentThreadScheduler.GetQueue().Enqueue(scheduledItem);
          trampoline.Run();
        }
      }
      else
        queue.Enqueue(scheduledItem);
      return scheduledItem.GetDisposable();
    }

    public void EnsureTrampoline(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      if (CurrentThreadScheduler.GetQueue() == null)
      {
        using (CurrentThreadScheduler.Trampoline trampoline = new CurrentThreadScheduler.Trampoline())
        {
          action();
          trampoline.Run();
        }
      }
      else
        action();
    }

    private class Trampoline : IDisposable
    {
      public Trampoline() => CurrentThreadScheduler.SetQueue(new PriorityQueue<ScheduledItem>());

      public void Dispose() => CurrentThreadScheduler.SetQueue((PriorityQueue<ScheduledItem>) null);

      public void Run()
      {
        PriorityQueue<ScheduledItem> queue = CurrentThreadScheduler.GetQueue();
        while (queue.Count > 0)
        {
          ScheduledItem scheduledItem = queue.Dequeue();
          if (!scheduledItem.IsCanceled)
          {
            TimeSpan timeout = scheduledItem.DueTime - Scheduler.Now;
            if (timeout.CompareTo(TimeSpan.Zero) > 0)
              Thread.Sleep(timeout);
            if (!scheduledItem.IsCanceled)
              scheduledItem.Action();
          }
        }
      }
    }
  }
}
