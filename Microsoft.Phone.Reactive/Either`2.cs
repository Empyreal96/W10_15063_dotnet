// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Either`2
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Phone.Reactive
{
  internal abstract class Either<TLeft, TRight>
  {
    private Either()
    {
    }

    public static Either<TLeft, TRight> CreateLeft(TLeft value) => (Either<TLeft, TRight>) new Either<TLeft, TRight>.Left(value);

    public static Either<TLeft, TRight> CreateRight(TRight value) => (Either<TLeft, TRight>) new Either<TLeft, TRight>.Right(value);

    public abstract TResult Switch<TResult>(
      Func<TLeft, TResult> caseLeft,
      Func<TRight, TResult> caseRight);

    public abstract void Switch(Action<TLeft> caseLeft, Action<TRight> caseRight);

    public sealed class Left : Either<TLeft, TRight>, IEquatable<Either<TLeft, TRight>.Left>
    {
      public Left(TLeft value) => this.Value = value;

      public TLeft Value { get; private set; }

      public bool Equals(Either<TLeft, TRight>.Left other)
      {
        if (other == this)
          return true;
        return other != null && EqualityComparer<TLeft>.Default.Equals(this.Value, other.Value);
      }

      public override TResult Switch<TResult>(
        Func<TLeft, TResult> caseLeft,
        Func<TRight, TResult> caseRight)
      {
        return caseLeft(this.Value);
      }

      public override void Switch(Action<TLeft> caseLeft, Action<TRight> caseRight) => caseLeft(this.Value);

      public override bool Equals(object obj) => this.Equals(obj as Either<TLeft, TRight>.Left);

      public override int GetHashCode() => EqualityComparer<TLeft>.Default.GetHashCode(this.Value);

      public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Left({0})", (object) this.Value);
    }

    public sealed class Right : Either<TLeft, TRight>, IEquatable<Either<TLeft, TRight>.Right>
    {
      public Right(TRight value) => this.Value = value;

      public TRight Value { get; private set; }

      public bool Equals(Either<TLeft, TRight>.Right other)
      {
        if (other == this)
          return true;
        return other != null && EqualityComparer<TRight>.Default.Equals(this.Value, other.Value);
      }

      public override TResult Switch<TResult>(
        Func<TLeft, TResult> caseLeft,
        Func<TRight, TResult> caseRight)
      {
        return caseRight(this.Value);
      }

      public override void Switch(Action<TLeft> caseLeft, Action<TRight> caseRight) => caseRight(this.Value);

      public override bool Equals(object obj) => this.Equals(obj as Either<TLeft, TRight>.Right);

      public override int GetHashCode() => EqualityComparer<TRight>.Default.GetHashCode(this.Value);

      public override string ToString() => string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Right({0})", (object) this.Value);
    }
  }
}
