// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.AsyncLock
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Reactive
{
  public sealed class AsyncLock
  {
    private readonly Queue<Action> queue = new Queue<Action>();
    private bool hasFaulted;
    private bool isAcquired;

    public void Wait(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      bool flag = false;
      lock (this.queue)
      {
        if (!this.hasFaulted)
        {
          this.queue.Enqueue(action);
          flag = !this.isAcquired;
          this.isAcquired = true;
        }
      }
      if (!flag)
        return;
      while (true)
      {
        Action action1 = (Action) null;
        lock (this.queue)
        {
          if (this.queue.Count > 0)
          {
            action1 = this.queue.Dequeue();
          }
          else
          {
            this.isAcquired = false;
            break;
          }
        }
        try
        {
          action1();
        }
        catch (Exception ex)
        {
          lock (this.queue)
          {
            this.queue.Clear();
            this.hasFaulted = true;
          }
          throw ex.PrepareForRethrow();
        }
      }
    }
  }
}
