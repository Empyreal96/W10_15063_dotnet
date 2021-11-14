// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Pattern`2
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  public class Pattern<T1, T2> : Pattern
  {
    internal Pattern(IObservable<T1> first, IObservable<T2> second)
    {
      this.First = first;
      this.Second = second;
    }

    internal IObservable<T1> First { get; private set; }

    internal IObservable<T2> Second { get; private set; }

    public Pattern<T1, T2, T3> And<T3>(IObservable<T3> other) => new Pattern<T1, T2, T3>(this.First, this.Second, other);

    public Plan<TResult> Then<TResult>(Func<T1, T2, TResult> selector) => (Plan<TResult>) new Plan<T1, T2, TResult>(this, selector);
  }
}
