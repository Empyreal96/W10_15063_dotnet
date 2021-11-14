// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ActivePlan
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  internal abstract class ActivePlan
  {
    private readonly Dictionary<IJoinObserver, IJoinObserver> joinObservers = new Dictionary<IJoinObserver, IJoinObserver>();

    internal abstract void Match();

    protected void AddJoinObserver(IJoinObserver joinObserver)
    {
      Dictionary<IJoinObserver, IJoinObserver> joinObservers = this.joinObservers;
      IJoinObserver key = joinObserver;
      joinObservers.Add(key, key);
    }

    protected void Dequeue()
    {
      foreach (IJoinObserver joinObserver in this.joinObservers.Values)
        joinObserver.Dequeue();
    }
  }
}
