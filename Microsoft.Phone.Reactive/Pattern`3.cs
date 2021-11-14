// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Pattern`3
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public class Pattern<T1, T2, T3> : Pattern
  {
    internal Pattern(IObservable<T1> first, IObservable<T2> second, IObservable<T3> third)
    {
      this.First = first;
      this.Second = second;
      this.Third = third;
    }

    internal IObservable<T1> First { get; private set; }

    internal IObservable<T2> Second { get; private set; }

    internal IObservable<T3> Third { get; private set; }

    public Pattern<T1, T2, T3, T4> And<T4>(IObservable<T4> other) => new Pattern<T1, T2, T3, T4>(this.First, this.Second, this.Third, other);

    public Plan<TResult> Then<TResult>(Func<T1, T2, T3, TResult> selector) => (Plan<TResult>) new Plan<T1, T2, T3, TResult>(this, selector);
  }
}
