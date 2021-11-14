// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Notification
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public static class Notification
  {
    public static IObservable<T> ToObservable<T>(this Notification<T> notification) => !(notification == (Notification<T>) null) ? notification.ToObservable<T>((IScheduler) Scheduler.CurrentThread) : throw new ArgumentNullException(nameof (notification));

    public static IObservable<T> ToObservable<T>(
      this Notification<T> notification,
      IScheduler scheduler)
    {
      if (notification == (Notification<T>) null)
        throw new ArgumentNullException(nameof (notification));
      if (scheduler == null)
        throw new ArgumentNullException(nameof (scheduler));
      return (IObservable<T>) new AnonymousObservable<T>((Func<IObserver<T>, IDisposable>) (observer => scheduler.Schedule((Action) (() =>
      {
        notification.Accept(observer);
        if (notification.Kind != NotificationKind.OnNext)
          return;
        observer.OnCompleted();
      }))));
    }
  }
}
