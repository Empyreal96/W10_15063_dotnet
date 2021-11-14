// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ObservableExtensions
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public static class ObservableExtensions
  {
    public static IDisposable Subscribe<TSource>(this IObservable<TSource> source) => source != null ? source.Subscribe<TSource>((Action<TSource>) (_ => { }), (Action<Exception>) (exception =>
    {
      throw exception.PrepareForRethrow();
    }), (Action) (() => { })) : throw new ArgumentNullException(nameof (source));

    public static IDisposable Subscribe<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      return source.Subscribe<TSource>(onNext, (Action<Exception>) (exception =>
      {
        throw exception.PrepareForRethrow();
      }), (Action) (() => { }));
    }

    public static IDisposable Subscribe<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action<Exception> onError)
    {
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      return source.Subscribe<TSource>(onNext, onError, (Action) (() => { }));
    }

    public static IDisposable Subscribe<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action onCompleted)
    {
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return source.Subscribe<TSource>(onNext, (Action<Exception>) (exception =>
      {
        throw exception.PrepareForRethrow();
      }), onCompleted);
    }

    public static IDisposable Subscribe<TSource>(
      this IObservable<TSource> source,
      Action<TSource> onNext,
      Action<Exception> onError,
      Action onCompleted)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (onNext == null)
        throw new ArgumentNullException(nameof (onNext));
      if (onError == null)
        throw new ArgumentNullException(nameof (onError));
      if (onCompleted == null)
        throw new ArgumentNullException(nameof (onCompleted));
      return source.Subscribe((IObserver<TSource>) new AnonymousObserver<TSource>(onNext, onError, onCompleted));
    }
  }
}
