// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ActivePlan`2
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;

namespace Microsoft.Phone.Reactive
{
  internal class ActivePlan<T1, T2> : ActivePlan
  {
    private readonly JoinObserver<T1> first;
    private readonly Action onCompleted;
    private readonly Action<T1, T2> onNext;
    private readonly JoinObserver<T2> second;

    internal ActivePlan(
      JoinObserver<T1> first,
      JoinObserver<T2> second,
      Action<T1, T2> onNext,
      Action onCompleted)
    {
      this.onNext = onNext;
      this.onCompleted = onCompleted;
      this.first = first;
      this.second = second;
      this.AddJoinObserver((IJoinObserver) first);
      this.AddJoinObserver((IJoinObserver) second);
    }

    internal override void Match()
    {
      if (this.first.Queue.Count <= 0 || this.second.Queue.Count <= 0)
        return;
      Notification<T1> notification1 = this.first.Queue.Peek();
      Notification<T2> notification2 = this.second.Queue.Peek();
      if (notification1.Kind == NotificationKind.OnCompleted || notification2.Kind == NotificationKind.OnCompleted)
      {
        this.onCompleted();
      }
      else
      {
        this.Dequeue();
        this.onNext(notification1.Value, notification2.Value);
      }
    }
  }
}
