// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.DispatcherScheduler
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Windows.Threading;

namespace Microsoft.Phone.Reactive
{
  public class DispatcherScheduler : IScheduler
  {
    private readonly Dispatcher dispatcher;

    public DispatcherScheduler(Dispatcher dispatcher) => this.dispatcher = dispatcher != null ? dispatcher : throw new ArgumentNullException(nameof (dispatcher));

    public Dispatcher Dispatcher => this.dispatcher;

    public DateTimeOffset Now => Scheduler.Now;

    public IDisposable Schedule(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      BooleanDisposable cancelable = new BooleanDisposable();
      this.dispatcher.BeginInvoke((Action) (() =>
      {
        if (cancelable.IsDisposed)
          return;
        action();
      }));
      return (IDisposable) cancelable;
    }

    public IDisposable Schedule(Action action, TimeSpan dueTime)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      TimeSpan timeSpan = Scheduler.Normalize(dueTime);
      DispatcherTimer timer = new DispatcherTimer();
      timer.Tick += (EventHandler) ((s, e) =>
      {
        timer?.Stop();
        timer = (DispatcherTimer) null;
        action();
      });
      timer.Interval = timeSpan;
      timer.Start();
      return (IDisposable) new AnonymousDisposable((Action) (() =>
      {
        timer?.Stop();
        timer = (DispatcherTimer) null;
      }));
    }
  }
}
