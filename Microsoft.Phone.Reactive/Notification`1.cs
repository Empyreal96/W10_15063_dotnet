// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Notification`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.Phone.Reactive
{
  public abstract class Notification<T> : IEquatable<Notification<T>>
  {
    internal Notification()
    {
    }

    public abstract T Value { get; }

    public abstract bool HasValue { get; }

    public abstract Exception Exception { get; }

    public abstract NotificationKind Kind { get; }

    public abstract bool Equals(Notification<T> other);

    public override bool Equals(object obj) => this.Equals(obj as Notification<T>);

    public static bool operator ==(Notification<T> left, Notification<T> right)
    {
      if ((object) left == (object) right)
        return true;
      return (object) left != null && (object) right != null && left.Equals(right);
    }

    public static bool operator !=(Notification<T> left, Notification<T> right) => !(left == right);

    public override int GetHashCode() => base.GetHashCode();

    public abstract void Accept(IObserver<T> observer);

    public abstract TResult Accept<TResult>(IObserver<T, TResult> observer);

    public abstract void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted);

    public abstract TResult Accept<TResult>(
      Func<T, TResult> onNext,
      Func<Exception, TResult> onError,
      Func<TResult> onCompleted);

    [DebuggerDisplay("OnCompleted()")]
    public sealed class OnCompleted : Notification<T>
    {
      public override T Value => throw new InvalidOperationException("Operation has been canceled.");

      public override Exception Exception => (Exception) null;

      public override bool HasValue => false;

      public override NotificationKind Kind => NotificationKind.OnCompleted;

      public override int GetHashCode() => 8510;

      public override bool Equals(Notification<T> other) => other is Notification<T>.OnCompleted;

      public override string ToString() => "OnCompleted()";

      public override void Accept(IObserver<T> observer) => observer.OnCompleted();

      public override TResult Accept<TResult>(IObserver<T, TResult> observer) => observer.OnCompleted();

      public override void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted) => onCompleted();

      public override TResult Accept<TResult>(
        Func<T, TResult> onNext,
        Func<Exception, TResult> onError,
        Func<TResult> onCompleted)
      {
        return onCompleted();
      }
    }

    [DebuggerDisplay("OnError({Exception})")]
    public sealed class OnError : Notification<T>
    {
      private readonly Exception exception;

      public OnError(Exception exception) => this.exception = exception != null ? exception : throw new ArgumentNullException(nameof (exception));

      public override T Value => throw this.exception.PrepareForRethrow();

      public override Exception Exception => this.exception;

      public override bool HasValue => false;

      public override NotificationKind Kind => NotificationKind.OnError;

      public override int GetHashCode() => this.Exception.GetHashCode();

      public override bool Equals(Notification<T> other)
      {
        Notification<T>.OnError onError = other as Notification<T>.OnError;
        return !((Notification<T>) onError == (Notification<T>) null) && object.Equals((object) this.Exception, (object) onError.Exception);
      }

      public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "OnError({0})", (object) this.Exception.GetType().FullName);

      public override void Accept(IObserver<T> observer) => observer.OnError(this.Exception);

      public override TResult Accept<TResult>(IObserver<T, TResult> observer) => observer.OnError(this.Exception);

      public override void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted) => onError(this.Exception);

      public override TResult Accept<TResult>(
        Func<T, TResult> onNext,
        Func<Exception, TResult> onError,
        Func<TResult> onCompleted)
      {
        return onError(this.Exception);
      }
    }

    [DebuggerDisplay("OnNext({Value})")]
    public sealed class OnNext : Notification<T>
    {
      private readonly T value;

      public OnNext(T value) => this.value = value;

      public override T Value => this.value;

      public override Exception Exception => (Exception) null;

      public override bool HasValue => true;

      public override NotificationKind Kind => NotificationKind.OnNext;

      public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode(this.Value);

      public override bool Equals(Notification<T> other)
      {
        Notification<T>.OnNext onNext = other as Notification<T>.OnNext;
        return !((Notification<T>) onNext == (Notification<T>) null) && EqualityComparer<T>.Default.Equals(this.Value, onNext.Value);
      }

      public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "OnNext({0})", (object) this.Value);

      public override void Accept(IObserver<T> observer) => observer.OnNext(this.Value);

      public override TResult Accept<TResult>(IObserver<T, TResult> observer) => observer.OnNext(this.Value);

      public override void Accept(Action<T> onNext, Action<Exception> onError, Action onCompleted) => onNext(this.Value);

      public override TResult Accept<TResult>(
        Func<T, TResult> onNext,
        Func<Exception, TResult> onError,
        Func<TResult> onCompleted)
      {
        return onNext(this.Value);
      }
    }
  }
}
