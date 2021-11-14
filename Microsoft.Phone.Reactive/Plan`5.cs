// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Plan`5
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  internal class Plan<T1, T2, T3, T4, TResult> : Plan<TResult>
  {
    internal Plan(Pattern<T1, T2, T3, T4> expression, Func<T1, T2, T3, T4, TResult> selector)
    {
      this.Expression = expression;
      this.Selector = selector;
    }

    internal Pattern<T1, T2, T3, T4> Expression { get; private set; }

    internal Func<T1, T2, T3, T4, TResult> Selector { get; private set; }

    internal override ActivePlan Activate(
      Dictionary<object, IJoinObserver> externalSubscriptions,
      IObserver<TResult> observer,
      Action<ActivePlan> deactivate)
    {
      Action<Exception> onError = new Action<Exception>(observer.OnError);
      JoinObserver<T1> firstJoinObserver = Plan<TResult>.CreateObserver<T1>(externalSubscriptions, this.Expression.First, onError);
      JoinObserver<T2> secondJoinObserver = Plan<TResult>.CreateObserver<T2>(externalSubscriptions, this.Expression.Second, onError);
      JoinObserver<T3> thirdJoinObserver = Plan<TResult>.CreateObserver<T3>(externalSubscriptions, this.Expression.Third, onError);
      JoinObserver<T4> fourthJoinObserver = Plan<TResult>.CreateObserver<T4>(externalSubscriptions, this.Expression.Fourth, onError);
      ActivePlan<T1, T2, T3, T4> activePlan = (ActivePlan<T1, T2, T3, T4>) null;
      activePlan = new ActivePlan<T1, T2, T3, T4>(firstJoinObserver, secondJoinObserver, thirdJoinObserver, fourthJoinObserver, (Action<T1, T2, T3, T4>) ((first, second, third, fourth) =>
      {
        TResult result1 = default (TResult);
        TResult result2;
        try
        {
          result2 = this.Selector(first, second, third, fourth);
        }
        catch (Exception ex)
        {
          observer.OnError(ex);
          return;
        }
        observer.OnNext(result2);
      }), (Action) (() =>
      {
        firstJoinObserver.RemoveActivePlan((ActivePlan) activePlan);
        secondJoinObserver.RemoveActivePlan((ActivePlan) activePlan);
        thirdJoinObserver.RemoveActivePlan((ActivePlan) activePlan);
        fourthJoinObserver.RemoveActivePlan((ActivePlan) activePlan);
        deactivate((ActivePlan) activePlan);
      }));
      firstJoinObserver.AddActivePlan((ActivePlan) activePlan);
      secondJoinObserver.AddActivePlan((ActivePlan) activePlan);
      thirdJoinObserver.AddActivePlan((ActivePlan) activePlan);
      fourthJoinObserver.AddActivePlan((ActivePlan) activePlan);
      return (ActivePlan) activePlan;
    }
  }
}
