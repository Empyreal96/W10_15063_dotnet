// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Reactive.ScheduledItem
// Assembly: Microsoft.Phone.Reactive, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 095E4E3F-55C6-488B-BFF1-CBB397A51C98
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI234C~1.DLL

using System;
using System.Threading;

namespace Microsoft.Phone.Reactive
{
  internal class ScheduledItem : IComparable<ScheduledItem>
  {
    private static int count = int.MinValue;
    private readonly Action action;
    private readonly BooleanDisposable d = new BooleanDisposable();
    private readonly long id;
    private DateTimeOffset dueTime;

    public ScheduledItem(Action action, DateTimeOffset dueTime)
    {
      this.id = (long) Interlocked.Increment(ref ScheduledItem.count);
      this.action = action;
      this.dueTime = dueTime;
    }

    public Action Action => this.action;

    public DateTimeOffset DueTime => this.dueTime;

    public bool IsCanceled => this.d.IsDisposed;

    public int CompareTo(ScheduledItem other)
    {
      int num = this.dueTime.CompareTo(other.dueTime);
      return num != 0 ? num : this.id.CompareTo(other.id);
    }

    public IDisposable GetDisposable() => (IDisposable) this.d;
  }
}
