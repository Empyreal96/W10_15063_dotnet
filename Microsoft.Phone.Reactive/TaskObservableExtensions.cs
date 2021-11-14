// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.TaskObservableExtensions
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading.Tasks;

namespace Microsoft.Phone.Reactive
{
  public static class TaskObservableExtensions
  {
    public static IObservable<Unit> ToObservable(this Task task)
    {
      if (task == null)
        throw new ArgumentNullException(nameof (task));
      return (IObservable<Unit>) new AnonymousObservable<Unit>((Func<IObserver<Unit>, IDisposable>) (observer =>
      {
        CancellationDisposable cancellationDisposable = new CancellationDisposable();
        task.ContinueWith((Action<Task>) (t =>
        {
          switch (t.Status - 5)
          {
            case 0:
              observer.OnNext(new Unit());
              observer.OnCompleted();
              break;
            case 1:
              observer.OnCompleted();
              break;
            case 2:
              observer.OnError((Exception) t.Exception);
              break;
          }
        }), cancellationDisposable.Token);
        return (IDisposable) cancellationDisposable;
      }));
    }

    public static IObservable<TResult> ToObservable<TResult>(this Task<TResult> task)
    {
      if (task == null)
        throw new ArgumentNullException(nameof (task));
      return (IObservable<TResult>) new AnonymousObservable<TResult>((Func<IObserver<TResult>, IDisposable>) (observer =>
      {
        CancellationDisposable cancellationDisposable = new CancellationDisposable();
        task.ContinueWith((Action<Task<TResult>>) (t =>
        {
          switch (((Task) t).Status - 5)
          {
            case 0:
              observer.OnNext(t.Result);
              observer.OnCompleted();
              break;
            case 1:
              observer.OnCompleted();
              break;
            case 2:
              observer.OnError((Exception) ((Task) t).Exception);
              break;
          }
        }), cancellationDisposable.Token);
        return (IDisposable) cancellationDisposable;
      }));
    }
  }
}
