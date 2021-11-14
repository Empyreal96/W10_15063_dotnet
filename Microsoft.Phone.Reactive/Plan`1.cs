// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.Plan`1
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  public abstract class Plan<TResult>
  {
    internal Plan()
    {
    }

    internal abstract ActivePlan Activate(
      Dictionary<object, IJoinObserver> externalSubscriptions,
      IObserver<TResult> observer,
      Action<ActivePlan> deactivate);

    internal static JoinObserver<TSource> CreateObserver<TSource>(
      Dictionary<object, IJoinObserver> externalSubscriptions,
      IObservable<TSource> observable,
      Action<Exception> onError)
    {
      IJoinObserver joinObserver1 = (IJoinObserver) null;
      JoinObserver<TSource> joinObserver2;
      if (!externalSubscriptions.TryGetValue((object) observable, out joinObserver1))
      {
        joinObserver2 = new JoinObserver<TSource>(observable, onError);
        externalSubscriptions.Add((object) observable, (IJoinObserver) joinObserver2);
      }
      else
        joinObserver2 = (JoinObserver<TSource>) joinObserver1;
      return joinObserver2;
    }
  }
}
