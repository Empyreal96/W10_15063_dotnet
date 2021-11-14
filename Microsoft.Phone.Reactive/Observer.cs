// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Observer
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public static class Observer
  {
    public static IObserver<T> ToObserver<T>(this Action<Notification<T>> handler)
    {
      if (handler == null)
        throw new ArgumentNullException(nameof (handler));
      return (IObserver<T>) new AnonymousObserver<T>((Action<T>) (x => handler((Notification<T>) new Notification<T>.OnNext(x))), (Action<Exception>) (exception => handler((Notification<T>) new Notification<T>.OnError(exception))), (Action) (() => handler((Notification<T>) new Notification<T>.OnCompleted())));
    }

    public static Action<Notification<T>> ToNotifier<T>(this IObserver<T> observer) => observer != null ? (Action<Notification<T>>) (n => n.Accept(observer)) : throw new ArgumentNullException(nameof (observer));

    public static IObserver<T> Create<T>(Action<T> onNext) => onNext != null ? (IObserver<T>) new AnonymousObserver<T>(onNext, (Action<Exception>) (e =>
    {
      throw e.PrepareForRethrow();
    }), (Action) (() => { })) : throw new ArgumentNullException(nameof (onNext));

    public static IObserver<T> Create<T>(Action<T> onNext, Action<Exception> onError)
    {
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      return onError != null ? (IObserver<T>) new AnonymousObserver<T>(onNext, onError, (Action) (() => { })) : throw new ArgumentNullException(nameof (onError));
    }

    public static IObserver<T> Create<T>(Action<T> onNext, Action onCompleted)
    {
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return (IObserver<T>) new AnonymousObserver<T>(onNext, (Action<Exception>) (e =>
      {
        throw e.PrepareForRethrow();
      }), onCompleted);
    }

    public static IObserver<T> Create<T>(
      Action<T> onNext,
      Action<Exception> onError,
      Action onCompleted)
    {
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return (IObserver<T>) new AnonymousObserver<T>(onNext, onError, onCompleted);
    }

    public static IObserver<TSource> AsObserver<TSource>(this IObserver<TSource> observer) => observer != null ? (IObserver<TSource>) new AnonymousObserver<TSource>(new Action<TSource>(observer.OnNext), new Action<Exception>(observer.OnError), new Action(observer.OnCompleted)) : throw new ArgumentNullException(nameof (observer));
  }
}
